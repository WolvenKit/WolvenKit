using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using WolvenKit.Common;
using WolvenKit.Common.Model;

namespace WolvenKit.ViewModels.Tools
{
    /// <summary>
    /// Wraps a directory of RedFileViewModels to display in a View
    /// </summary>
    public class RedDirectoryViewModel : FileSystemViewModel
    {
        private readonly RedFileSystemModel _model;

        #region Constructors

        public RedDirectoryViewModel(RedFileSystemModel model)
        {
            _model = model;
        }

        #endregion Constructors

        #region Properties

        [Browsable(false)] public List<RedFileSystemModel> Directories => _model.Directories.Values.ToList();

        [Browsable(false)] public List<ulong> Files => _model.Files;

        public override string Size => "";

        public override string Name => _model.Name;

        [Browsable(false)] public string Extension => nameof(ECustomImageKeys.ClosedDirImageKey);

        [Browsable(false)] public override string DisplayExtension => "";

        public override string FullName => _model.FullName;

        #endregion Properties

        public override string ToString() => Name;

        public RedFileSystemModel GetModel() => _model;

    }
}
