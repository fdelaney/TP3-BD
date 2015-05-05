namespace TutoratAppl.ViewModel
{
    internal class TutorWithLengthSessionListVM
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public int NbHeuresTotal { get; set; }

        public string ToString()
        {
            return LastName + ", " + FirstName + ", " + EmailAddress + " Total Heures Tutorat: " + NbHeuresTotal + " heures.";
        }
    }
}