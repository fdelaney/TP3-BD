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

        public T GetByID(int id)
        {
            throw new System.NotImplementedException();
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
           
        }
    }
}