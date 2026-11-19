using Jamesnet.Wpf.Controls;
using Prism.Ioc;
using Prism.Modularity;
using WpfExplorer.Main.UI.Views;
using WpfExplorer.Location.UI.Views;


namespace WpfExplorer.Properties
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }


        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, MainContent>("MainContent");
            containerRegistry.RegisterSingleton<IViewable, LocationContent>("LocationContent");
        }
    }
}
