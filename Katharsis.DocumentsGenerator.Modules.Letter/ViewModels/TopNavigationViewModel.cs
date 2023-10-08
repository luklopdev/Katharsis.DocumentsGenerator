using Katharsis.DocumentsGenerator.Core;
using Katharsis.DocumentsGenerator.Modules.Letter.Views;
using Prism.Commands;
using Prism.Regions;

namespace Katharsis.DocumentsGenerator.Modules.Letter.ViewModels
{
    public class TopNavigationViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;

        private DelegateCommand _officalLetterCommand = default!;
        public DelegateCommand OfficialLetterCommand =>
            _officalLetterCommand ?? (_officalLetterCommand = new DelegateCommand(ExecuteOfficialLetterCommand));

        public TopNavigationViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        void ExecuteOfficialLetterCommand()
        {
            _regionManager.RequestNavigate(RegionNames.MAIN_CONTENT, nameof(OfficialLetterFormView));
        }
    }
}
