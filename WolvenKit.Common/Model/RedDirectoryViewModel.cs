using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading;
using ReactiveUI;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;

namespace WolvenKit.Common
{
    /// <summary>
    /// Wraps a directory of RedFileViewModels to display in a View
    /// </summary>
    public class RedDirectoryViewModel : FileSystemViewModel, IFileSystemViewModel, ISelectableViewModel
    {
        private readonly IHashService _hashService;
        //private readonly IFileSystemViewModel _parent;

        #region Constructors

        public RedDirectoryViewModel(string fullname, RedDirectoryViewModel parent, IHashService hashService)
        {
            _hashService = hashService;
            //_parent = parent;

            Key = FNV1A64HashAlgorithm.HashString(fullname);

            if (!_hashService.Contains(Key))
            {
                _hashService.AddCustom(fullname);
            }

            ParentKey = parent != null ? parent.Key : 0;
        }

        #endregion Constructors

        #region Properties

        public ObservableCollection<RedDirectoryViewModel> Directories { get; set; } = new();

        public ObservableCollection<RedFileViewModel> Files { get; } = new();


        [Browsable(false)] public bool IsChecked { get; set; }

        [Browsable(false)] public override ulong Key { get; }

        [Browsable(false)] public override ulong ParentKey { get; }


        [Browsable(false)] public string Extension => nameof(ECustomImageKeys.ClosedDirImageKey);

        [Browsable(false)] public override string DisplayExtension => "";

        public override string FullName => _hashService.Get(Key);

        public override string Name => Path.GetFileName(FullName);

        [Display(Name = "Hash")] public string DisplayHash => Key.ToString();

        #endregion Properties

        public override string ToString() => Name;

    }
}
