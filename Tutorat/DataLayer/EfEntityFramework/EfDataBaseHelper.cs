using System;
using DataLayer.Model;

namespace DataLayer.EfEntityFramework
{
    public class EfDataBaseHelper
    {
        private EfEntityRepository<Tutor> _tutorRepository;
        private EfEntityRepository<TutoringSession> _tutoringSessionRepository;
        private EfEntityRepository<HelpedStudent> _helpedStudentRepository;

        public void SeedTable()
        {
            _tutoringSessionRepository.DeleteAll();
            _tutorRepository.DeleteAll();
            _helpedStudentRepository.DeleteAll();


            Tutor t1 = new Tutor() {EmailAddress = "bgary2@hotmail.com", LastName = "Bilodeau", FirstName = "Gary"};
            Tutor t2 = new Tutor() { EmailAddress = "bgary2@hotmail.com", LastName = "Gagnon", FirstName = "Samuel" };
            Tutor t3 = new Tutor() { EmailAddress = "bgary2@hotmail.com", LastName = "Gingras", FirstName = "Simon" };
            Tutor t4 = new Tutor() { EmailAddress = "bgary2@hotmail.com", LastName = "Roy", FirstName = "Éric" };
            Tutor t5 = new Tutor() { EmailAddress = "bgary2@hotmail.com", LastName = "Veilleux", FirstName = "Caroline" };
            Tutor t6 = new Tutor() { EmailAddress = "bgary2@hotmail.com", LastName = "Tremblay", FirstName = "Karine" };
            Tutor t7 = new Tutor() { EmailAddress = "bgary2@hotmail.com", LastName = "Vézina", FirstName = "Louis" };

            _tutorRepository.Add(t1);
            _tutorRepository.Add(t2);
            _tutorRepository.Add(t3);
            _tutorRepository.Add(t4);
            _tutorRepository.Add(t5);
            _tutorRepository.Add(t6);
            _tutorRepository.Add(t7);

            HelpedStudent HS1 = new HelpedStudent() { EmailAdress = "marco.arso@hotmail.com" ,FirstName = "Marc", LastName = "Arsenault"};
            HelpedStudent HS2 = new HelpedStudent() { EmailAdress = "eric.r.boilard@coop.com", FirstName = "Éric", LastName = "Boilard" };
            HelpedStudent HS3 = new HelpedStudent() { EmailAdress = "jc.couture.wilde@hotmail.com", FirstName = "Jean-Cristophe", LastName = "Couture" };
            HelpedStudent HS4 = new HelpedStudent() { EmailAdress = "galypo13@hotmail.com", FirstName = "Julianne", LastName = "Desrosiers" };
            HelpedStudent HS5 = new HelpedStudent() { EmailAdress = "leoga@hotmail.com", FirstName = "Léo", LastName = "Grégoire-Allen" };
            HelpedStudent HS6 = new HelpedStudent() { EmailAdress = "fhamel@hotmail.com", FirstName = "François", LastName = "Hamel" };
            HelpedStudent HS7 = new HelpedStudent() { EmailAdress = "jlepage@hotmail.com", FirstName = "Jérémy", LastName = "Lepage" };
            HelpedStudent HS8 = new HelpedStudent() { EmailAdress = "npoitras@hotmail.com", FirstName = "Nicolas", LastName = "Poitras" };
            HelpedStudent HS9 = new HelpedStudent() { EmailAdress = "sroygagnon@hotmail.com", FirstName = "Samuel", LastName = "Roy-Gagnon" };
            HelpedStudent HS10 = new HelpedStudent() { EmailAdress = "bsimard@hotmail.com", FirstName = "Benjamin", LastName = "Simard" };
            HelpedStudent HS11 = new HelpedStudent() { EmailAdress = "svachon@hotmail.com", FirstName = "Samuel", LastName = "Vachon" };

            _helpedStudentRepository.Add(HS1);
            _helpedStudentRepository.Add(HS2);
            _helpedStudentRepository.Add(HS3);
            _helpedStudentRepository.Add(HS4);
            _helpedStudentRepository.Add(HS5);
            _helpedStudentRepository.Add(HS6);
            _helpedStudentRepository.Add(HS7);
            _helpedStudentRepository.Add(HS8);
            _helpedStudentRepository.Add(HS9);
            _helpedStudentRepository.Add(HS10);
            _helpedStudentRepository.Add(HS11);



            TutoringSession TS1 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS2 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS3 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS4 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS5 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS6 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS7 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS8 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS9 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS10 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS11 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS12 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS13 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS14 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS15 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS16 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS17 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
            TutoringSession TS18 = new TutoringSession() { DateTimeSession = new DateTime(2015, 03, 16, 13, 0, 0), HelpedId = HS5.Id, LengthSession = 2, TutorId = t5.Id };
        }
    }
}