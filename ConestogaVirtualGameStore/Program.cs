using ConestogaVirtualGameStore.Models;
using ConestogaVirtualGameStore.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ConestogaVirtualGameStore.AppDbContext;
using ConestogaVirtualGameStore.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<VirtualGameStoreContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IRepository<Game>, Repository<Game>>();
builder.Services.AddScoped<IRepository<Event>, Repository<Event>>();
builder.Services.AddScoped<IRepository<Member>, Repository<Member>>();
builder.Services.AddScoped<IRepository<MemberEvent>, Repository<MemberEvent>>();
builder.Services.AddScoped<IRepository<Wishlist>, Repository<Wishlist>>();
builder.Services.AddScoped<IRepository<Wishlist_Games>, Repository<Wishlist_Games>>();
builder.Services.AddScoped<IRepository<Cart>, Repository<Cart>>();
builder.Services.AddScoped<IRepository<CartGames>, Repository<CartGames>>();
builder.Services.AddScoped<IRepository<CreditCards>, Repository<CreditCards>>();
builder.Services.AddScoped<IRepository<Orders>, Repository<Orders>>();
builder.Services.AddScoped<IRepository<Review>, Repository<Review>>();

builder.Services.AddScoped<IRepository<Member>, Repository<Member>>();
builder.Services.AddScoped<IRepository<Relationship>, Repository<Relationship>>();
builder.Services.AddScoped<IRepository<MemberRelationship>, Repository<MemberRelationship>>();
builder.Services.AddScoped<IReportService, ReportService>();

builder.Services.AddScoped<EmailService>();
// Add Identity services
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<VirtualGameStoreContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login"; 
    options.AccessDeniedPath = "/Account/AccessDenied";
});

var app = builder.Build();

// Create roles and admin user
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

    await CreateRoles(roleManager, userManager);
}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



async Task CreateRoles(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
{
	String[] roleNames = { "Admin", "Member" };
	IdentityResult roleResult;

	foreach (var roleName in roleNames)
	{
		var roleExist = await roleManager.RoleExistsAsync(roleName);
		if (!roleExist)
		{
			roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
		}
	}

	var adminUser = new ApplicationUser
	{
		UserName = "admin@game.com",
		Email = "admin@game.com",
		FirstName = "Admin",
		LastName = "User"
	};

	var userPassword = "Admin@123";
	var user = await userManager.FindByEmailAsync("admin@game.com");

	if(user == null)
	{
		var createPowerUser = await userManager.CreateAsync(adminUser, userPassword);
		if (createPowerUser.Succeeded)
		{
			await userManager.AddToRoleAsync(adminUser, "Admin");
		}
	}
}