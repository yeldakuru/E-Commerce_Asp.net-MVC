using ECommerce.Core.Entities;

namespace ECommerce_UI.Models
{
    public class CartViewModel
    {
        public List<CartLine> CartLines{ get; set; }
        public decimal TotalPrice { get; set; }

    }
}
