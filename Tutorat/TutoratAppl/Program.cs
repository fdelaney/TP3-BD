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
            var helpController = new HelpedController(new EfEntityRepository<HelpedStudent>());
            var sessionController = new SessionController(new EfEntityRepository<TutoringSession>());

            //List All
            Console.WriteLine("Tous les Tuteurs:");
            tutorController.ListAll();
            Console.WriteLine("--------------------------------------------------------------------------");

            Console.WriteLine("Tous les Etudiants Aidés:");
            helpController.ListAll();
            Console.WriteLine("--------------------------------------------------------------------------");

            Console.WriteLine("Toutes les Sessions d'aide:");
            sessionController.ListAll();
            Console.WriteLine("--------------------------------------------------------------------------");

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