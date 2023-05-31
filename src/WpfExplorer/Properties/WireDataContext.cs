using Jamesnet.Wpf.Global.Location;
using WpfExplorer.Main.Local.ViewModel;
using WpfExplorer.Main.UI.Views;

namespace WpfExplorer.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<Finder, FinderViewModel>();
        }
    }
}
