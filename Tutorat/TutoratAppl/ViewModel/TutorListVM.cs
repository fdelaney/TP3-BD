﻿namespace TutoratAppl.ViewModel
{
    public class TutorListVM
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string NameAndEMailToString()
        {
            return NameToString() + ", " + EmailAddress;
        }

        public string NameToString()
        {
            return LastName + ", " + FirstName;
        }
    }
}