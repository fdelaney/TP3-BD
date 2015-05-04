using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using TutoratAppl.View;
using TutoratAppl.ViewModel;

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
            var tutors = _tutorRepo.GetAll().ToList<Tutor>();

            var tutorVM = new List<TutorListVM>();

            foreach (Tutor t in tutors)
            {
                tutorVM.Add(new TutorListVM()
                {
                    EmailAddress = t.EmailAddress,
                    FirstName = t.FirstName,
                    Id = t.Id,
                    LastName = t.LastName
                });
            }

            new TutorListView(tutorVM).Display();
        }

        public void ListAllWithWorkingHoursTotal()
        {
            
            var tutors = _tutorRepo.GetAll().ToList<Tutor>();

            var tutorVM = new List<TutorWithLengthSessionListVM>();

            foreach (Tutor t in tutors)
            {
                int nbHeuresTotal = 0;
                foreach (var s in t.Sessions)
                {
                    nbHeuresTotal += s.LengthSession;
                }

                tutorVM.Add(new TutorWithLengthSessionListVM()
                {
                    EmailAddress =  t.EmailAddress,
                    FirstName = t.FirstName,
                    LastName = t.LastName,
                    NbHeuresTotal = nbHeuresTotal
                });
            }

            new TutorWithLenghtSessionListView(tutorVM).Display();
        }

        public void ListWhenNextTutoringSession()
        {

        }

        public void ListWhenWithoutTutoringSession(DateTime sessionDate)
        {

        }
    }
}