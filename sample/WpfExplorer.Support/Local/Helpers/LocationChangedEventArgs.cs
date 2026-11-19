using System;
using WpfExplorer.Support.Local.Models;


namespace WpfExplorer.Support.Local.Helpers
{
    public class LocationChangedEventArgs : EventArgs
    {
        public FileInfoBase Current { get; }


        public LocationChangedEventArgs(FileInfoBase current)
        {
            Current = current;
        }
    }
}
