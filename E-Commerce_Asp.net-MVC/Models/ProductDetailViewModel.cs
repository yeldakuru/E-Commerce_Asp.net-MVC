using ECommerce.Core.Entities;

namespace ECommerce_UI.Models
{
    public class ProductDetailViewModel
    {
        public Product? Product { get; set; }

        public IEnumerable<Product>? RelatedProducts { get; set; }
    }
}
