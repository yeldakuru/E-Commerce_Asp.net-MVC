using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Entities
{
    public class Contact:IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} field cannot be left blank!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} field cannot be left blank!")]
        public string Surname{ get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        [Required(ErrorMessage = "{0} field cannot be left blank!")]
        public string Message { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }=DateTime.Now;//otomatik olarak oluşturulma tarihi atanır

    }
}
