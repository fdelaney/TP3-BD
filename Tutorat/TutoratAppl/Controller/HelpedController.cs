using DataLayer;
using DataLayer.Model;

namespace TutoratAppl.Controller
{
    public class HelpedController
    {
        private readonly IEntityRepository<HelpedStudent> _helpedRepo;

        public HelpedController(IEntityRepository<HelpedStudent> _repository)
        {
            _helpedRepo = _repository;
        }

        public void ListAll()
        {
        }

        public void ListAllWhenWithoutTutoringSession()
        {
        }
    }
}