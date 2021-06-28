using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
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

        private readonly string _extension = ".default";
        public const string s_moddir = "wkitmoddir";
        public const string s_rawdir = "wkitrawdir";

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
                _extension = ECustomImageKeys.OpenDirImageKey.ToString();
            }
            else if (File.Exists(path))
            {
                IsDirectory = false;
                var fi = new FileInfo(path);
                parentfullname = fi.Directory.FullName;
                Name = fi.Name;
                _extension = fi.Extension;
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

        public string Extension => GetExtension();

        [Display(Name = "Hash")] public string HashStr => Hash.ToString();


        [Browsable(false)] public ulong Hash { get; }

        [Browsable(false)] public string RelativeName { get; }

        
        [Browsable(false)] public bool IsDirectory { get; }

        [Browsable(false)] public ulong ParentHash { get; }

        [Browsable(false)] public bool IsExpanded { get; set; }


        [Browsable(false)] public bool IsImportable => !IsDirectory
                                                       && !string.IsNullOrEmpty(GetExtension())
                                                       && Enum.GetNames(typeof(ERawFileFormat)).Contains(GetExtension());

        [Browsable(false)] public bool IsExportable => !IsDirectory
                                                       && !string.IsNullOrEmpty(GetExtension())
                                                       && Enum.GetNames(typeof(ECookedFileFormat)).Contains(GetExtension());

        #endregion

        public string GetExtension() => _extension.TrimStart('.');

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
            var rawDirectory = project.RawDirectory;

            if (fullname.Equals(filedir, StringComparison.Ordinal))
            {
                return "";
            }
            // hack so that we get proper hashes
            if (fullname.Equals(moddir, StringComparison.Ordinal))
            {
                return s_moddir;
            }
            if (fullname.Equals(rawDirectory, StringComparison.Ordinal))
            {
                return s_rawdir;
            }

            if (fullname.StartsWith(moddir, StringComparison.Ordinal))
            {
                return fullname[(moddir.Length + 1)..];
            }
            if (fullname.StartsWith(rawDirectory, StringComparison.Ordinal))
            {
                var rel = fullname[(filedir.Length + 1)..];
                return rel;
            }

            if (fullname.StartsWith(filedir, StringComparison.Ordinal))
            {
                return fullname[(filedir.Length + 1)..];
            }

            throw new System.NullReferenceException("fuzzy exception");
        }


    }
}
