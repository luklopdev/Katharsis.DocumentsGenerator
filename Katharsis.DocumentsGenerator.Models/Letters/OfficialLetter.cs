using Katharsis.DocumentsGenerator.Models.Interfaces;
using Katharsis.DocumentsGenerator.Models.Interfaces.Letters;
using System;

namespace Katharsis.DocumentsGenerator.Models.Letters
{
    public class OfficialLetter : ModelBase, IOfficialLetter
    {

        private string? _city;
        public string City
        {
            get => _city!;
            set => SetProperty(ref _city, value);
        }

        private DateTime _date;
        public DateTime Date
        {
            get => _date;
            set => SetProperty(ref _date, value);
        }

        private IPerson? _sender;
        public IPerson Sender
        {
            get => _sender!;
            set => SetProperty(ref _sender, value);
        }

        private IPerson? _adressee;
        public IPerson Addressee
        {
            get => _adressee!;
            set => SetProperty(ref _adressee, value);
        }

        private string? _salutation;
        public string Salutation
        {
            get => _salutation!;
            set => SetProperty(ref _salutation, value);
        }

        private string? _content;
        public string Content
        {
            get => _content!;
            set => SetProperty(ref _content, value);
        }

        private string? _ending;
        public string Ending
        {
            get => _ending!;
            set => SetProperty(ref _ending, value);
        }

        private string? _signatureText;
        public string SignatureText
        {
            get => _signatureText!;
            set => SetProperty(ref _signatureText, value);
        }

        private byte[]? _signature;
        public byte[] Signature
        {
            get => _signature!;
            set => SetProperty(ref _signature, value);
        }
    }
}
