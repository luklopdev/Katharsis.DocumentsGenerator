namespace Katharsis.DocumentsGenerator.Models.Interfaces
{
    public interface IAddress
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string StreetLine2 { get; set; }
        public string StreetLine3 { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
