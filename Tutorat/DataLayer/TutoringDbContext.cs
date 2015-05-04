using DataLayer.Model;
using System.Data.Entity;

namespace DataLayer
{
    public class TutoringDbContext : DbContext
    {
        public DbSet<Tutor> Tutors { get; set; }

        public DbSet<HelpedStudent> HelpedStudents { get; set; }

        public DbSet<TutoringSession> TutoringSessions { get; set; }
    }
}