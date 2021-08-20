using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using DynamicData;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;

namespace WolvenKit.ViewModels.Shell
{
    public class ChunkPropertyViewModel : ReactiveObject, IEditableObject
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
        public void BeginEdit()
        {
            
        }

        public void CancelEdit()
        {
            
        }

        public void EndEdit()
        {
            
        }

        #endregion Constructors

        #region Properties
        public bool IsSelected { get; set; }
        public bool IsExpanded { get; set; }

        public string Name => Property.REDName;
        public string Type => Property.REDType;
        public string Value => Property.REDValue;
        public bool IsSerialized => Property.IsSerialized;

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

        [Reactive] public new bool Value { get; set; }
    }

    public class RedStringViewModel : ChunkPropertyViewModel
    {
        public RedStringViewModel(IREDString prop) : base(prop) { }

        private IREDString Prop => Property as IREDString;

        [Reactive] public new string Value { get; set; }
    }
}
