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
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        // Foreign Key
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        // Navigation property for reviews
        public ICollection<Comment> Comments { get; set; }
    }
}
