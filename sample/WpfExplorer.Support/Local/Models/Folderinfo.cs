using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace WpfExplorer.Support.Local.Models
{
    public partial class Folderinfo : FileInfoBase
    {
        [ObservableProperty]
        private bool _isFolderExpanded;
        [ObservableProperty]
        private bool _isFolderSelected;

        public ObservableCollection<Folderinfo> Children { get; set; }
    }
}
