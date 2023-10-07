using Katharsis.DocumentsGenerator.Core;
using Katharsis.DocumentsGenerator.Views;
using Prism.Commands;
using Prism.Regions;

namespace Katharsis.DocumentsGenerator.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private IRegionManager _regionManger;

        private DelegateCommand _windowLoadedCommand = default!;
        public DelegateCommand WindowLoadedCommand => _windowLoadedCommand ??=
            new DelegateCommand(ExecuteWindowLoadedCommand);

        public MainWindowViewModel(IRegionManager regionManger)
        {
            _regionManger = regionManger;
        }

        void ExecuteWindowLoadedCommand()
        {
            _regionManger.RequestNavigate(RegionNames.MAIN_REGION, nameof(MainView));
        }
    }
}
