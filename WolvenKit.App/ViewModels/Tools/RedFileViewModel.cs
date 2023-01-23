using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.ViewModels.Tools
{
    /// <summary>
    /// Wraps an IGameFile to display in a View
    /// </summary>
    public class RedFileViewModel : FileSystemViewModel
    {
        private readonly IGameFile _fileEntry;

        #region Constructors

        public RedFileViewModel(IGameFile fileEntry)
        {
            _fileEntry = fileEntry;

            ArchiveName = _fileEntry.GetArchive().Name;
            if (!string.IsNullOrEmpty(_fileEntry.GetArchive().ArchiveRelativePath))
            {
                ArchiveName = _fileEntry.GetArchive().ArchiveRelativePath;
            }
        }


        #endregion Constructors

        #region Properties

        [Browsable(false)] public string Extension => _fileEntry.Extension.TrimStart('.');

        [Browsable(false)] public override string DisplayExtension => Extension;

        public override string FullName => _fileEntry.Name;

        public override string Name => Path.GetFileName(FullName);

        [Display(Name = "Hash")] public string DisplayHash => _fileEntry.Key.ToString();

        public override uint Size => _fileEntry.Size;

        public override string SizeString => FormatSize(_fileEntry.Size);

        [Display(Name = "Archive")] public string ArchiveName { get; }

        #endregion Properties

        public string GetParentPath() => Path.GetDirectoryName(_fileEntry.Name).NotNull();

        private string FormatSize(uint size)
        {
            string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };

            var counter = 0;
            var number = (decimal)size;
            while (Math.Round(number / 1024) >= 1)
            {
                number = number / 1024;
                counter++;
            }
            return $"{number:n1} {suffixes[counter]}";
        }

        public IGameFile GetGameFile() => _fileEntry;

    }
}
