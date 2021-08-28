using ReactiveUI;
using WolvenKit.Common.Interfaces;

namespace WolvenKit.ViewModels.Tools
{
    public abstract class FileSystemViewModel : ReactiveObject, IFileSystemViewModel
    {
        public abstract string Name { get; }

        public abstract string FullName { get; }
        
        public abstract string DisplayExtension { get; }

        //public abstract ulong Key { get; }

        //public abstract ulong ParentKey { get; }
    }
}
