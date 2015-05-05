using System;

namespace TutoratAppl.ViewModel
{
    public class SessionListVM
    {
        public DateTime DateTimeSession { get; set; }

        public string HelpedFirstName { get; set; }

        public string HelpedLastName { get; set; }

        public int Id { get; set; }

        public int LenghtSession { get; set; }

        public string TutorFirstName { get; set; }

        public string TutorLastName { get; set; }

        public string ToString()
        {
            return DateTimeSession.ToString() + ", " + LenghtSession + " heure(s), " + HelpedLastName + " " + HelpedFirstName;
        }
    }
}