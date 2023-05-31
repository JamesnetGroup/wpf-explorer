using Jamesnet.Wpf.Controls;
using System.Collections.ObjectModel;
using System.IO;

namespace WpfExplorer.Main.Local.Model
{
    public class RootModel : FileModel
    {
        public RootModel(int depth, string name, IconType icon, string fullPath, bool isExpanded, bool isSelected)
        {
            FullPath = fullPath;
            Depth = depth;
            Name = name;
            IconType = icon;
            IsExpanded = isExpanded;
            IsSelected = isSelected;
            Children = new ObservableCollection<FileModel>();
        }

        public RootModel(string target, IconType icon) : this(0, Path.GetFileName(target), icon, target, false, false)
        {

        }
    }
}
