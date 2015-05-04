using DataLayer.Model;
using System.Data.Entity;
using System.Linq;

namespace DataLayer.EfEntityFramework
{
    public class EfEntityRepository<T> : IEntityRepository<T> where T : Entity
    {
        private readonly DbContext _context;

        public EfEntityRepository()
        {
            _context = new TutoringDbContext();
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }

        public T SingleId(int id)
        {
            return _context.Set<T>().SingleOrDefault(t => t.Id == id);
        }

       public  void Delete(T entity)
        {
           _context.Entry<T>(entity).State = System.Data.Entity.EntityState.Deleted;
           _context.SaveChanges();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges(); 
        }

        public void DeleteAll()
        {
            _context.Set<T>().RemoveRange(_context.Set<T>());
            _context.SaveChanges();
        }
    }
}