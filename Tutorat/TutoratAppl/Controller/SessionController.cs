using System.Collections.Generic;
using System.Linq;
using DataLayer;
using DataLayer.Model;
using TutoratAppl.ViewModel;

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
            var sessions = _sessionRepo.GetAll().ToList<TutoringSession>();

            var sessionsVM = new List<SessionListVM>();

            foreach (TutoringSession s in sessions)
            {
                sessionsVM.Add(new SessionListVM()
                {
                    DateTimeSession = s.DateTimeSession,
                    HelpedFirstName = s.Helped.FirstName,
                    HelpedLastName = s.Helped.LastName,
                    Id = s.Id,
                    LenghtSession = s.LengthSession,
                    TutorFirstName = s.Tutor.FirstName,
                    TutorLastName = s.Tutor.LastName

                });
            }

            new SessionListView(sessionsVM).Display();
        }
    }
}