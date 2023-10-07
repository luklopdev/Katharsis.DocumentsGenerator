namespace Katharsis.DocumentsGenerator.Models.Interfaces
{
    public interface IPerson
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public IAddress Address { get; set; }
    }
}
