using System;
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

        private void SearchBar_OnTextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) => ApplySearch();

        // another category: its files are searched with the same text
        private void DataGrid_OnItemsSourceChanged(object sender, Syncfusion.UI.Xaml.Grid.GridItemsSourceChangedEventArgs e) =>
            ApplySearch();

        /// <summary>Shows the files whose name, extension or description holds the search text.</summary>
        private void ApplySearch()
        {
            if (DataGrid.View is not { } view)
            {
                return;
            }

            var text = SearchBar.Text?.Trim() ?? "";
            view.Filter = text.Length == 0
                ? null
                : item => item is AddFileModel file &&
                          (Holds(file.Name, text) || Holds(file.Extension, text) || Holds(file.Description, text));
            view.RefreshFilter();
        }

        private static bool Holds(string value, string text) =>
            value?.Contains(text, StringComparison.OrdinalIgnoreCase) == true;
    }
}
