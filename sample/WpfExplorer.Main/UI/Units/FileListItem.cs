using System.Windows;
using System.Windows.Controls;

namespace WpfExplorer.Main.UI.Units
{
    public class FileListItem : ListBoxItem
    {
        static FileListItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FileListItem), new FrameworkPropertyMetadata(typeof(FileListItem)));
        }
    }
}
