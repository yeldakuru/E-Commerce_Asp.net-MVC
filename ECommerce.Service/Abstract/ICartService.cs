using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.Abstract
{
    public interface ICartService
    {
        void AddProduct(Product product, int quantity);//ürün ekleme
        void UpdateProduct(Product product, int quantity);//ürün güncelleme
        void RemoveProduct(Product product);//ürün kaldırma
        decimal TotalPrice();//toplam fiyat hesaplama
        void ClearAll();//tüm ürünleri temizleme
    }
}
