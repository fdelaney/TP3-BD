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

        IQueryable<T> IEntityRepository<T>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        T IEntityRepository<T>.GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        void IEntityRepository<T>.Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        void IEntityRepository<T>.Add(T entity)
        {
            throw new System.NotImplementedException();
        }

        void IEntityRepository<T>.Update(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}