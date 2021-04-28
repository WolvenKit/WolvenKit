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
    //https://dynamic-data.org/2015/07/07/reactive-tree-using-dynamic-data/
    public class FileViewModel : ObservableObject, IEquatable<FileViewModel>
    {
        public FileViewModel(Node<FileModel, ulong> node, FileViewModel parent = null)
        {
            Hash = node.Key;
            Name = node.Item.Name;
            Depth = node.Depth;
            ParentHash = node.Item.ParentHash;
            Parent = parent;

            FullName = node.Item.FullName;
            IsDirectory = node.Item.IsDirectory;
            Extension = node.Item.Extension;

            var childrenLoader = new Lazy<IDisposable>(() => node.Children.Connect()
                .Transform(e => new FileViewModel(e,  this))
                .Bind(out _children)
                .DisposeMany()
                .Subscribe());

            var shouldExpand = node.IsRoot
                ? Observable.Return(true)
                : Parent.Value.WhenValueChanged(This => This.IsExpanded);


            var expander = shouldExpand
                .Where(isExpanded => isExpanded)
                .Take(1)
                .Subscribe(_ =>
                {
                    var x = childrenLoader.Value;
                });
        }

        


        // Data

        public string Name { get; }

        public string FullName { get; }

        public bool IsDirectory { get; }

        public string Extension { get; }

        // Hierarchy

        public ulong Hash { get; }

        public int Depth { get; }

        public ulong ParentHash { get; }

        public Optional<FileViewModel> Parent { get; }

        private ReadOnlyObservableCollection<FileViewModel> _children;

        public ReadOnlyObservableCollection<FileViewModel> Children => _children;

        // UI

        public bool IsExpanded { get; set; }

        


        //public string ComputedFullName => Parent == null ? Name : Path
        //    .Combine(Parent.ComputedFullName, Name)
        //    .Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);

        public string IconPath =>
            IsDirectory
                ? Children is {Count: > 0} ? "FolderOpened" : "Folder"
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
