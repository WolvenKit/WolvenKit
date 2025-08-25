using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Templates;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// RedRef editor with optional dropdown
    /// </summary>
    public partial class FilterableDropdownResourcePathMenu : FilterableDropdownMenuBase<IRedRef>
    {

        public FilterableDropdownResourcePathMenu()
        {

            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                if (DataContext is not ChunkViewModel vm)
                {
                    return;
                }

                _useDefaultOption = !IsExcludedFromAutoPopulation(vm);
                InitializePropertyValues(vm);

                if (!ShowRefreshButton)
                {
                    ColumnRefreshButton.SetCurrentValue(ColumnDefinition.WidthProperty, new GridLength(0));
                }

                // If we don't have any options, no reason to show the dropdown - disable these UI elements
                // and show only the default RedRef editor
                if (Options.Count == 0 && !ShowRefreshButton)
                {
                    FilterRow.SetCurrentValue(RowDefinition.HeightProperty, new GridLength(0));
                    FilterTextBox.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                }

                if (vm.Data is not IRedRef redRef)
                {
                    return;
                }

                SetCurrentValue(RedRefProperty, redRef);
                RedRefEditor.SetCurrentValue(RedRefEditor.RedRefProperty, redRef);

                SetDropdownValueFromCvm();
            });
        }

        #region properties


        public IRedRef RedRef
        {
            get => (IRedRef)GetValue(RedRefProperty);
            set => SetValue(RedRefProperty, value);
        }

        /// <summary>Identifies the <see cref="RedRef"/> dependency property.</summary>
        public static readonly DependencyProperty RedRefProperty =
            DependencyProperty.Register(
                nameof(RedRef),
                typeof(IRedRef),
                typeof(FilterableDropdownResourcePathMenu),
                new PropertyMetadata(null, OnPropertyChangedCallback));


        #endregion

        /// <summary>
        /// Returns the matching option key for the given option value.
        /// </summary>
        private string GetOptionKey(string optionValue)
        {
            var option = Options.FirstOrDefault(o => o.Value == optionValue);
            return option.Key ?? "";
        }

        protected override void SetChunkViewModelValueFromDropdown()
        {
            if (string.IsNullOrWhiteSpace(SelectedOption) ||
                DataContext is not ChunkViewModel { Data: IRedRef redRef } cvm)
            {
                return;
            }

            cvm.Data = RedTypeManager.CreateRedType(redRef.RedType, (ResourcePath)SelectedOption, redRef.Flags);
        }

        private void SetDropdownValueFromCvm()
        {
            var optionKey = "";
            if (DataContext is ChunkViewModel { Data: IRedRef redRef } &&
                redRef.DepotPath.GetResolvedText() is string value &&
                value != "")
            {
                optionKey = GetOptionKey(value);
            }

            if (string.IsNullOrEmpty(optionKey))
            {
                Dropdown.SetCurrentValue(ComboBox.TextProperty, "");
                return;
            }

            SetCurrentValue(SelectedOptionProperty, optionKey);
        }

        protected override void ResetDropdownValue() => Dropdown.SetCurrentValue(ComboBox.TextProperty, "");

        public static bool IsExcludedFromAutoPopulation(ChunkViewModel cvm) =>
            cvm.GetRootModel().ResolvedData is questQuestPhaseResource or scnSceneResource;
    }
}
