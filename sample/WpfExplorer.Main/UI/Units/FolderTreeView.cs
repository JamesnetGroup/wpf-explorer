using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Main.UI.Units
{
    public class FolderTreeView : TreeView
    {
        public static readonly DependencyProperty SelectionCommandProperty = DependencyProperty.Register("SelectionCommand", typeof(ICommand), typeof(FolderTreeView));

        static FolderTreeView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FolderTreeView), new FrameworkPropertyMetadata(typeof(FolderTreeView)));
        }

        public ICommand SelectionCommand
        { 
            get=> (ICommand)GetValue(SelectionCommandProperty);
            set => SetValue(SelectionCommandProperty, value);
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new FolderTreeItem();
        }

        public FolderTreeView()
        {
            SelectedItemChanged += TreeView_SelectedItemChanged;
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (SelectedItem is Folderinfo item)
            {
                SelectionCommand?.Execute(item);
            }
        }
    }
}
