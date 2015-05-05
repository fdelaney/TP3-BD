using System;

namespace DataLayer.Model
{
    public class TutoringSession : Entity
    {
        public int HelpedId { get; set; }

        public int TutorId { get; set; }

        public DateTime DateTimeSession { get; set; }

        public int LengthSession { get; set; }

        public virtual HelpedStudent Helped { get; set; }

        public virtual Tutor Tutor { get; set; }
    }
}