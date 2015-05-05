using System.Collections.Generic;

namespace DataLayer.Model
{
    public class Tutor : Entity
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public virtual ICollection<TutoringSession> Sessions { get; set; }

        public string EmailAdress { get; set; }
    }
}