using System;

namespace DataLayer.Model
{
    public class TutoringSession : Entity
    {
        public int Id { get; set; }
        public int HelpedId { get; set; }
        public int TutorId { get; set; }

        public DateTime DateSession { get; set; }
        public DateTime TimeSession { get; set; }
        public int LengthSession { get; set; }

        private TutoringSession()
        {
        }
    }
}