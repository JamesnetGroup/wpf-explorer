namespace WpfExplorer.Support.Local.Models
{
    public class LocationInfo : FileInfoBase
    {
        public int Zindex { get; set; }
        public string Color { get; set; }
        public bool IsRoot { get; set; }


        public LocationInfo(string name, string fullName)
        {
            Name = name;
            FullPath = fullName;
        }
    }
}
