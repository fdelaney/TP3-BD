using DataLayer.Model;

namespace DataLayer.EfEntityFramework
{
    class EfDataBaseHelper
    {
        private EfEntityRepository<Tutor> _tutorRepository;
        private EfEntityRepository<TutoringSession> _tutoringSessionRepository;
        private EfEntityRepository<HelpedStudent> _helpedStudentRepository;
    }
}