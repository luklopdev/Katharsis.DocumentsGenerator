using Katharsis.DocumentsGenerator.Core;
using Katharsis.DocumentsGenerator.Modules.Letter.Menus;
using Katharsis.DocumentsGenerator.Modules.Letter.Views;
using Prism.Commands;
using Prism.Regions;

namespace Katharsis.DocumentsGenerator.Modules.Letter.ViewModels
{
    public class LettersMenuViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;

        private DelegateCommand _lettersSelectedCommand = default!;
        public DelegateCommand LettersSelectedCommand => _lettersSelectedCommand ??=
            new DelegateCommand(ExecuteLettersSelectedCommand);

        public LettersMenuViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        void ExecuteLettersSelectedCommand() 
        {
            _regionManager.RequestNavigate(RegionNames.TOP_NAVIGATION, nameof(TopNavigation));
            _regionManager.RequestNavigate(RegionNames.MAIN_CONTENT, nameof(LettersListView));
        }
    }
}
