using System.ComponentModel;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Interfaces;

namespace WolvenKit.App.ViewModels.Tools
{
    public abstract class FileSystemViewModel : ReactiveObject, IFileSystemViewModel, ISelectableViewModel
    {
        public abstract string Name { get; }

        public abstract string FullName { get; }

        public abstract string DisplayExtension { get; }

        public abstract uint Size { get; }

        public abstract string SizeString { get; }

        //public abstract ulong Key { get; }

        //public abstract ulong ParentKey { get; }

        [Browsable(false)][Reactive] public bool IsChecked { get; set; }
    }
}
