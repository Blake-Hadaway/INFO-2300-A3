﻿using System.ComponentModel.DataAnnotations;

namespace ConestogaVirtualGameStore.Models
{
	public class Game
	{
        public int GameId { get; set; }

		[Required]
		[StringLength(100)]
		public string Title { get; set; }

		[Required]
		[StringLength (50)]
		public string Genere { get; set; }

		[Required]
		public DateTime ReleaseDate { get; set; }
		[StringLength (2000)]
		public string Description { get; set; }

		[Required]
		public string Platform { get; set; }

		[Required]
		[Range(1, 200)]
		public decimal Price { get; set; }

		[Range(0, 5)]
        public decimal AverageRating { get; set; }

        [Required]
		[StringLength(255)]
		public string CoverImageURL { get; set; }
        public ICollection<Wishlist_Games> Wishlist_Games { get; set; }

		public ICollection<CartGames> Cart_Games { get; set; }

		public ICollection<Review> Game_Reviews { get; set; }

        public List<int>? Purchased_Member_ID { get; set; }

    }
}
