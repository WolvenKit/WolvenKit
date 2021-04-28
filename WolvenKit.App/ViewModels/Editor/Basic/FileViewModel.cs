using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using Catel.Data;
using DynamicData;
using DynamicData.Binding;
using DynamicData.Kernel;
using WolvenKit.Models;

namespace WolvenKit.ViewModels.Editor.Basic
{
    public class FileViewModel : ObservableObject, IEquatable<FileViewModel>
    {
        private FileModel Item { get; }

        public FileViewModel(FileModel model)
        {
            Item = model;

            this.ChildrenCache.Connect().Bind(out _children).Subscribe();

        }

        // Data

        public string Name => Item.Name;

        public string FullName => Item.FullName;

        public string Extension => Item.Extension;

        public bool IsDirectory => Item.IsDirectory;

        // Hierarchy

        public ulong Hash => Item.Hash;

        public ulong ParentHash => Item.ParentHash;

        private ReadOnlyObservableCollection<FileViewModel> _children;
        public ReadOnlyObservableCollection<FileViewModel> Children => _children;

        public SourceCache<FileViewModel, ulong> ChildrenCache { get; } = new(_ => _.Hash);

        // UI

        public bool IsExpanded { get; set; }
        public bool IsSelected { get; set; }

        //public string ComputedFullName => Parent == null ? Name : Path
        //    .Combine(Parent.ComputedFullName, Name)
        //    .Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);

        public string IconPath =>
            IsDirectory
                ? Children is { Count: > 0 } ? "FolderOpened" : "Folder"
                : "File";

        #region methods

        public void CollapseChildren(bool b)
        {
            throw new NotImplementedException();
        }

        public void ExpandChildren(bool b)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Equality Members

        public bool Equals(FileViewModel other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Hash == other.Hash;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((FileViewModel)obj);
        }

        public override int GetHashCode() => (int)Hash;

        public static bool operator ==(FileViewModel left, FileViewModel right) => Equals(left, right);

        public static bool operator !=(FileViewModel left, FileViewModel right) => !Equals(left, right);

        #endregion
    }

}
