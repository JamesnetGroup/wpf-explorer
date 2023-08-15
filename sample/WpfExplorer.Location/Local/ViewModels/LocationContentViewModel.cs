using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Mvvm;
using WpfExplorer.Support.Local.Helpers;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Location.Local.ViewModels
{
    public partial class LocationContentViewModel : ObservableBase
    {
        private readonly NavigatorService _navigatorService;

        [ObservableProperty]
        private FileInfoBase _current;

        public LocationContentViewModel(NavigatorService navigatorService) 
        {
            _navigatorService = navigatorService;
            _navigatorService.LocationChanged += _navigatorService_LocationChanged;
        }

        private void _navigatorService_LocationChanged(object? sender, Support.Local.Models.LocationChangedEventArgs e)
        {
            Current = e.Current;
        }

        [RelayCommand]
        private void Up()
        {
            _navigatorService.GoToParent();
        }

        [RelayCommand]
        private void Undo()
        {
            _navigatorService.GoBack();
        }

        [RelayCommand]
        private void Redo()
        {
            _navigatorService.GoForward();
        }
    }
}
