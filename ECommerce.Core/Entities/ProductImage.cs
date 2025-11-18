using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Entities
{
    public class ProductImage:IEntity
    {
        public int Id { get; set; }
        [Display(Name="Image Name"),StringLength(240)]
        public string? Name { get; set; }
        [Display(Name = "Description(Bottom Tag)"),StringLength(240)]
        public string? Bottom { get; set; }
        [Display(Name = "Product")]
        public int? ProductId { get; set; }
        [Display(Name = "Product")]
        public Product? Product { get; set; }
    }
}
