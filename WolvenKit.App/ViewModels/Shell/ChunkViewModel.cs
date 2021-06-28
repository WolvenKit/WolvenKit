using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using Catel.Data;
using DynamicData;
using ReactiveUI;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;

namespace WolvenKit.ViewModels.Shell
{
    public class ChunkPropertyViewModel : ObservableObject
    {
        #region Fields
        public IEditableVariable Property { get; }
        #endregion Fields

        #region Constructors

        

        public ChunkPropertyViewModel(IEditableVariable prop)
        {
            Property = prop;

            var disposable = Property.ChildrEditableVariables
                .AsObservableChangeSet()
                .Transform(GetViewModel)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _children)
                .Subscribe();
        }

        private static ChunkPropertyViewModel GetViewModel(IEditableVariable editableVariable) =>
            editableVariable switch
            {
                IREDBool redBool => new RedBoolViewModel(redBool),
                IREDString redString => new RedStringViewModel(redString),
                _ => new ChunkPropertyViewModel(editableVariable)
            };

        #endregion Constructors

        #region Properties
        public bool IsSelected { get; set; }
        public bool IsExpanded { get; set; }

        public string Name => Property.REDName;
        public string Type => Property.REDType;
        public string Value => Property.REDValue;

        private readonly ReadOnlyObservableCollection<ChunkPropertyViewModel> _children;
        public ReadOnlyObservableCollection<ChunkPropertyViewModel> Children => _children;


        public System.Windows.Media.Brush ForegroundColor => Property.IsSerialized
                    ? System.Windows.Media.Brushes.Green
            : System.Windows.Media.Brushes.Azure;


        #endregion Properties
    }

    // We can probably make this with generic types
    public class RedBoolViewModel : ChunkPropertyViewModel
    {
        public RedBoolViewModel(IREDBool prop) :base(prop) { }

        private IREDBool Prop => Property as IREDBool;

        public new bool Value
        {
            get => Prop.Value;
            set
            {
                if (Prop.Value != value)
                {
                    var oldValue = Prop.Value;
                    Prop.Value = value;
                    RaisePropertyChanged(() => Value, oldValue, value);
                }
            }
        }
    }

    public class RedStringViewModel : ChunkPropertyViewModel
    {
        public RedStringViewModel(IREDString prop) : base(prop) { }

        private IREDString Prop => Property as IREDString;

        public new string Value
        {
            get => Prop.Value;
            set
            {
                if (Prop.Value != value)
                {
                    var oldValue = Prop.Value;
                    Prop.Value = value;
                    RaisePropertyChanged(() => Value, oldValue, value);
                }
            }
        }
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

            var disposable = Data.ChildrEditableVariables
                .AsObservableChangeSet()
                .Transform(_ => new ChunkPropertyViewModel(_))
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _children)
                .Subscribe();
        }

        #endregion Constructors

        #region Properties

        public List<ChunkViewModel> Children => _export.VirtualChildrenChunks.Select(_ => new ChunkViewModel(_)).ToList();

        private readonly ReadOnlyObservableCollection<ChunkPropertyViewModel> _children;
        public ReadOnlyObservableCollection<ChunkPropertyViewModel> ChildrenProperties => _children;
        //public List<ChunkPropertyViewModel> ChildrenProperties =>
        //    Data.ChildrEditableVariables.Select(_ => new ChunkPropertyViewModel(_)).ToList();

        public IEditableVariable Data => _export.Data;

        public bool IsSelected { get; set; }
        public bool IsExpanded { get; set; }
        public string Name => _export.REDName;

        #endregion Properties
    }
}
