using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;
using Catel.IoC;
using Orc.ProjectManagement;
using ReactiveUI;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.MVVM.Model.ProjectManagement.Project;

namespace WolvenKit.Models
{
    public class FileModel //: ObservableObject
    {

        public FileModel(string path)
        {
            if (Directory.Exists(path))
            {
                Wrapped = new DirectoryInfo(path);
            }
            else if (File.Exists(path))
            {
                Wrapped = new FileInfo(path);
            }
            else
            {
                throw new FileNotFoundException();
            }

            Init();
        } 

        public FileModel(FileSystemInfo wrapped)
        {
            Wrapped = wrapped;

            Init();
        }


        private void Init()
        {
            RelativeName = GetRelativeName(FullName);
            IsDirectory = Wrapped.IsDirectory();
            Parent = Wrapped.GetParent();
            Hash = FNV1A64HashAlgorithm.HashString(RelativeName);
            ParentHash = Parent != null
                ? FNV1A64HashAlgorithm.HashString( GetRelativeName(Parent.FullName))
                : 0;
        }

        #region properties

        private FileSystemInfo Wrapped { get; }

        public DirectoryInfo Parent { get; private set; }

        public string Name => Wrapped.Name;

        public string FullName => Wrapped.FullName;

        public string RelativeName { get; private set; }

        public bool IsDirectory { get; private set; }

        public string Extension => Wrapped.Extension;

        public ulong Hash { get; private set; }
        public ulong ParentHash { get; private set; }

        #endregion


        public override int GetHashCode() => (int)Hash;

        private DirectoryInfo GetParent() => IsDirectory ? (Wrapped as DirectoryInfo).Parent : (Wrapped as FileInfo).Directory;

        public static string GetRelativeName(string fullname)
        {
            var pm = ServiceLocator.Default.ResolveType<IProjectManager>();

            var filedir = (pm.ActiveProject as EditorProject).FileDirectory;
            var moddir = (pm.ActiveProject as EditorProject).ModDirectory;
            var dlcdir = (pm.ActiveProject as EditorProject).DlcDirectory;

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

            throw new System.NullReferenceException();
        }

        
    }
}
