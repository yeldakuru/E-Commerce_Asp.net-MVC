﻿

namespace ECommerce.Core.Entities
{
    public class AppUser : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string Password { get; set; }
        public string? UserName { get; set; }= string.Empty;//başlangıçta değeri boş string ("") olsun
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime CreateDate { get; set; } 
        public Guid? UserGuid { get; set; }=Guid.NewGuid();//varsayılan olarak benzersiz bir Guid ile başlasın,
                                                           //sonradan null atanabilir
    }
}
