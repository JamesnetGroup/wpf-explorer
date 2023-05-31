using Jamesnet.Wpf.Controls;
using System.IO;

namespace WpfExplorer.Main.Local.Api
{
    internal sealed record RootIcon
    {
        internal static IconType MyPC => IconType.DesktopClassic;
        internal static IconType Folder => IconType.Folder;
        internal static IconType Download => IconType.ArrowDownBox;
        internal static IconType Document => IconType.TextBox;
        internal static IconType Pictures => IconType.Image;

        #region Parse

        internal static IconType Parse(string file)
        {
            IconType ext = IconType.File;
            switch (Path.GetExtension(file).ToUpper())
            {
                case ".JPG":
                case ".JPEG":
                case ".GIF":
                case ".BMP":
                case ".PNG": ext = IconType.FileImage; break;
                case ".PDF": ext = IconType.FilePdf; break;
                case ".ZIP": ext = IconType.FileZip; break;
                case ".EXE": ext = IconType.FileCheck; break;
                case ".DOCX":
                case ".DOC": ext = IconType.FileWord; break;
            }
            return ext;
        }
        #endregion
    }
}
