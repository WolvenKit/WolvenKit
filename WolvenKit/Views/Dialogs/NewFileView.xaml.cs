using System.Reactive.Disposables;
using ReactiveUI;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for NewFileView.xaml
    /// </summary>
    public partial class NewFileView : ReactiveUserControl<NewFileViewModel>
    {
        public NewFileView()
        {
            InitializeComponent();


            this.WhenActivated(disposables =>
            {
                this.Bind(ViewModel,
                    vm => vm.Categories,
                    v => v.Categories.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                    vm => vm.SelectedCategory,
                    v => v.Categories.SelectedItem)
                    .DisposeWith(disposables);

                this.OneWayBind(ViewModel,
                    vm => vm.SelectedCategory.Files,
                    v => v.DataGrid.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                    vm => vm.SelectedFile,
                    v => v.DataGrid.SelectedItem)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                    vm => vm.FileName,
                    v => v.FileName.Text)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel, x => x.OkCommand, x => x.OkButton)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel, x => x.CancelCommand, x => x.CancelButton)
                    .DisposeWith(disposables);
            });

        }
    }
}
