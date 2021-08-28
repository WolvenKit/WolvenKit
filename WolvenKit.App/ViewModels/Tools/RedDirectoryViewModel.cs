using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;

namespace WolvenKit.ViewModels.Tools
{
    /// <summary>
    /// Wraps a directory of RedFileViewModels to display in a View
    /// </summary>
    public class RedDirectoryViewModel : FileSystemViewModel, IFileSystemViewModel, ISelectableViewModel
    {
        private readonly RedFileSystemModel _model;

        #region Constructors

        public RedDirectoryViewModel(RedFileSystemModel model)
        {
            _model = model;
        }

        #endregion Constructors

        #region Properties

        [Browsable(false)] public List<RedFileSystemModel> Directories => _model.Directories;

        [Browsable(false)] public List<ulong> Files => _model.Files;   

        [Browsable(false)] [Reactive] public bool IsChecked { get; set; }

        public override string Name => _model.Name;

        [Browsable(false)] public string Extension => nameof(ECustomImageKeys.ClosedDirImageKey);

        [Browsable(false)] public override string DisplayExtension => "";

        public override string FullName => _model.FullName;

        #endregion Properties

        public override string ToString() => Name;

        public RedFileSystemModel GetModel() => _model;

    }
}
