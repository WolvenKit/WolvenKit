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

                SetCurrentValue(OptionsProperty, CvmDropdownHelper.GetDropdownOptions(vm, _documentTools, false));
                SetCurrentValue(ShowRefreshButtonProperty, CvmDropdownHelper.ShouldShowRefreshButton(vm));

                if (!ShowRefreshButton)
                {
                    Col3.SetCurrentValue(ColumnDefinition.WidthProperty, new GridLength(0));
                }

                // If we don't have any options, no reason to show the dropdown - disable these UI elements
                // and show only the default RedString editor
                if (Options.Count == 0 && !ShowRefreshButton)
                {
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
                CvmDropdownHelper.GetDropdownOptions(vm, _documentTools, true));
            RecalculateFilteredOptions();
        }
    }
}