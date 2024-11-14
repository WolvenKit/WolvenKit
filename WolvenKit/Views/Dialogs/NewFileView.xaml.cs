using System.ComponentModel;
using System.Reactive.Disposables;
using ReactiveUI;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Common.Model;

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

                // Subscribe to the PropertyChanged event of the ViewModel
                ViewModel.PropertyChanged += ViewModel_PropertyChanged;
                disposables.Add(Disposable.Create(() => ViewModel.PropertyChanged -= ViewModel_PropertyChanged));

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

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // If SelectedCategory has only one item, let's select it
            if (e.PropertyName != nameof(ViewModel.SelectedCategory)
                || ViewModel?.SelectedCategory is not FileCategoryModel category
                || category.Files is null
                || category.Files.Count != 1)
            {
                return;
            }

            // Set the SelectedFile to the single item in the DataGrid
            ViewModel.SelectedFile = category.Files[0];
        }
    }
}
