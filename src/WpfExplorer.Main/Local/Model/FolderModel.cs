using Jamesnet.Wpf.Controls;
using System.IO;

namespace WpfExplorer.Main.Local.Model
{
    public class FolderModel : FileModel
    {
        public string FileName => Path.GetFileName(FullPath) == "" ? FullPath : Path.GetFileName(FullPath);

        public FolderModel(string fullPath, IconType icon)
        {
            FullPath = fullPath;
            IconType = icon;
        }
    }
}
