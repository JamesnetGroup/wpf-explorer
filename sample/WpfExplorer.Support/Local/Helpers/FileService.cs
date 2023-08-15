using Jamesnet.Wpf.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using WpfExplorer.Support.Local.Converters;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Support.Local.Helpers
{
    public class FileService
    {
        private readonly ColorManager _colorManager;
        private readonly DirectoryManager _directoryManager;
        private readonly NavigatorService _navigatorService;

        public FileService(ColorManager colorManager, DirectoryManager directoryManager, NavigatorService navigatorService) 
        {
            _colorManager = colorManager;
            _directoryManager = directoryManager;
            _navigatorService = navigatorService;
        }

        public List<Folderinfo> GenerateRootNodes()
        {
            List<Folderinfo> roots = new()
            { 
                CreateFolderInfo(1, "Download", IconType.ArrowDownBox, _directoryManager.DownloadDirectory),
                CreateFolderInfo(1, "Documents", IconType.TextBox, _directoryManager.DocumentsDirectory),
                CreateFolderInfo(1, "Pictures", IconType.Image, _directoryManager.PicturesDirectory),
            };

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                var name = $"{drive.VolumeLabel} ({drive.RootDirectory.FullName.Replace("\\", "")})";
                roots.Add(CreateFolderInfo(1, name, IconType.MicrosoftWindows, drive.Name));
            }

            return roots;
        }


        private static Folderinfo CreateFolderInfo(int depth, string name, IconType iconType, string fullPath)
        {
            return new Folderinfo
            { 
                Depth = depth,
                Name = name,
                IconType = iconType,
                FullPath = fullPath,
                Children = new()
            };
        }

        public void RefreshSubdirectories(Folderinfo parent)
        {
            var newChildren = FetchSubdirectories(parent);

            var oldChildrenDict = parent.Children.ToDictionary(c => c.FullPath);
            var newChildrenDict = newChildren.ToDictionary(c => c.FullPath);

            var added = newChildren.Where(c=>!oldChildrenDict.ContainsKey(c.FullPath)).ToList();
            var removed = parent.Children.Where(c => !newChildrenDict.ContainsKey(c.FullPath)).ToList();

            parent.Children.AddRange(added);
            foreach (var child in removed)
            { 
                parent.Children.Remove(child);
            }
        }

        private static List<Folderinfo> FetchSubdirectories(Folderinfo parent)
        {
            var children = new List<Folderinfo>();
            try
            {
                var subDirs = Directory.GetDirectories(parent.FullPath);
                foreach (var dir in subDirs)
                {
                    children.Add(new Folderinfo {
                        Depth = parent.Depth + 1,
                        Name = Path.GetFileName(dir),
                        IconType = IconType.Folder,
                        FullPath = dir,
                        Children = new()
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return children;
        }

        public void TryRefreshFiles(ObservableCollection<Folderinfo> files, out bool isAccessDenied)
        {
            var path = _navigatorService.Current.FullPath;
            isAccessDenied = !Directory.Exists(path) || !IsAccessible(path);
            
            if (!isAccessDenied) 
            {
                files.Clear();
                files.AddRange(FetchFilesAndDirectories(path));
            }
        }

        private bool IsAccessible(string path)
        {
            try
            {
                Directory.GetDirectories(path);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private IEnumerable<Folderinfo> FetchFilesAndDirectories(string path)
        {
            return Directory.GetFileSystemEntries(path)
                .Select(entry => new Folderinfo
                {
                    Name = Path.GetFileName(entry),
                    IconType = Directory.Exists(entry) ? IconType.Folder : DetermineIconType(entry),
                    FullPath = entry,
                    Length = Directory.Exists(entry) ? 0 : new FileInfo(entry).Length,
                })
                .OrderBy(info => info.IconType == IconType.Folder ? 0 : 1)
                .ToList();
        }

        private IconType DetermineIconType(string file)
        {
            var ext = Path.GetExtension(file).ToUpper();

            return ext switch
            {
                ".JPG" or ".JPEG" or ".GIF" or ".PNG" => IconType.FileImage,
                ".PDF" => IconType.FilePdf,
                ".ZIP" => IconType.FileZip,
                ".EXE" => IconType.FileCheck,
                ".DOCX" => IconType.FileWord,
                _ => IconType.File
            };
        }

        public void RefreshLocations(ObservableCollection<LocationInfo> locations)
        { 
            List<LocationInfo> source = GenerateLocationInfo(_navigatorService.currentLocation.FullPath);
            locations.Clear();
            locations.AddRange(source);
        }


        public List<LocationInfo> GenerateLocationInfo(string path)
        {
            List<LocationInfo> locations = new();
            while(!string.IsNullOrEmpty(path))
            {
                string name = Path.GetFileName(path);
                name = name == "" ? path : name;
                locations.Insert(0, new LocationInfo(name, path));
                path = Path.GetDirectoryName(path);
            }

            int zindex = 1000;
            int cnt = 0;
            locations.ForEach(loc => loc.Color = _colorManager.PolygonColors[cnt++]);
            locations.First().IsRoot= true;
            locations.ForEach(loc => loc.Zindex = zindex--);

            return locations;
        }
    }
}
