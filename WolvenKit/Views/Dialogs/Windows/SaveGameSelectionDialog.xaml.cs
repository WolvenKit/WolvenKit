using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.Grid;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Helpers;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs.Windows
{
    /// <summary>
    /// Interaction logic for SaveGameSelectionDialog.xaml
    /// </summary>
    public partial class SaveGameSelectionDialog : IViewFor<SaveGameSelectionDialogModel>
    {
        public SaveGameSelectionDialog()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<SaveGameSelectionDialogModel>()!;
            DataContext = ViewModel;
            SaveDataGrid.FilterRowCellRenderers.Add("TextBoxExt", new GridFilterRowTextBoxRendererExt());
            SaveDataGrid.QueryRowHeight += DataGrid_QueryRowHeight;

            this.WhenActivated(disposables =>
            {
                SaveDataGrid.ClearFilters();
            });
        }

        public SaveGameSelectionDialog(string currentSaveName) : this()
        {
            ViewModel?.SetSelectedSave(currentSaveName);

        }

        private void DataGrid_QueryRowHeight(object sender, QueryRowHeightEventArgs e)
        {
            if (e.RowIndex < 2)
            {
                return;
            }

            e.Height = 70;
            e.Handled = true;
        }

        public SaveGameSelectionDialogModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (SaveGameSelectionDialogModel)value; }

        public bool? ShowDialog(Window owner)
        {
            Owner = owner;
            return ShowDialog();
        }

        private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key is not (Key.Enter or Key.Escape))
            {
                return;
            }

            e.Handled = true;
            DialogResult = e.Key is Key.Enter;
            Close();
        }
    }
}
