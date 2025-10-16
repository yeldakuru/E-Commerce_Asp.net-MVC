﻿
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Entities
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool IsActive { get; set; }
        public bool IsTopMenu { get; set; }
        public int ParentId { get; set; }
        public int OrderNo { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }= DateTime.Now;
        public IList<Product>? Products { get; set; }//bir categorynin birden fazla productı olabilir
    }
}
