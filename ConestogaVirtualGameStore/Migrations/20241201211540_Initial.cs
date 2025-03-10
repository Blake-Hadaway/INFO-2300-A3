﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConestogaVirtualGameStore.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Member_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PreferredLanguage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PreferredPlatform = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PreferredCategory = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ReceivePromotionalEmails = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Apt_suit = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Province = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Postal_Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DeliveryInstruction = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Phone_Number = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Language_ID = table.Column<int>(type: "int", nullable: true),
                    Cart_ID = table.Column<int>(type: "int", nullable: true),
                    Register_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Member_ID);
                });

            migrationBuilder.CreateTable(
                name: "Relationships",
                columns: table => new
                {
                    Relationship_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Relationship_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationships", x => x.Relationship_ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Cart_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Member_ID = table.Column<int>(type: "int", nullable: false),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Cart_ID);
                    table.ForeignKey(
                        name: "FK_Carts_Members_Member_ID",
                        column: x => x.Member_ID,
                        principalTable: "Members",
                        principalColumn: "Member_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    CreditCard_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Member_ID = table.Column<int>(type: "int", nullable: false),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(19)", maxLength: 19, nullable: false),
                    CreditCardExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreditCardOwnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditCardVerificationValue = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.CreditCard_ID);
                    table.ForeignKey(
                        name: "FK_CreditCards_Members_Member_ID",
                        column: x => x.Member_ID,
                        principalTable: "Members",
                        principalColumn: "Member_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MembersEvents",
                columns: table => new
                {
                    MemberEvent_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Event_ID = table.Column<int>(type: "int", nullable: false),
                    Member_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembersEvents", x => x.MemberEvent_ID);
                    table.ForeignKey(
                        name: "FK_MembersEvents_Events_Event_ID",
                        column: x => x.Event_ID,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MembersEvents_Members_Member_ID",
                        column: x => x.Member_ID,
                        principalTable: "Members",
                        principalColumn: "Member_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Order_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Member_ID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Order_ID);
                    table.ForeignKey(
                        name: "FK_Orders_Members_Member_ID",
                        column: x => x.Member_ID,
                        principalTable: "Members",
                        principalColumn: "Member_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishlist",
                columns: table => new
                {
                    Wishlist_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wishlist_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Member_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlist", x => x.Wishlist_ID);
                    table.ForeignKey(
                        name: "FK_Wishlist_Members_Member_ID",
                        column: x => x.Member_ID,
                        principalTable: "Members",
                        principalColumn: "Member_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MembersRelationships",
                columns: table => new
                {
                    MemberRelationshipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Member_ID = table.Column<int>(type: "int", nullable: false),
                    Relationship_ID = table.Column<int>(type: "int", nullable: false),
                    MemberAdded_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembersRelationships", x => x.MemberRelationshipId);
                    table.ForeignKey(
                        name: "FK_MembersRelationships_Members_MemberAdded_ID",
                        column: x => x.MemberAdded_ID,
                        principalTable: "Members",
                        principalColumn: "Member_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MembersRelationships_Members_Member_ID",
                        column: x => x.Member_ID,
                        principalTable: "Members",
                        principalColumn: "Member_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MembersRelationships_Relationships_Relationship_ID",
                        column: x => x.Relationship_ID,
                        principalTable: "Relationships",
                        principalColumn: "Relationship_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Genere = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Platform = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AverageRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CoverImageURL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Purchased_Member_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrdersOrder_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Orders_OrdersOrder_ID",
                        column: x => x.OrdersOrder_ID,
                        principalTable: "Orders",
                        principalColumn: "Order_ID");
                });

            migrationBuilder.CreateTable(
                name: "CartGames",
                columns: table => new
                {
                    Cart_ID = table.Column<int>(type: "int", nullable: false),
                    Game_ID = table.Column<int>(type: "int", nullable: false),
                    CartGames_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartGames", x => new { x.Cart_ID, x.Game_ID });
                    table.ForeignKey(
                        name: "FK_CartGames_Carts_Cart_ID",
                        column: x => x.Cart_ID,
                        principalTable: "Carts",
                        principalColumn: "Cart_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartGames_Games_Game_ID",
                        column: x => x.Game_ID,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Game_ID = table.Column<int>(type: "int", nullable: false),
                    Member_ID = table.Column<int>(type: "int", nullable: false),
                    Review_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ReviewDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ReviewRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => new { x.Game_ID, x.Member_ID });
                    table.ForeignKey(
                        name: "FK_Reviews_Games_Game_ID",
                        column: x => x.Game_ID,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Members_Member_ID",
                        column: x => x.Member_ID,
                        principalTable: "Members",
                        principalColumn: "Member_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishlist_Games",
                columns: table => new
                {
                    Wishlist_ID = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlist_Games", x => new { x.Wishlist_ID, x.GameId });
                    table.ForeignKey(
                        name: "FK_Wishlist_Games_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wishlist_Games_Wishlist_Wishlist_ID",
                        column: x => x.Wishlist_ID,
                        principalTable: "Wishlist",
                        principalColumn: "Wishlist_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Address", "City", "Country", "Date", "Description", "Name", "PostalCode", "Province" },
                values: new object[,]
                {
                    { 1, "108 University Ave E", "Waterloo", "Canada", new DateTime(2024, 12, 15, 14, 30, 0, 0, DateTimeKind.Unspecified), "A meetup event with the Conestoga Esports team and their fans", "Conestoga Esports Meetup", "N2J 2W2", "Ontario" },
                    { 2, "299 Doon Valley Dr", "Kitchener", "Canada", new DateTime(2024, 12, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "A retro game sale with many popular and beloved classic games", "Conestoga Retro Game Sale", "N2G 4M4", "Ontario" },
                    { 3, "775 Main Street East", "Milton", "Canada", new DateTime(2024, 12, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), "A game convention with sales, fan-favourite game actors, and sneak peak on new game releases on the Conestoga Video Game Store website", "Conestoga Gaming Convention", "L9T 3Z3", "Ontario" },
                    { 4, "850 Fountain Street South", "Cambridge", "Canada", new DateTime(2024, 12, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), "A game tournament that has competitors facing each other in various fighting and fps games to win a cash prize", "Conestoga Gaming Tournament", "N3H 0A8", "Ontario" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "AverageRating", "CoverImageURL", "Description", "Genere", "OrdersOrder_ID", "Platform", "Price", "Purchased_Member_ID", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202208/1718/NFf86jgU4AeVYgJBEoEKBpxW.jpg", "An action RPG set in a historical setting, featuring stealth and combat elements.", "Action RPG", null, "PlayStation 5, Xbox Series X/S, PC", 59.99m, null, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Mirage" },
                    { 2, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202308/1722/15f4ab1e0fe6a37609b164362a653c0e5bcee98a861d0f10.png", "The latest installment in the Call of Duty series, offering intense first-person shooter action.", "First-Person Shooter", null, "PlayStation 5, Xbox Series X/S, PC", 69.99m, null, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Call of Duty MW3" },
                    { 3, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202008/0416/6Bo40lnWU0BhgrOUm7Cb6by3.png", "A futuristic open-world RPG set in the dystopian Night City, filled with cybernetic enhancements and complex narratives.", "Action RPG", null, "PlayStation 4, PlayStation 5, Xbox One, Xbox Series X/S, PC", 39.99m, null, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077" },
                    { 4, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202207/1210/4xJ8XB3bi888QTLZYdl7Oi0s.png", "An epic sequel to the critically acclaimed God of War, featuring Norse mythology and Kratos' journey.", "Action-Adventure", null, "PlayStation 4, PlayStation 5", 69.99m, null, new DateTime(2022, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "God of War Ragnarok" },
                    { 5, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202207/2509/85p2Dwh5iDhUzRKe40QeNYh3.png", "A modern remake of the classic survival horror game, offering updated graphics and gameplay mechanics.", "Survival Horror", null, "PlayStation 4, PlayStation 5, Xbox Series X/S, PC", 59.99m, null, new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 4 Remake" },
                    { 6, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202312/0117/315718bce7eed62e3cf3fb02d61b81ff1782d6b6cf850fa4.png", "A narrative-driven action-adventure game that continues the story of Ellie and Joel in a post-apocalyptic world.", "Action-Adventure", null, "PlayStation 4", 59.99m, null, new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Last of Us: Part 2" },
                    { 7, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202110/2000/phvVT0qZfcRms5qDAk0SI3CM.png", "In a dark fantasy world created by Hidetaka Miyazaki (Dark Souls) and George R. R. Martin (A Song of Ice and Fire), the player is a Tarnished who is called back to the Lands Between to restore the Elden Ring and become the Elden Lord.", "Action RPG", null, "PlayStation 4, PlayStation 5, Xbox One, Xbox Series X/S, PC", 69.99m, null, new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elden Ring" },
                    { 8, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202205/2800/W5uSEsW7yefCNTHatS03v5q7.png", "Task Force 141 faces its greatest threat yet - a newly aligned menace with deep, yet unknown, connections.", "First-Person Shooter", null, "PlayStation 4, PlayStation 5, Xbox One, Xbox Series X/S, PC", 59.99m, null, new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Call of Duty: Modern Warfare II" },
                    { 9, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202009/2419/BWMVfyxONkIAlAJVQd96qPuN.png", "In the post-apocalyptic Boston, Massachusetts area, you play as the Sole Survivor of Vault 111, recently revived from centuries of forced cryostasis, determined to find your kidnapped son.", "Action RPG", null, "PlayStation 4, PlayStation 5, Xbox One, Xbox Series X/S, PC", 59.99m, null, new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fallout 4" },
                    { 10, 0m, "https://image.api.playstation.com/cdn/UP0002/CUSA08829_00/xmKUnAOenEAKspB3FlOg80aQZfEoCYcE.png", "Captain Price and the SAS partner with the CIA and the Urzikstani Liberation Force to retrieve stolen chemical weapons. The fight takes you from London to the Middle East and beyond, as this joint task force battles to stop a global war.", "First-Person Shooter", null, "PlayStation 4, PlayStation 5, Xbox One, Xbox Series X/S, PC", 59.99m, null, new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Call of Duty: Modern Warfare" },
                    { 11, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202306/1219/1c7b75d8ed9271516546560d219ad0b22ee0a263b4537bd8.png", "Spider-Men, Peter Parker and Miles Morales, return for an exciting new adventure in the critically acclaimed Marvel's Spider-Man franchise.", "Action-Adventure", null, "PlayStation 5", 69.99m, null, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider-Man 2" },
                    { 12, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202405/2921/2819b5df32c19b4b9e972dc3281b474937bb2570312b38a2.png", "As the Gulf War seizes the world's attention, a covert and enigmatic group has penetrated the upper echelons of the CIA, labeling those who oppose them as betrayers. Black Ops veteran Frank Woods and his squad, once celebrated as heroes by their agency and nation, now find themselves banished and pursued by the very military entity that forged them. They are now outcasts in their own land, hunted by the machinery of war that they once served.", "First-Person Shooter", null, "PlayStation 4, PlayStation 5, Xbox One, Xbox Series X/S, PC", 69.99m, null, new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Call of Duty: Black Ops 6" },
                    { 13, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202401/2910/d48262b72a5a2daa3ca3aed6c8f42c44f3fdaf2902265a13.png", "Until Dawn is a branching narrative survival horror game in which any choice of action by the player may cause other consequences later in the story. It was rebuilt from the ground up with stunning visuals in Unreal Engine 5.", "Survival Horror", null, "PlayStation 5, PC", 69.99m, null, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Until Dawn" },
                    { 14, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202210/2000/IgwsFz9BiBrFvyV7pIWpoVgd.png", "Having received a letter from his deceased wife, James heads to where they shared so many memories, in the hope of seeing her one more time: Silent Hill. There, by the lake, he finds a woman eerily similar to her.", "Survival Horror", null, "PlayStation 5, PC", 69.99m, null, new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Silent Hill 2 Remake" },
                    { 15, 0m, "https://image.api.playstation.com/vulcan/img/rnd/202010/2217/p3pYq0QxntZQREXRVdAzmn1w.png", "After wiping out the gods of Mount Olympus, Kratos moves on to the frigid lands of Scandinavia, where he and his son must embark on an odyssey across a dangerous world of gods and monsters.", "Action-Adventure", null, "PlayStation 5, PC", 69.99m, null, new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "God of War" },
                    { 16, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202305/2420/83ef93949d474052cc87b86617a5498505d4b50390280394.jpg", "13 years after bestselling writer Alan Wake went missing, a string of ritualistic murders occur in the town of Bright Falls, Washington. Saga Anderson, an FBI agent, is sent to Bright Falls to investigate the murders.", "Survival Horror", null, "Xbox Series X/S, PlayStation 5, PC", 69.99m, null, new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alan Wake II" },
                    { 17, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202405/3123/1abfc0f37be11993bd5e67fcb1a9e2c0d656142ace2f232e.png", "After millions have been slaughtered by the actions of the High Heavens and Burning Hells alike. In the power vacuum, a legendary name resurfaces - Lilith, daughter of Mephisto, the whispered progenitor of humanity.", "Action RPG", null, "Xbox Series X/S, PlayStation 5, PC", 69.99m, null, new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diablo IV" },
                    { 18, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202209/2121/UlfMBx2yUHge8Vlz7eszqw13.png", "A team of soldiers and militarists are recruited into an elite counter terrorism unit. Their objective is to fight terrorism across the globe. A threat has emerged that targets the Western world and its interests around the world.", "First-Person Shooter", null, "Xbox Series X/S, PlayStation 5, PC", 50.00m, null, new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rainbow Six: Siege" },
                    { 19, 0m, "https://image.api.playstation.com/vulcan/img/cfn/113078vQ_SpN-Wt1Ejgw5dPLXKnMvMfvZuekrerzhAOXaNrwZuCL6R6YEP4lUSGhMDthl6iyr4LbA_w565pBSa1xbUcHXtH8.png", "You are Jesse Faden, a young woman with a troubled past. You become the new Director of the Bureau of Control - Our frontline in researching and fighting against supernatural enemies like the Hiss threatening our very existence.", "Action-Adventure", null, "Xbox Series X/S, PlayStation 5, PC", 69.99m, null, new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Control" },
                    { 20, 0m, "https://image.api.playstation.com/vulcan/ap/rnd/202101/0812/FkzwjnJknkrFlozkTdeQBMub.png", "Ethan Winters' world suddenly comes crashing down when Chris Redfield's appearance sets off a chain of events that ultimately leads him to a mysterious village.", "Survival Horror", null, "Xbox Series X/S, PlayStation 5, PC", 69.99m, null, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil Village" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Member_ID", "Apt_suit", "Cart_ID", "City", "Country", "DateOfBirth", "DeliveryInstruction", "Email", "FirstName", "Gender", "Language_ID", "LastName", "Password", "Phone_Number", "Postal_Code", "PreferredCategory", "PreferredLanguage", "PreferredPlatform", "Province", "ReceivePromotionalEmails", "Register_Date", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Apt 101", null, "Toronto", "Canada", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leave at front door", "john.doe@example.com", "John", "Male", null, "Doe", "password123", "123-456-7890", "M5A 1A1", "Action", "English", "PC", "ON", true, new DateTime(2024, 12, 1, 16, 15, 39, 774, DateTimeKind.Local).AddTicks(328), "123 Main St" },
                    { 2, "Apt 202", null, "Montreal", "Canada", new DateTime(1992, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Call upon arrival", "jane.smith@example.com", "Jane", "Female", null, "Smith", "password456", "987-654-3210", "H2X 1A1", "RPG", "French", "PlayStation", "QC", false, new DateTime(2024, 12, 1, 16, 15, 39, 774, DateTimeKind.Local).AddTicks(442), "456 Elm St" },
                    { 3, "Suite 300", null, "Vancouver", "Canada", new DateTime(1995, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leave with concierge", "alex.johnson@example.com", "Alex", "Non-binary", null, "Johnson", "password789", "321-654-9870", "V5K 1A1", "Shooter", "English", "Xbox", "BC", true, new DateTime(2024, 12, 1, 16, 15, 39, 774, DateTimeKind.Local).AddTicks(455), "789 Maple Ave" },
                    { 4, null, null, "Calgary", "Canada", new DateTime(1995, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "david.lee@example.com", "David", "Male", null, "Lee", "Dav!d1234", "403-555-0100", "T2P 1J9", "Action", "Chinese", "PC", "AB", false, new DateTime(2023, 12, 1, 16, 15, 39, 774, DateTimeKind.Local).AddTicks(460), "101 Cedar Blvd" },
                    { 5, "5C", null, "Edmonton", "Canada", new DateTime(2000, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leave with concierge", "evelyn.brown@example.com", "Evelyn", "Female", null, "Brown", "P@ssw0rd!", "780-555-0112", "T5J 1G9", "Strategy", "German", "Xbox", "AB", true, new DateTime(2024, 11, 16, 16, 15, 39, 774, DateTimeKind.Local).AddTicks(468), "303 Birch Lane" },
                    { 6, null, null, "Ottawa", "Canada", new DateTime(1988, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "frank.nguyen@example.com", "Frank", "Male", null, "Nguyen", "Fr@nk4321", "613-555-0185", "K1P 1A5", "Action", "Danish", "PC", "ON", false, new DateTime(2024, 3, 1, 16, 15, 39, 774, DateTimeKind.Local).AddTicks(476), "567 Elm St" },
                    { 7, null, null, "Hamilton", "Canada", new DateTime(1993, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hand to resident", "gina.walker@example.com", "Gina", "Female", null, "Walker", "Gin@123!", "905-555-0133", "L8P 3B5", "RPG", "Italian", "Playstation", "ON", true, new DateTime(2024, 8, 1, 16, 15, 39, 774, DateTimeKind.Local).AddTicks(483), "234 Spruce Ave" },
                    { 8, "7F", null, "Windsor", "Canada", new DateTime(1975, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "henry.perez@example.com", "Henry", "Male", null, "Perez", "HenrY!678", "519-555-0154", "N9A 6Z8", "Horror", "Spanish", "PC", "ON", false, new DateTime(2022, 12, 1, 16, 15, 39, 774, DateTimeKind.Local).AddTicks(488), "128 Cypress Ct" },
                    { 9, null, null, "Toronto", "Canada", new DateTime(1996, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ivy.robinson@example.com", "Ivy", "Female", null, "Robinson", "IvY2024!", "416-555-0213", "M5G 2M1", "Sports", "English", "Xbox", "ON", true, new DateTime(2024, 7, 1, 16, 15, 39, 774, DateTimeKind.Local).AddTicks(494), "104 Willow Dr" },
                    { 10, "2A", null, "Montreal", "Canada", new DateTime(1993, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leave in mailbox", "jack.martinez@example.com", "Jack", "Male", null, "Martinez", "J@ckMart123", "514-555-0183", "H3B 4P2", "Horror", "French", "PlayStation", "QC", false, new DateTime(2024, 10, 1, 16, 15, 39, 774, DateTimeKind.Local).AddTicks(499), "789 Walnut St" },
                    { 11, null, null, "Calgary", "Canada", new DateTime(1998, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deliver to back door", "karen.taylor@example.com", "Karen", "Female", null, "Taylor", "K@r3nT@yl0r", "403-555-0157", "T2P 2R8", "Adventure", "English", "Switch", "AB", true, new DateTime(2024, 2, 1, 16, 15, 39, 774, DateTimeKind.Local).AddTicks(503), "562 Maple Grove" },
                    { 12, null, null, "Ottawa", "Canada", new DateTime(1989, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "leo.gonzales@example.com", "Leo", "Male", null, "Gonzales", "Le0G0nz@!", "613-555-0114", "K2P 1X4", "Strategy", "Spanish", "PC", "ON", false, new DateTime(2024, 5, 1, 16, 15, 39, 774, DateTimeKind.Local).AddTicks(508), "90 Forest Hill" },
                    { 13, "4D", null, "Vancouver", "Canada", new DateTime(1992, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "mia.liu@example.com", "Mia", "Female", null, "Liu", "Mi@LiuPass1", "604-555-0179", "V6B 1N9", "Sports", "Chinese", "PlayStation", "BC", true, new DateTime(2024, 11, 6, 16, 15, 39, 774, DateTimeKind.Local).AddTicks(513), "456 King St" }
                });

            migrationBuilder.InsertData(
                table: "Relationships",
                columns: new[] { "Relationship_ID", "Relationship_Type" },
                values: new object[,]
                {
                    { 1, "Friend" },
                    { 2, "Family" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartGames_Game_ID",
                table: "CartGames",
                column: "Game_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_Member_ID",
                table: "Carts",
                column: "Member_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CreditCards_Member_ID",
                table: "CreditCards",
                column: "Member_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_OrdersOrder_ID",
                table: "Games",
                column: "OrdersOrder_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MembersEvents_Event_ID",
                table: "MembersEvents",
                column: "Event_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MembersEvents_Member_ID",
                table: "MembersEvents",
                column: "Member_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MembersRelationships_Member_ID",
                table: "MembersRelationships",
                column: "Member_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MembersRelationships_MemberAdded_ID",
                table: "MembersRelationships",
                column: "MemberAdded_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MembersRelationships_Relationship_ID",
                table: "MembersRelationships",
                column: "Relationship_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Member_ID",
                table: "Orders",
                column: "Member_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_Member_ID",
                table: "Reviews",
                column: "Member_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlist_Member_ID",
                table: "Wishlist",
                column: "Member_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlist_Games_GameId",
                table: "Wishlist_Games",
                column: "GameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartGames");

            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.DropTable(
                name: "MembersEvents");

            migrationBuilder.DropTable(
                name: "MembersRelationships");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Wishlist_Games");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Relationships");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Wishlist");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
