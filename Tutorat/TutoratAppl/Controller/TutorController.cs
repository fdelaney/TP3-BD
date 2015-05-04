using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Model;

namespace TutoratAppl.Controller
{
    public class TutorController
    {
        private readonly IEntityRepository<Tutor> _tutorRepo;

        public TutorController(IEntityRepository<Tutor> _repository)
        {
            _tutorRepo = _repository;
        }
    }
}
