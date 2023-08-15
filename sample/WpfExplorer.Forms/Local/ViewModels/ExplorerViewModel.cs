using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;

namespace WpfExplorer.Forms.Local.ViewModels
{
    public class ExplorerViewModel : ObservableBase, IViewLoadable
    {
        private readonly IContainerProvider _containerProvider;
        private readonly IRegionManager _regionManager;

        public ExplorerViewModel(IContainerProvider containerProvider, IRegionManager regionManager)
        {
            _containerProvider = containerProvider;
            _regionManager = regionManager;
        }

        public void OnLoaded(IViewable view)
        {
            ImportContent("MainContent", "MainRegion");
            ImportContent("LocationContent", "LocationRegion");
        }

        private void ImportContent(string name, string regionName)
        {
            IRegion region = _regionManager.Regions[regionName];
            IViewable content = _containerProvider.Resolve<IViewable>(name);

            if (!region.Views.Contains(content))
            {
                region.Add(content);
            }
            region.Activate(content);
        }
    }
}
