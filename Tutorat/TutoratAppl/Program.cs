using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.EfEntityFramework;
using TutoratAppl.Controller;
using DataLayer.Model;

namespace TutoratAppl
{
    class Program
    {
        static void Main(string[] args)
        {
          EfDataBaseHelper _dbHelper = new EfDataBaseHelper();
          _dbHelper.SeedTable();

          var tutorController = new TutorController(new EfEntityRepository<Tutor>());
          
            //3e
          var helpController = new HelpedController(new EfEntityRepository<HelpedStudent>());
          helpController.ListAllWhenWithoutTutoringSession();

          Console.ReadKey();
        }
    }
}
