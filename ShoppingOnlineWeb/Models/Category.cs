
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingOnlineWeb.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        public string Name { get; set; }

        // Navigation property to Products
        public ICollection<Product> Products { get; set; }
    }
}
