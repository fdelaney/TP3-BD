using System.Collections.Generic;
using System.Linq;
using DataLayer;
using DataLayer.Model;
using TutoratAppl.ViewModel;

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
            var helped = _helpedRepo.GetAll().ToList<HelpedStudent>();

            var helpedVM = new List<HelpedListVM>();

            foreach (HelpedStudent s in helped)
            {
                helpedVM.Add(new HelpedListVM()
                {
                    

                });
            }

            new HelpedListView(helpedVM).Display();
        }

        public void ListAllWhenWithoutTutoringSession()
        {

        }
    }
}