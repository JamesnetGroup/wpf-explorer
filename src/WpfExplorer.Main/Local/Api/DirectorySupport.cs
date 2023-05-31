using System;
using System.IO;

namespace WpfExplorer.Main.Local.Api
{
    internal class RootSupport
    {
        internal static string Downloads => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"Downloads");
        internal static string Documents => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        internal static string Pictures => Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        #region TryParent

        internal static bool TryParent(string path, out string parentPath)
        {
            try
            {
                DirectoryInfo info = Directory.GetParent(path);
                parentPath = info?.FullName;
                return info != null;
            }
            catch
            {
                parentPath = null;
                return false;
            }
        }
        #endregion

        internal static bool CheckAccess(string filename)
        {
            try
            {
                string[] d = Directory.GetDirectories(filename);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
