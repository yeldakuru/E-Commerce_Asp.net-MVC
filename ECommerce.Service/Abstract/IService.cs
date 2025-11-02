using ECommerce.Core.Entities;
using System.Linq.Expressions;


namespace ECommerce.Service.Abstract
{
    public interface IService<T> where T : class,IEntity,new() //class olmalı, IEntity implemente etmeli ve newlenebilir olmalı
    {

        List<T> GetAll();//Tüm verileri listele
        List<T> GetAll(Expression<Func<T, bool>> expression);//expression parametresiyle şartlı filtreleme yapar
        IQueryable<T> GetQueryable();//sorgulanabilir nesne döner
        T Get(Expression<Func<T, bool>> expression);//koşula göre tek bir nesne döner
        T Find(int id);//id'ye göre nesne bulur
        void Add(T entity);//yeni nesne ekler
        void Update(T entity);
        void Delete(T entity);
        int SaveChanges();//veritabanında değişiklikleri kaydeder
        //Asenkron metotlar
        Task<T> FindAsync(int id);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression);//expression parametresiyle şartlı filtreleme yapar
        Task AddAsync(T entity);
        Task<int> SaveChangesAsync();

    }
}
