using Katharsis.DocumentsGenerator.Models.Interfaces;

namespace Katharsis.DocumentsGenerator.Models
{
    public class Person : ModelBase, IPerson
    {
        private string? _title;
        public string Title 
        {
            get => _title!;
            set => SetProperty(ref _title, value);
        }

        private string? _firstName;
        public string FirstName
        {
            get => _firstName!;
            set => SetProperty(ref _firstName, value);
        }

        private string? _lastName;
        public string LastName
        {
            get => _lastName!;
            set => SetProperty(ref _lastName, value);
        }

        private string? _phoneNumber;
        public string PhoneNumber
        {
            get => _phoneNumber!;
            set => SetProperty(ref _phoneNumber, value);
        }

        private string? _email;
        public string Email
        {
            get => _email!;
            set => SetProperty(ref _email, value);
        }

        private IAddress? _address;
        public IAddress Address
        {
            get => _address!;
            set => SetProperty(ref _address, value);
        }
    }
}
