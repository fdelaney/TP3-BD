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
            throw new System.NotImplementedException();
        }

        public void Add(T entity)
        {
            
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}