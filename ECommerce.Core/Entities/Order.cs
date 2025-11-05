
using System.ComponentModel.DataAnnotations;


namespace ECommerce.Core.Entities
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        [ StringLength(50)]
        public string OrderNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public int AppUserId { get; set; }
        [ StringLength(50)]
        public string CustomerId { get; set; }
        [ StringLength(50)]
        public string BillingAddress { get; set; }
        [ StringLength(50)]
        public string DeliveryAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderLine>? OrderLines { get; set; }
        public AppUser? AppUser { get; set; }
        public EnumOrderState OrderState { get; set; }
    }
    public enum EnumOrderState
    {
        [Display(Name = "Waiting")]
        Waiting,
        [Display(Name = "Approved")]
        Approved,
        [Display(Name = "Shipped")]
        Shipped,
        [Display(Name = "Completed")]
        Completed,
        [Display(Name = "Cancelled")]
        Cancelled,
        [Display(Name = " Returned")]
        Returned
    }
}
