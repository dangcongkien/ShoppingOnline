using System.ComponentModel.DataAnnotations;

namespace ShoppingOnlineWeb.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public string UserId { get; set; }
        public DateTime dateTime { get; set; } = DateTime.Now;
        [Required]
        public int OrderStatusId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public OrderStatus OrderStatus { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }

    }
}
