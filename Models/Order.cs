﻿using System.ComponentModel.DataAnnotations;

namespace Fayroz.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string? RecipeId { get; set; }

        [Required]
        public string? RecipeName { get; set; }

        [Required]
        public string? UserId { get; set; }

        [Required]
        public string? Address { get; set;}

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set;}

        [Required]
        public decimal TotalAmount { get; set; }

        public DateTime DateTime { get;}

        public Order()
        {
            DateTime = DateTime.Now;
        }
    }
}
