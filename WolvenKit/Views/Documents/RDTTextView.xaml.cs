using System.Reactive.Disposables;
using ReactiveUI;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for RDTTextureView.xaml
    /// </summary>
    public partial class RDTTextView : ReactiveUserControl<RDTTextViewModel>
    {
        public RDTTextView()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                if (DataContext is RDTTextViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                }

                this.Bind(ViewModel,
                       viewModel => viewModel.IsDirty,
                       view => view.textEditor.IsModified)
                   .DisposeWith(disposables);
                this.OneWayBind(ViewModel,
                    viewModel => viewModel.TextEditorOptions,
                    view => view.textEditor.Options);
                //this.OneWayBind(ViewModel,
                //        viewModel => viewModel.IsReadOnly,
                //        view => view.textEditor.IsReadOnly)
                //    .DisposeWith(disposables);
            });
        }
    }
}
