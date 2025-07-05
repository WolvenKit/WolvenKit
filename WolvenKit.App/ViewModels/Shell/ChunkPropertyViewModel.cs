using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkPropertyViewModel : ObservableObject
{
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

       // PreviewTextInputCommand = ReactiveCommand.Create(
           // () =>
           // {
                //if (!Property.IsSerialized)
                //{
                //    Property.IsSerialized = true;
                //    IsSerialized = true;
                //    this.RaisePropertyChanged(nameof(IsSerialized));
                //}
           // });

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


    #region Properties

    public IRedType Property { get; }


    [ObservableProperty] private bool _isSelected;
    [ObservableProperty] private bool _isExpanded;

    //public string Name => Property.REDName;
    //public string Type => Property.REDType;
    //public string Value => Property.REDValue;
    //[ObservableProperty] private bool _isSerialized;

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
