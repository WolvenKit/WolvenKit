using System.ComponentModel.DataAnnotations;

namespace WolvenKit.Common.Interfaces
{
    public interface IFileSystemViewModel
    {
        public string Name { get; }

        [Display(Name = "Relative Path")] public string FullName { get; }

        public string DisplayExtension { get; }

        public uint Size { get; }

        public string SizeString { get; }
        bool IsChecked { get; set; }

        //public ulong Key { get; }

        //public ulong ParentKey {  get; }
    }
}
