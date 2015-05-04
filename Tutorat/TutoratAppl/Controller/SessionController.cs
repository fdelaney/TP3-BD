using DataLayer;
using DataLayer.Model;
namespace TutoratAppl.Controller
{
    public class SessionController
    {
        private readonly IEntityRepository<TutoringSession> _sessionRepo;

        public SessionController(IEntityRepository<TutoringSession> _repository)
        {
            _sessionRepo = _repository;
        }

        public void ListAll()
        {

        }
    }
}