using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingOnlineWeb.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public string? Image { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public int StockQuantity { get; set; }

        // Foreign Key
        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        // Navigation property for reviews
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
        public ICollection<CartDetail>? CartDetails { get; set; }

    }
}
