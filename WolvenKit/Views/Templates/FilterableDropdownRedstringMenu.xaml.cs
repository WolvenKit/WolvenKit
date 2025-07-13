using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// RedString editor with optional dropdown
    /// </summary>
    public partial class FilterableDropdownRedstringMenu : ReactiveUserControl<ChunkViewModel>
    {
        private readonly DocumentTools _documentTools;

        public FilterableDropdownRedstringMenu()
        {
            _documentTools = Locator.Current.GetService<DocumentTools>();

            InitializeComponent();
            Options = [];
            FilteredOptions = [];
            ShowRefreshButton = false;

            this.WhenActivated(disposables =>
            {
                if (DataContext is not ChunkViewModel vm)
                {
                    return;
                }

                this.OneWayBind(ViewModel,
                        v => (CString)v.Data,
                        x => x.RedStringEditor.RedString)
                    .DisposeWith(disposables);

                SetCurrentValue(OptionsProperty, CvmDropdownHelper.GetDropdownOptions(vm, _documentTools, false, FilterText));
                SetCurrentValue(ShowRefreshButtonProperty, CvmDropdownHelper.ShouldShowRefreshButton(vm));

                // Also update options when FilterText changes
                this.WhenAnyValue(x => x.FilterText)
                    .Subscribe(filterText =>
                    {
                        // Refresh cache whenever filter text changes (including when it becomes empty)
                        SetCurrentValue(OptionsProperty, CvmDropdownHelper.GetDropdownOptions(vm, _documentTools, true, filterText));
                    })
                    .DisposeWith(disposables);

                // Show/hide dropdown based on filter and results
                this.WhenAnyValue(x => x.FilterText, x => x.FilteredOptions)
                    .Subscribe(tuple =>
                    {
                        var (filter, filteredOptions) = tuple;

                        if (IsJournalEntryField(vm))
                        {
                            // For journal entries, always show and enable the dropdown
                            Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                            Dropdown.SetCurrentValue(IsEnabledProperty, true);

                            if (string.IsNullOrWhiteSpace(filter))
                            {
                                Dropdown.SetCurrentValue(ComboBox.TextProperty, "Type to search journal entries...");
                            }
                            else if (filteredOptions != null && filteredOptions.Count > 0)
                            {
                                // Clear the text to show the dropdown items
                                Dropdown.SetCurrentValue(ComboBox.TextProperty, "");
                            }
                            else
                            {
                                Dropdown.SetCurrentValue(ComboBox.TextProperty, "No matching entries found");
                            }
                        }
                        else
                        {
                            // For non-journal entries, use the original logic
                            if (string.IsNullOrWhiteSpace(filter))
                            {
                                // No filter provided - show dropdown but disable it with helpful message
                                Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                                Dropdown.SetCurrentValue(IsEnabledProperty, false);
                                Dropdown.SetCurrentValue(ComboBox.TextProperty, "Type to search...");
                            }
                            else if (filteredOptions != null && filteredOptions.Count > 0)
                            {
                                // Filter provided and results found - show and enable dropdown
                                Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                                Dropdown.SetCurrentValue(IsEnabledProperty, true);
                            }
                            else
                            {
                                // Filter provided but no results - show dropdown and enable it so user can see the message
                                Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                                Dropdown.SetCurrentValue(IsEnabledProperty, true);
                                Dropdown.SetCurrentValue(ComboBox.TextProperty, "No matching entries found");
                            }
                        }
                    })
                    .DisposeWith(disposables);

                if (!ShowRefreshButton)
                {
                    Col3.SetCurrentValue(ColumnDefinition.WidthProperty, new GridLength(0));
                }

                // For journal entries, always show the filter UI even if no options are loaded initially
                if (IsJournalEntryField(vm))
                {
                    // Always show filter UI for journal entries
                    Row1.SetCurrentValue(RowDefinition.HeightProperty, GridLength.Auto);
                    Row2.SetCurrentValue(RowDefinition.HeightProperty, new GridLength(5));
                    Placeholder.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    FilterTextBox.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                }
                else if (Options.Count == 0 && !ShowRefreshButton)
                {
                    // For non-journal entries, hide UI if no options
                    Row1.SetCurrentValue(RowDefinition.HeightProperty, new GridLength(0));
                    Row2.SetCurrentValue(RowDefinition.HeightProperty, new GridLength(0));
                    Placeholder.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    FilterTextBox.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                }


                if (vm.Data is not CString redString)
                {
                    return;
                }

                SetDropdownValueFromRedString();

                if (string.IsNullOrEmpty(SelectedOption) && Options.Count == 1 &&
                    string.IsNullOrEmpty(redString.ToString()))
                {
                    SetCurrentValue(SelectedOptionProperty, Options.Keys.First());
                }
            });
        }

        #region properties

        public string FilterText
        {
            get => (string)GetValue(FilterTextProperty);
            set => SetValue(FilterTextProperty, value);
        }

        /// <summary>Identifies the <see cref="FilterText"/> dependency property.</summary>
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register(
                nameof(FilterText),
                typeof(string),
                typeof(FilterableDropdownRedstringMenu),
                new PropertyMetadata(null, OnPropertyChangedCallback));

        /// <summary>
        /// Show the refresh button?
        /// </summary>
        public bool ShowRefreshButton
        {
            get => (bool)GetValue(ShowRefreshButtonProperty);
            set => SetValue(ShowRefreshButtonProperty, value);
        }

        /// <summary>Identifies the <see cref="ShowRefreshButton"/> dependency property.</summary>
        public static readonly DependencyProperty ShowRefreshButtonProperty =
            DependencyProperty.Register(
                nameof(ShowRefreshButton),
                typeof(bool),
                typeof(FilterableDropdownRedstringMenu),
                new PropertyMetadata(false));

        public string SelectedOption
        {
            get => (string)GetValue(SelectedOptionProperty);
            set => SetValue(SelectedOptionProperty, value);
        }

        /// <summary>Identifies the <see cref="SelectedOption"/> dependency property.</summary>
        public static readonly DependencyProperty SelectedOptionProperty =
            DependencyProperty.Register(
                nameof(SelectedOption),
                typeof(string),
                typeof(FilterableDropdownRedstringMenu),
                new PropertyMetadata(null, OnPropertyChangedCallback));

        public Dictionary<string, string> Options
        {
            get => (Dictionary<string, string>)GetValue(OptionsProperty);
            set => SetValue(OptionsProperty, value);
        }

        /// <summary>Identifies the <see cref="Options"/> dependency property.</summary>
        public static readonly DependencyProperty OptionsProperty =
            DependencyProperty.Register(
                nameof(Options),
                typeof(Dictionary<string, string>),
                typeof(FilterableDropdownRedstringMenu),
                new PropertyMetadata(null, OnPropertyChangedCallback));

        public List<KeyValuePair<string, string>> FilteredOptions
        {
            get => (List<KeyValuePair<string, string>>)GetValue(FilteredOptionsProperty);
            set => SetValue(FilteredOptionsProperty, value);
        }

        /// <summary>Identifies the <see cref="FilteredOptions"/> dependency property.</summary>
        public static readonly DependencyProperty FilteredOptionsProperty =
            DependencyProperty.Register(
                nameof(FilteredOptions),
                typeof(List<KeyValuePair<string, string>>),
                typeof(FilterableDropdownRedstringMenu),
                new PropertyMetadata(null, OnPropertyChangedCallback));

        private static void OnPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (FilterableDropdownRedstringMenu)d;
            control.OnPropertyChanged(e.Property.Name);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// bind to SelectedOption in whenActivated
        /// </summary>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            switch (propertyName)
            {
                case (nameof(Options)) or (nameof(FilterText)):
                    RecalculateFilteredOptions();
                    break;
                case nameof(SelectedOption):
                    SetChunkViewModelValueFromDropdown();
                    break;
                case nameof(ChunkViewModel.Data):
                    SetDropdownValueFromRedString();
                    break;
                default:
                    break;
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        /// <summary>
        /// Returns the matching option key for the given option value.
        /// </summary>
        private string GetOptionKey(string optionValue)
        {
            var option = Options.FirstOrDefault(o => o.Value == optionValue);
            return option.Key ?? "";
        }

        private void RecalculateFilteredOptions()
        {
            var options = (Options ?? []).ToList();
            if (!string.IsNullOrWhiteSpace(FilterText))
            {
                options = options.Where(o => o.Key.Contains(FilterText, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            SetCurrentValue(FilteredOptionsProperty, options);
        }

        private void SetChunkViewModelValueFromDropdown()
        {
            if (string.IsNullOrWhiteSpace(SelectedOption))
            {
                return;
            }

            if (DataContext is ChunkViewModel { Data: CString var } cvm &&
                ((var.ToString() ?? "") != SelectedOption))
            {
                cvm.Data = (CString)SelectedOption;
            }
        }

        private void SetDropdownValueFromRedString()
        {
            var optionKey = "";
            if (DataContext is ChunkViewModel { Data: CString redString } &&
                redString.ToString() is string value &&
                value != "None")
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


        private void RedStringEditor_ValueChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is ChunkViewModel { Data: CString var } &&
                ((var.ToString() ?? "") != SelectedOption))
            {
                SetDropdownValueFromRedString();
            }
        }

        private void RefreshButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is not ChunkViewModel vm)
            {
                return;
            }

            SetCurrentValue(OptionsProperty,
                CvmDropdownHelper.GetDropdownOptions(vm, _documentTools, true, FilterText));
            RecalculateFilteredOptions();
        }

        private static bool IsJournalEntryField(ChunkViewModel vm)
        {
            return vm.Parent?.ResolvedData is gameJournalPath && vm.Name == "realPath";
        }

        private void UpdateDropdownState()
        {
            var filter = FilterText;
            var filteredOptions = FilteredOptions;

            if (string.IsNullOrWhiteSpace(filter))
            {
                // No filter provided - show dropdown but disable it with helpful message
                Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                Dropdown.SetCurrentValue(IsEnabledProperty, false);
                Dropdown.SetCurrentValue(ComboBox.TextProperty, "Type to search journal entries...");
            }
            else if (filteredOptions != null && filteredOptions.Count > 0)
            {
                // Filter provided and results found - show and enable dropdown
                Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                Dropdown.SetCurrentValue(IsEnabledProperty, true);
            }
            else
            {
                // Filter provided but no results - show dropdown and enable it so user can see the message
                Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                Dropdown.SetCurrentValue(IsEnabledProperty, true);
                Dropdown.SetCurrentValue(ComboBox.TextProperty, "No matching entries found");
            }
        }

        private void UpdateDropdownStateFromFilter(string filterText)
        {
            // Recalculate filtered options first
            RecalculateFilteredOptions();

            var filteredOptions = FilteredOptions;

            if (string.IsNullOrWhiteSpace(filterText))
            {
                // No filter provided - show dropdown but disable it with helpful message
                Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                Dropdown.SetCurrentValue(IsEnabledProperty, false);
                Dropdown.SetCurrentValue(ComboBox.TextProperty, "Type to search journal entries...");
            }
            else if (filteredOptions != null && filteredOptions.Count > 0)
            {
                // Filter provided and results found - show and enable dropdown
                Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                Dropdown.SetCurrentValue(IsEnabledProperty, true);
            }
            else
            {
                // Filter provided but no results - show dropdown and enable it so user can see the message
                Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                Dropdown.SetCurrentValue(IsEnabledProperty, true);
                Dropdown.SetCurrentValue(ComboBox.TextProperty, "No matching entries found");
            }
        }



        private void FilterTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter && !string.IsNullOrWhiteSpace(FilterText))
            {
                e.Handled = true;

                // Force refresh to load filtered results
                if (DataContext is ChunkViewModel vm)
                {
                    SetCurrentValue(OptionsProperty, CvmDropdownHelper.GetDropdownOptions(vm, _documentTools, true, FilterText));
                    RecalculateFilteredOptions();
                }

                // Always move focus to dropdown and open it
                Dropdown.SetCurrentValue(ComboBox.IsDropDownOpenProperty, true);
                Dropdown.Focus();
            }
            else if (e.Key == System.Windows.Input.Key.Escape)
            {
                e.Handled = true;

                // Clear the filter text
                SetCurrentValue(FilterTextProperty, "");

                // Close dropdown if open
                Dropdown.SetCurrentValue(ComboBox.IsDropDownOpenProperty, false);

                // Move focus back to filter textbox
                FilterTextBox.Focus();
            }
            else if (e.Key == System.Windows.Input.Key.Down && FilteredOptions?.Count > 0)
            {
                e.Handled = true;

                // Open dropdown and move focus to it
                Dropdown.SetCurrentValue(ComboBox.IsDropDownOpenProperty, true);
                Dropdown.Focus();
            }
        }
    }
}
