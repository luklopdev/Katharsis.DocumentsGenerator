using Katharsis.DocumentsGenerator.Core;
using Katharsis.DocumentsGenerator.Models;
using Katharsis.DocumentsGenerator.Models.Interfaces.Letters;
using Katharsis.DocumentsGenerator.Models.Letters;
using System;
using System.Windows;

namespace Katharsis.DocumentsGenerator.Modules.Letter.ViewModels
{
    public class OfficialLetterFormViewModel : ViewModelBase
    {
        private IOfficialLetter _letter = default!;
        public IOfficialLetter Letter
        {
            get { return _letter; }
            set { SetProperty(ref _letter, value); }
        }

        public OfficialLetterFormViewModel()
        {
            InitializeLetter();
        }

        void InitializeLetter()
        {
            Letter = new OfficialLetter();
            Letter.Sender = new Person();
            Letter.Sender.Address = new Address();
            Letter.Addressee = new Person();
            Letter.Addressee.Address = new Address();

            Letter.Date = DateTime.Now;
        }
    }
}
