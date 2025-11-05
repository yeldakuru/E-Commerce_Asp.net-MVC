using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Entities
{
    public class Address:IEntity
    {
        public int Id { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} field cannot be left blank!")]
        public string Title { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} field cannot be left blank!")]
        public string City { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} field cannot be left blank!")]
        public string District { get; set; }
        [DataType(DataType.MultilineText), Required(ErrorMessage = "{0} field cannot be left blank!")]
        public string OpenAddress { get; set; }
        public bool IsActive { get; set; }
        public bool IsBillingAddress { get; set; }
        public bool IsDeliveryAddress { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [ScaffoldColumn(false)]
        public Guid? AddressGuid { get; set; } = Guid.NewGuid();
        public int? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
