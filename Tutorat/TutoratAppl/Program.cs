using DataLayer.EfEntityFramework;
using DataLayer.Model;
using System;
using TutoratAppl.Controller;

namespace TutoratAppl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            EfDataBaseHelper _dbHelper = new EfDataBaseHelper();
            _dbHelper.SeedTable();

            var tutorController = new TutorController(new EfEntityRepository<Tutor>());
            //1ere
            Console.WriteLine("Requete #1: ");
            tutorController.ListAllWithWorkingHoursTotal();
            Console.WriteLine("--------------------------------------------------------------------------");

            //2e
            Console.WriteLine("Requete #2: ");
            tutorController.ListWhenNextTutoringSession();
            Console.WriteLine("--------------------------------------------------------------------------");

            //3e
            Console.WriteLine("Requete #3: ");
            var helpController = new HelpedController(new EfEntityRepository<HelpedStudent>());
            helpController.ListAllWhenWithoutTutoringSession();
            Console.WriteLine("--------------------------------------------------------------------------");

            //4e
            Console.WriteLine("Requete #4: ");
            tutorController.ListWhenWithoutTutoringSession(new DateTime(2015, 06, 02));
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}