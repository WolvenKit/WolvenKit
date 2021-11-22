using System.ComponentModel.DataAnnotations;

namespace WolvenKit.Common.Interfaces
{
    public interface IFileSystemViewModel
    {
        public string Name { get; }

        [Display(Name = "Relative Path")] public string FullName { get; }

        public string DisplayExtension { get; }

        //public ulong Key { get; }

        //public ulong ParentKey {  get; }
    }
}
