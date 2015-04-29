using DataLayer.Model;

namespace DataLayer.EfEntityFramework
{
    public class EfDataBaseHelper
    {
        private EfEntityRepository<Tutor> _tutorRepository;
        private EfEntityRepository<TutoringSession> _tutoringSessionRepository;
        private EfEntityRepository<HelpedStudent> _helpedStudentRepository;

        public void seedTable()
        {
            fillTutor();
            fillHelpedStudent();
            fillTutoringSession();
        }
        private void fillTutor()
        {
            _tutorRepository.Add(new Tutor());
        }
        private void fillHelpedStudent()
        {
            _helpedStudentRepository.Add(new HelpedStudent());
        }

        private void fillTutoringSession()
        {
            _tutoringSessionRepository.Add(new TutoringSession());
        }
    }
}