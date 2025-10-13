﻿

using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Entities
{
    public  class News: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool IsActive { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }=DateTime.Now;
    }
}
