namespace WpfExplorer.Support.Local.Models
{
    public class LocationInfo : FileInfoBase
    {
        public int Zindex { get; set; }
        public string Color { get; set; }
        public bool IsRoot { get; set; }
        public bool IsLast { get; set; }

        public LocationInfo(string name, string fullPath)
        {
            Name = name;
            FullPath = fullPath;
        }
    }
}
