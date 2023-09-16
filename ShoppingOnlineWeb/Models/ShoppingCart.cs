using System.ComponentModel.DataAnnotations;

namespace ShoppingOnlineWeb.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartID { get; set; }
        [Required]
        public string UserId { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
