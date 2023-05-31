using System.Windows;
using WpfExplorer.LayoutSupport.UI.Units;

namespace WpfExplorer.Main.UI.Views
{
    public class Finder : CustomWindow
    {
        static Finder()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Finder), new FrameworkPropertyMetadata(typeof(Finder)));
        }
    }
}
