using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Templates;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// CName editor with optional dropdown
    /// </summary>
    public partial class FilterableDropdownCNameMenu : FilterableDropdownMenuBase<CName>
    {
        public FilterableDropdownCNameMenu()
        {
            InitializeComponent();
            _useDefaultOption = true;

            this.WhenActivated(disposables =>
            {
                if (DataContext is not ChunkViewModel vm)
                {
                    return;
                }

                this.OneWayBind(vm,
                        v => (CName)v.Data,
                        x => x.RedCNameEditor.RedString)
                    .DisposeWith(disposables);

                InitializePropertyValues(vm);

                if (!ShowRefreshButton)
                {
                    Col3.SetCurrentValue(ColumnDefinition.WidthProperty, new GridLength(0));
                }

                if (Options.Count != 0 || ShowRefreshButton)
                {
                    return;
                }

                // If we don't have any options, no reason to show the dropdown - disable these UI elements
                // and show only the default editor
                Row1.SetCurrentValue(RowDefinition.HeightProperty, new GridLength(0));
                Row2.SetCurrentValue(RowDefinition.HeightProperty, new GridLength(0));
                Placeholder.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                FilterTextBox.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            });
        }


        protected override void SetChunkViewModelValueFromDropdown()
        {
            if (string.IsNullOrWhiteSpace(SelectedOption))
            {
                return;
            }

            if (DataContext is ChunkViewModel { Data: CName var } cvm &&
                ((var.GetResolvedText() ?? "") != SelectedOption))
            {
                cvm.Data = (CName)SelectedOption;
            }
        }

        private void RedCNameEditor_ValueChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is ChunkViewModel { Data: CName var } && ((var.GetResolvedText() ?? "") != SelectedOption))
            {
                SetDropdownValueFromDataContext();
            }
        }

        protected override void ResetDropdownValue() => Dropdown.SetCurrentValue(ComboBox.TextProperty, "");
    }
}