using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Templates;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Editor for a depot path stored as a 64-bit hash, with an optional dropdown
    /// </summary>
    public partial class FilterableDropdownResourcePathHashMenu : FilterableDropdownMenuBase<CUInt64>
    {
        public FilterableDropdownResourcePathHashMenu()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                if (DataContext is not ChunkViewModel vm)
                {
                    return;
                }

                InitializePropertyValues(vm);

                if (!ShowRefreshButton)
                {
                    ColumnRefreshButton.SetCurrentValue(ColumnDefinition.WidthProperty, new GridLength(0));
                }

                // If we don't have any options, no reason to show the dropdown - disable these UI elements
                // and show only the depot path editor
                if (Options.Count == 0 && !ShowRefreshButton)
                {
                    FilterRow.SetCurrentValue(RowDefinition.MinHeightProperty, 0.0);
                    FilterRow.SetCurrentValue(RowDefinition.HeightProperty, new GridLength(0));
                    FilterTextBox.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                }

                SetDropdownValueFromCvm();
            });
        }

        protected override void SetChunkViewModelValueFromDropdown()
        {
            if (string.IsNullOrWhiteSpace(SelectedOption) ||
                DataContext is not ChunkViewModel { Data: CUInt64 } cvm)
            {
                return;
            }

            cvm.Data = (CUInt64)(ulong)(ResourcePath)SelectedOption;
        }

        protected override void ResetDropdownValue() => Dropdown.SetCurrentValue(ComboBox.TextProperty, "");

        /// <summary>
        /// Selects the option whose value is the depot path of the current hash, or clears the dropdown if none matches.
        /// </summary>
        private void SetDropdownValueFromCvm()
        {
            if (DataContext is ChunkViewModel { Data: CUInt64 hash } &&
                ((ResourcePath)(ulong)hash).GetResolvedText() is string depotPath &&
                Options.ContainsValue(depotPath))
            {
                SetCurrentValue(SelectedOptionProperty, depotPath);
                return;
            }

            ResetDropdownValue();
        }
    }
}
