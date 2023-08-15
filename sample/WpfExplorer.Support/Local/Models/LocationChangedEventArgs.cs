namespace WpfExplorer.Support.Local.Models
{
    public class LocationChangedEventArgs
    {
        public FileInfoBase Current { get; init; }

        public LocationChangedEventArgs(FileInfoBase current) 
        {
            Current = current;
        }
    }
}
