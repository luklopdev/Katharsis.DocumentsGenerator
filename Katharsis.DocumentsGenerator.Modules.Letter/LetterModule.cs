using Katharsis.DocumentsGenerator.Core;
using Katharsis.DocumentsGenerator.Modules.Letter.Menus;
using Katharsis.DocumentsGenerator.Modules.Letter.ViewModels;
using Katharsis.DocumentsGenerator.Modules.Letter.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;

namespace Katharsis.DocumentsGenerator.Modules.Letter
{
    public class LetterModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public LetterModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.LEFT_NAVIGATION, typeof(LettersMenu));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<LettersMenu, LettersMenuViewModel>();

            containerRegistry.RegisterForNavigation<TopNavigation, TopNavigationViewModel>();
            containerRegistry.RegisterForNavigation<LettersListView, LettersListViewModel>();
            containerRegistry.RegisterForNavigation<OfficialLetterFormView, OfficialLetterFormViewModel>();
        }
    }
}
