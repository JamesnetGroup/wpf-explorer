using Jamesnet.Wpf.Global.Location;
using WpfExplorer.Forms.Local.ViewModels;
using WpfExplorer.Forms.UI.Views;
using WpfExplorer.Location.Local.ViewModels;
using WpfExplorer.Location.UI.Views;
using WpfExplorer.Main.Local.ViewModels;
using WpfExplorer.Main.UI.Views;

namespace WpfExplorer.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<LocationContent, LocationContentViewModel>();
            items.Register<MainContent, MainContentViewModel>();
            items.Register<ExplorerWindow, ExplorerViewModel>();
        }
    }
}
