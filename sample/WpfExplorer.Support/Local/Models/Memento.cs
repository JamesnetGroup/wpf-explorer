namespace WpfExplorer.Support.Local.Models
{
    public class Memento
    {
        private readonly string _fullPath;

        public Memento(string fullpath)
        {
            _fullPath = fullpath;
        }

        public string GetSavedFullPath()
        {
            return _fullPath;
        }
    }
}
