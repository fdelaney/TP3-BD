﻿namespace TutoratAppl.ViewModel
{
    public class HelpedListVM
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string ToString()
        {
            return "Aidé : " + LastName + ", " + FirstName + ", " + EmailAddress;
        }
    }
}