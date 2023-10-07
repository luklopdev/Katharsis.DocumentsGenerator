using Katharsis.DocumentsGenerator.Models.Interfaces;

namespace Katharsis.DocumentsGenerator.Models
{
    public class Address : ModelBase, IAddress
    {
        private string? _street;
        public string Street 
        { 
            get => _street!; 
            set => SetProperty(ref _street, value); 
        }

        private string? _number;
        public string Number 
        {
            get => _number!; 
            set => SetProperty(ref _number, value); 
        }
        
        private string? _streetLine2;
        public string StreetLine2 
        {
            get => _streetLine2!;
            set => SetProperty(ref _streetLine2, value);
        }

        private string? _streetLine3;
        public string StreetLine3 
        {
            get => _streetLine3!;
            set => SetProperty(ref _streetLine3, value);
        }

        private string? _postCode;
        public string PostCode 
        {
            get => _postCode!;
            set => SetProperty(ref _postCode, value);
        }

        private string? _city;
        public string City 
        {
            get => _city!;
            set => SetProperty(ref _city, value);
        }
        
        private string? _country;
        public string Country 
        {
            get => _country!;
            set => SetProperty(ref _country, value);
        }
    }
}
