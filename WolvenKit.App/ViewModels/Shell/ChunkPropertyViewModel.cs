using System.Reactive;
using System.Windows.Input;
using System.Windows.Media;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.App.ViewModels.Shell
{
    public class ChunkPropertyViewModel : ReactiveObject
    {
        #region Constructors

        public ChunkPropertyViewModel(IRedType prop)
        {
            Property = prop;
            //IsSerialized = prop.IsSerialized;


            //_ = Property.ChildrEditableVariables
            //    .AsObservableChangeSet()
            //    .Transform(GetViewModel)
            //    .ObserveOn(RxApp.MainThreadScheduler)
            //    .Bind(out _children)
            //    .Subscribe();

            PreviewTextInputCommand = ReactiveCommand.Create(
                () =>
                {
                    //if (!Property.IsSerialized)
                    //{
                    //    Property.IsSerialized = true;
                    //    IsSerialized = true;
                    //    this.RaisePropertyChanged(nameof(IsSerialized));
                    //}
                });

            //this.WhenAnyValue(x => x.IsSerialized).Subscribe(b =>
            //{
            //    if (prop.IsSerialized != b)
            //    {
            //        prop.IsSerialized = b;
            //        IsSerialized = b;
            //        this.RaisePropertyChanged(nameof(IsSerialized));
            //    }
            //});

            //Property.PropertyChanged += OnPropertyChanged;
        }

        //private void OnPropertyChanged(object sender, PropertyChangedEventArgs e) =>
        //    IsSerialized = e.PropertyName switch
        //    {
        //        nameof(IRedType.IsSerialized) => ((IEditableVariable)sender).IsSerialized,
        //        _ => IsSerialized
        //    };

        #endregion Constructors

        public ICommand PreviewTextInputCommand { get; set; }

        #region Properties

        public IRedType Property { get; }


        [Reactive] public bool IsSelected { get; set; }
        [Reactive] public bool IsExpanded { get; set; }

        //public string Name => Property.REDName;
        //public string Type => Property.REDType;
        //public string Value => Property.REDValue;
        //[Reactive] public bool IsSerialized { get; set; }

        //private readonly ReadOnlyObservableCollection<ChunkPropertyViewModel> _children;
        //public ReadOnlyObservableCollection<ChunkPropertyViewModel> Children => _children;


        //public System.Windows.Media.Brush ForegroundColor => Property.IsSerialized
        //            ? System.Windows.Media.Brushes.Green
        //    : System.Windows.Media.Brushes.Azure;


        #endregion Properties

        private static ChunkPropertyViewModel GetViewModel(IRedType editableVariable) =>
            editableVariable switch
            {
                IRedPrimitive<bool> redBool => new RedBoolViewModel(redBool),
                IRedPrimitive<string> redString => new RedStringViewModel(redString),
                CColor redcolor => new RedColorViewModel(redcolor),
                _ => new ChunkPropertyViewModel(editableVariable)
            };
    }

    public class RedColorViewModel : ChunkPropertyViewModel
    {
        public RedColorViewModel(CColor prop) : base(prop)
        {
            DisplayColor = new Color() { A = prop.Alpha, R = prop.Red, G = prop.Green, B = prop.Blue };
            SelectedColorCommand =
                ReactiveCommand.Create<object>(
                    OnColorPicked);

        }

        [Reactive] public Color DisplayColor { get; set; }

        public ReactiveCommand<object, Unit> SelectedColorCommand { get; set; }

        private void OnColorPicked(object e)
        {
            dynamic d = e;
            var mediaColor = d.Brush.Color;
            DisplayColor = mediaColor;

            _ = System.Drawing.Color.FromArgb(mediaColor.A, mediaColor.R, mediaColor.G, mediaColor.B);
            throw new TodoException("Color conversion");
            //(Property as RED4.Types.CColor)?.SetValue(c);
        }
    }

    // We can probably make this with generic types
    public class RedBoolViewModel : ChunkPropertyViewModel
    {
        public RedBoolViewModel(IRedPrimitive<bool> prop) : base(prop) { }
    }

    public class RedStringViewModel : ChunkPropertyViewModel
    {
        public RedStringViewModel(IRedPrimitive<string> prop) : base(prop) { }
    }
}
