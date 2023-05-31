using System.Windows;
using WpfExplorer.LayoutSupport.UI.Units;
using WpfExplorer.Main.Local.ViewModel;

namespace WpfExplorer.Main.UI.Views
{
    public class Finder : Explorer
    {
        static Finder()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Finder), new FrameworkPropertyMetadata(typeof(Finder)));
        }

        public Finder()
        {
            DataContext = new FinderViewModel();
        }
    }
}
