using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using WpfExplorer.Main.Local.Enum;
using WpfExplorer.Main.Local.Model;
using WpfExplorer.Main.Local.Work;

namespace WpfExplorer.Main.Local.ViewModel
{
    public class FinderViewModel : ObservableObject
    {
        #region Variables 

        private ObservableCollection<FileModel> _roots;
        private List<RootModel> _currentItems;
        private FileModel _currentDir;

        private readonly LocationWork LocWorker;
        #endregion

        #region ICommands

        public ICommand RecordClickCommand { get; }
        public ICommand RootClickCommand { get; }
        public ICommand SortedClickCommand { get; }
        public ICommand FolderClickCommand { get; }
        public ICommand UndoCommand { get; }
        public ICommand RedoCommand { get; }
        public ICommand GoUpCommand { get; }
        #endregion

        #region Roots 

        public ObservableCollection<FileModel> Roots
        {
            get => _roots;
            set { _roots = value; OnPropertyChanged(); }
        }
        #endregion

        #region Records

        public ObservableCollection<FileModel> Records { get; }
        public RelayCommand<FileModel> TreeClickCommand { get; }

        public FileModel Record
        {
            get => _currentDir;
            set { _currentDir = value; OnPropertyChanged(); }
        }
        #endregion

        #region MachineName

        public string MachineName => Environment.MachineName.ToString();
        #endregion

        #region CurrentItems

        public List<RootModel> CurrentItems
        {
            get => _currentItems;
            set { _currentItems = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public FinderViewModel()
        {
            LocWorker = new(this);
            LocWorker.Refresh = Refresh;
            Roots = new(LocWorker.GetNodeList());
            CurrentItems = new();
            Records = new();

            TreeClickCommand = new RelayCommand<FileModel>((p) => LocWorker.Select(p, MoveType.TreeSelect));
            RecordClickCommand = new RelayCommand<FileModel>((p) => LocWorker.Record(p, MoveType.Record));
            FolderClickCommand = new RelayCommand<FileModel>((p) => LocWorker.Select(p, MoveType.File));
            SortedClickCommand = new RelayCommand<FileModel>((p) => LocWorker.Select(p, MoveType.File));

            GoUpCommand = new RelayCommand<FileModel>((p) => LocWorker.GoUpSelect(MoveType.GoUp), (p) => LocWorker.IsUsedGoUp);
            UndoCommand = new RelayCommand<FileModel>((p) => LocWorker.UndoSelect(MoveType.Undo), (p) => LocWorker.IsUsedUndo);
            RedoCommand = new RelayCommand<FileModel>((p) => LocWorker.RedoSelect(MoveType.Redo), (p) => LocWorker.IsUsedRedo);

            LocWorker.Select(Roots.FirstOrDefault(), MoveType.File);
        }
        #endregion

        // Callback..♥

        #region Refresh

        private void Refresh(FileModel obj, MoveType type)
        {
            LocWorker.GetContent();
            LocWorker.SetNodeFocus(type);
        }
        #endregion
    }
}

