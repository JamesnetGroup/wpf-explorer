using System;
using System.IO;

namespace WpfExplorer.Support.Local.Helpers
{
    public class DirectoryManager
    {
        public string DownloadDirectory { get; init; }
        public string DocumentsDirectory { get; init; }
        public string PicturesDirectory { get; init; }

        public DirectoryManager()
        { 
            var userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            DownloadDirectory = Path.Combine(userPath, "Downloads");

            DocumentsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            PicturesDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

    }
}
