using System.Windows;
using System.Windows.Controls;

namespace WpfExplorer.Support.UI.Units
{
    public class DarkScrollViewer : ScrollViewer
    {
        static DarkScrollViewer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DarkScrollViewer), new FrameworkPropertyMetadata(typeof(DarkScrollViewer)));
        }
    }
}
