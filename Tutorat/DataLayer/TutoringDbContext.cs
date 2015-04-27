using DataLayer.Model;
using System.Data.Entity;

namespace DataLayer
{
    internal class TutoringDbContext
    {
        public DbSet<Tutor> Tutors { get; set; }

        public DbSet<HelpedStudent> HelpedStudents { get; set; }

        public DbSet<TutoringSession> TutoringSessions { get; set; }
    }
}