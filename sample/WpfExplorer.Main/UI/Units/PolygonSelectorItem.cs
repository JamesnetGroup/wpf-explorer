using System.Windows;
using System.Windows.Controls;

namespace WpfExplorer.Main.UI.Units
{
    public class PolygonSelectorItem : ListBoxItem
    {
        static PolygonSelectorItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PolygonSelectorItem), new FrameworkPropertyMetadata(typeof(PolygonSelectorItem)));
        }
    }
}
