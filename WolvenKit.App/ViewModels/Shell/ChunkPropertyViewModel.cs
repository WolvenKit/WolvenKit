using System;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using System.Windows.Input;
using DynamicData;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.ViewModels.Shell
{
    public class ChunkPropertyViewModel : ReactiveObject
    {
        #region Constructors

        public ChunkPropertyViewModel(IEditableVariable prop)
        {
            Property = prop;
            IsSerialized = prop.IsSerialized;

            _ = Property.ChildrEditableVariables
                .AsObservableChangeSet()
                .Transform(GetViewModel)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Bind(out _children)
                .Subscribe();

            PreviewTextInputCommand = ReactiveCommand.Create(
                () =>
                {
                    if (!Property.IsSerialized)
                    {
                        Property.IsSerialized = true;
                        this.RaisePropertyChanged(nameof(IsSerialized));
                    }
                });

            this.WhenAnyValue(x => x.IsSerialized).Subscribe(b =>
            {
                if (prop.IsSerialized != b)
                {
                    prop.IsSerialized = b;
                }
            });
        }

        private static ChunkPropertyViewModel GetViewModel(IEditableVariable editableVariable) =>
            editableVariable switch
            {
                IREDBool redBool => new RedBoolViewModel(redBool),
                IREDString redString => new RedStringViewModel(redString),
                _ => new ChunkPropertyViewModel(editableVariable)
            };

        #endregion Constructors

        public ICommand PreviewTextInputCommand { get; private set; }

        #region Properties

        public IEditableVariable Property { get; }

        public bool IsSelected { get; set; }
        public bool IsExpanded { get; set; }

        public string Name => Property.REDName;
        public string Type => Property.REDType;
        public string Value => Property.REDValue;
        [Reactive] public bool IsSerialized { get; set; }//=> Property.IsSerialized;

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
    }

    public class RedStringViewModel : ChunkPropertyViewModel
    {
        public RedStringViewModel(IREDString prop) : base(prop) { }
    }
}
