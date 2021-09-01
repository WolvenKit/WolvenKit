using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using ReactiveUI;
using WolvenKit.RED4.CR2W.Archive;
using System;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common;
using ReactiveUI.Fody.Helpers;

namespace WolvenKit.ViewModels.Tools
{
    /// <summary>
    /// Wraps an IGameFile to display in a View
    /// </summary>
    public class RedFileViewModel : FileSystemViewModel, ISelectableViewModel
    {
        private readonly IGameFile _fileEntry;

        #region Constructors

        public RedFileViewModel(IGameFile fileEntry)
        {
            _fileEntry = fileEntry;
        }


        #endregion Constructors

        #region Properties

        [Browsable(false)] [Reactive] public bool IsChecked { get; set; }

        [Browsable(false)] public string Extension => _fileEntry.Extension.TrimStart('.');

        [Browsable(false)] public override string DisplayExtension => Extension;

        public override string FullName => _fileEntry.Name;

        public override string Name => Path.GetFileName(FullName);

        [Display(Name = "Hash")] public string DisplayHash => _fileEntry.Key.ToString();


        public string Size => FormatSize(_fileEntry.Size);

        [Display(Name = "Archive")] public string ArchiveName => _fileEntry.Archive.Name;

        #endregion Properties

        public string GetParentPath() => Path.GetDirectoryName(_fileEntry.Name);

        string FormatSize(uint size)
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
