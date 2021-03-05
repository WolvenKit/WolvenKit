using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using HandyControl.Controls;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;
using WolvenKit.MVVM.Views.PropertyGridEditors;

namespace WolvenKit.MVVM.ViewModels.Shell.Editor
{
    public class ChunkPropertyViewModel
    {
        #region Fields

        private readonly IEditableVariable _property;

        #endregion Fields

        #region Constructors

        public ChunkPropertyViewModel(IEditableVariable prop)
        {
            _property = prop;

            Name = prop.REDName;
            Type = prop.REDType;
            Value = prop.REDValue;
        }

        #endregion Constructors

        #region Properties

        public List<ChunkPropertyViewModel> Children => _property.ChildrEditableVariables.Select(_ => new ChunkPropertyViewModel(_)).ToList();

        public System.Windows.Media.Brush ForegroundColor => _property.IsSerialized
                    ? System.Windows.Media.Brushes.Green
            : System.Windows.Media.Brushes.Azure;

        public string Name { get; }
        public string Type { get; }
        public string Value { get; set; }

        #endregion Properties
    }

    public class ChunkViewModel : ISelectableTreeViewItemModel
    {
        #region Fields

        private readonly ICR2WExport _export;

        #endregion Fields

        #region Constructors

        public ChunkViewModel(ICR2WExport export)
        {
            _export = export;
        }

        #endregion Constructors

        #region Properties

        public List<ChunkViewModel> Children => _export.VirtualChildrenChunks.Select(_ => new ChunkViewModel(_)).ToList();

        
        public List<ChunkPropertyViewModel> ChildrenProperties =>
            Data.ChildrEditableVariables.Select(_ => new ChunkPropertyViewModel(_)).ToList();

        public IEditableVariable Data => _export.data;

        public bool IsSelected { get; set; }
        public string Name => _export.REDName;

        public bool IsSelected { get; set; }

        #endregion Properties


    }
}
