using DataLayer;
using DataLayer.Model;
using System;

namespace TutoratAppl.Controller
{
    public class TutorController
    {
        private readonly IEntityRepository<Tutor> _tutorRepo;

        public TutorController(IEntityRepository<Tutor> _repository)
        {
            _tutorRepo = _repository;
        }

        public void ListAll()
        {
        }

        public void ListAllWithWorkingHoursTotal()
        {
        }

        public void ListWhenNextTutoringSession()
        {
        }

        public void ListWhenWithoutTutoringSession(DateTime sessionDate)
        {
        }
    }
}