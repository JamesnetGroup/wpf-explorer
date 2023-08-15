using System.Windows;
using System.Windows.Controls;

namespace WpfExplorer.Main.UI.Units
{
    public class FolderTreeItem : TreeViewItem
    {
        public FolderTreeItem()
        {
            DefaultStyleKey = typeof(FolderTreeItem);   
        }
        static FolderTreeItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FolderTreeItem), new FrameworkPropertyMetadata(typeof(FolderTreeItem)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            
            return new FolderTreeItem();
        }
    }
}
