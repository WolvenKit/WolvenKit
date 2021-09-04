using System;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows.Input;
using System.Windows.Media;
using DynamicData;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Syncfusion.Windows.Tools.Controls;
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
                        IsSerialized = true;
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

        #endregion Constructors

        public ICommand PreviewTextInputCommand { get; set; }

        #region Properties

        public IEditableVariable Property { get; }


        [Reactive] public bool IsSelected { get; set; }
        [Reactive] public bool IsExpanded { get; set; }

        public string Name => Property.REDName;
        public string Type => Property.REDType;
        public string Value => Property.REDValue;
        [Reactive] public bool IsSerialized { get; private set; }

        private readonly ReadOnlyObservableCollection<ChunkPropertyViewModel> _children;
        public ReadOnlyObservableCollection<ChunkPropertyViewModel> Children => _children;


        //public System.Windows.Media.Brush ForegroundColor => Property.IsSerialized
        //            ? System.Windows.Media.Brushes.Green
        //    : System.Windows.Media.Brushes.Azure;


        #endregion Properties

        private static ChunkPropertyViewModel GetViewModel(IEditableVariable editableVariable) =>
            editableVariable switch
            {
                IREDBool redBool => new RedBoolViewModel(redBool),
                IREDString redString => new RedStringViewModel(redString),
                IREDColor redcolor => new RedColorViewModel(redcolor),
                _ => new ChunkPropertyViewModel(editableVariable)
            };
    }

    public class RedColorViewModel : ChunkPropertyViewModel
    {
        public RedColorViewModel(IREDColor prop) : base(prop)
        {
            DisplayColor = new Color() { A = prop.Value.A, R = prop.Value.R, G = prop.Value.G, B = prop.Value.B };
            SelectedColorCommand =
                ReactiveCommand.Create<ColorSelectedCommandArgs>(
                    OnColorPicked);

        }

        [Reactive] public Color DisplayColor { get; set; }

        public ReactiveCommand<ColorSelectedCommandArgs, Unit> SelectedColorCommand { get; set; } 

        private void OnColorPicked(ColorSelectedCommandArgs e)
        {
            var mediaColor = e.Brush.Color;
            DisplayColor = mediaColor;
            var c = System.Drawing.Color.FromArgb(mediaColor.A, mediaColor.R, mediaColor.G, mediaColor.B);
            (Property as IREDColor)?.SetValue(c);
        }
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
