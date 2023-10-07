using System;

namespace Katharsis.DocumentsGenerator.Models.Interfaces.Letters
{
    public interface IOfficialLetter
    {
        public string City { get; set; }
        public DateTime Date { get; set; }
        public IPerson Sender { get; set; }
        public IPerson Addressee { get; set; }
        public string Salutation { get; set; }
        public string Content { get; set; }
        public string Ending { get; set; }
        public string SignatureText { get; set; }
        public byte[] Signature { get; set; }

    }
}
