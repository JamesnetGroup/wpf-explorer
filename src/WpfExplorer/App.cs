using Jamesnet.Wpf.Controls;
using System.Windows;
using WpfExplorer.Main.UI.Views;

namespace WpfExplorer
{
    public class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new Finder();
        }
    }
}
