namespace DataLayer.Model
{
    public class Tutor : Entity
    {
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }
    }
}