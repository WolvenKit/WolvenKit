using System;
using System.IO;
using Catel.IoC;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Functionality.Services;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using ObservableObject = Catel.Data.ObservableObject;

namespace WolvenKit.Models
{
    public class FileModel : ObservableObject
    {

        public FileModel(string path)
        {
            FullName = path;
            var parentfullname = "";

            if (Directory.Exists(path))
            {
                IsDirectory = true;
                var di = new DirectoryInfo(path);
                parentfullname = di.Parent.FullName;
                Name = di.Name;
                Extension = ECustomImageKeys.OpenDirImageKey.ToString();
            }
            else if (File.Exists(path))
            {
                IsDirectory = false;
                var fi = new FileInfo(path);
                parentfullname = fi.Directory.FullName;
                Name = fi.Name;
                Extension = fi.Extension;
            }
            else
            {
                throw new FileNotFoundException();
            }

            RelativeName = GetRelativeName(FullName);
            Hash = FNV1A64HashAlgorithm.HashString(RelativeName);
            ParentHash = !string.IsNullOrEmpty(GetRelativeName(parentfullname))
                ? FNV1A64HashAlgorithm.HashString(GetRelativeName(parentfullname))
                : 0;
        }

        #region properties

        public string FullName { get; }

        public string Name { get; }

        public string RelativeName { get; }

        public string Extension { get; } = ".default";

        public bool IsDirectory { get; }

        public ulong Hash { get; }

        public ulong ParentHash { get; }


        public bool IsExpanded { get; set; }


        #endregion


        public override int GetHashCode() => (int)Hash;

        public static string GetRelativeName(string fullname, EditorProject proj = null)
        {
            var pm = ServiceLocator.Default.ResolveType<IProjectManager>();
            var project = proj;
            if (proj == null)
            {
                project = pm.ActiveProject as EditorProject;
                if (project == null)
                {
                    throw new NotImplementedException();
                }
            }

            var filedir = project.FileDirectory;
            var moddir = project.ModDirectory;
            var dlcdir = project.DlcDirectory;

            if (fullname.Equals(filedir, StringComparison.Ordinal))
            {
                return "";
            }
            // hack so that we get proper hashes
            if (fullname.Equals(moddir, StringComparison.Ordinal))
            {
                return "wkitmoddir";
            }
            if (fullname.Equals(dlcdir, StringComparison.Ordinal))
            {
                return "wkitdlcdir";
            }

            if (fullname.StartsWith(moddir, StringComparison.Ordinal))
            {
                return fullname[(moddir.Length + 1)..];
            }
            if (fullname.StartsWith(dlcdir, StringComparison.Ordinal))
            {
                return fullname[(dlcdir.Length + 1)..];
            }

            if (fullname.StartsWith(filedir, StringComparison.Ordinal))
            {
                return fullname[(filedir.Length + 1)..];
            }

            throw new System.NullReferenceException("fuzzy exception");
        }


    }
}
