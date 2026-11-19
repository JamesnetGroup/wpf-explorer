using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfExplorer.Support.Local.Helpers;
using WpfExplorer.Support.Local.Models;


namespace WpfExplorer.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableBase, IViewLoadable
    {
        private readonly FileService _fileService;
        private readonly NavigatorService _navigatorService;


        public List<FolderInfo> Roots { get; init; }
        public ObservableCollection<FolderInfo> Files { get; init; }
        public ObservableCollection<LocationInfo> Locations { get; init; }


        public MainContentViewModel(FileService fileService, NavigatorService navigatorService)
        {
            _fileService = fileService;
            _navigatorService = navigatorService;
            _navigatorService.LocationChanged += _navigatorService_LocationChanged;


            Roots = _fileService.GenerateRootNodes();
            Files = new();
            Locations = new();
        }


        private void _navigatorService_LocationChanged(object? sender, LocationChangedEventArgs e)
        {
            _fileService.TryRefreshFiles(Files, out bool isDenied);
            e.Current.IsDenied = isDenied;
            if (isDenied) Files.Clear();
            _fileService.RefreshLocations(Locations);
        }


        [RelayCommand]
        private void FolderChanged(FolderInfo folderInfo)
        {
            _fileService.RefreshSubdirectories(folderInfo);
            _navigatorService.ChangeLocation(folderInfo);
        }


        [RelayCommand]
        private void GoBack()
        {
            _navigatorService.GoBack();
        }


        [RelayCommand]
        private void GoForward()
        {
            _navigatorService.GoForward();
        }


        [RelayCommand]
        private void GoToParent()
        {
            _navigatorService.GoToParent();
        }


        public void OnLoaded(IViewable view)
        {
            if (Roots.Count == 0) return;


            FolderInfo initialRoot = Roots[0];
            initialRoot.IsFolderSelected = true;
            _navigatorService.ChangeLocation(initialRoot);
        }
    }
}
