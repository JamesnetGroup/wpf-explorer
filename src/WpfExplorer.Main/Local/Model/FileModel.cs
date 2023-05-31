using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Controls;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WpfExplorer.Main.Local.Model
{
    public class FileModel : ObservableObject
    {
        private bool _isSelected;
        private bool _isDenied;
        private bool _isExpanded;

        public string Name { get; set; }
        public string FullPath { get; set; }
        public int Depth { get; set; }
        public long Length { get; set; }
        public IconType IconType { get; protected set; }
        public ObservableCollection<FileModel> Children { get; set; } = new();

        public bool IsExpanded
        {
            get => _isExpanded;
            set { _isExpanded = value; OnPropertyChanged(); }
        }

        public bool IsSelected
        {
            get => _isSelected;
            set { _isSelected = value; OnPropertyChanged(); }
        }

        public bool IsDenied
        {
            get => _isDenied;
            set { _isDenied = value; OnPropertyChanged(); }
        }

        internal void AddRange(List<FileModel> rootModels)
        {
            Children.AddRange(rootModels);
        }
    }
}
