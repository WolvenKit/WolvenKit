using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.App.ViewModels.Events;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// 
    /// </summary>
    /// <example>
    /// Two-way binding doesn't work, needs to bind like this:
    /// <code>
    /// this.WhenActivated(disposables =>
    /// {
    ///    this.Bind(ViewModel,
    ///            x => x.ComponentName,
    ///            x => x.FilterableDropdownCNameMenu.SelectedOption)
    ///        .DisposeWith(disposables);
    ///});
    /// </code>
    /// </example>
    public partial class FilterableDropdownCNameMenu : ReactiveUserControl<ChunkViewModel>
    {
        public FilterableDropdownCNameMenu()
        {
            InitializeComponent();
            Options = [];


            this.WhenActivated(disposables =>
            {
                if (DataContext is not ChunkViewModel vm)
                {
                    return;
                }

                this.OneWayBind(ViewModel,
                        v => (CName)v.Data,
                        x => x.RedCNameEditor.RedString)
                    .DisposeWith(disposables);

                string[] optionValues = [];
                
                if (vm.Name is "className" && vm.Parent is { Name: "path", Data.RedType: "handle:gameJournalPath" })
                {
                    optionValues = RedTypeHelper.GetExtendedClassNames(typeof(gameJournalEntry));
                }

                SetCurrentValue(OptionsProperty, optionValues.ToDictionary(x => x, x => x));
                
                if (vm.Data is CName cname && cname.GetResolvedText() is not null)
                {
                    SetDropdownViewModelValueFromCName();
                }
            });
        }


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
                typeof(FilterableDropdownCNameMenu),
                new PropertyMetadata(null, OnPropertyChangedCallback));


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
                typeof(FilterableDropdownCNameMenu),
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
                typeof(FilterableDropdownCNameMenu),
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
                typeof(FilterableDropdownCNameMenu),
                new PropertyMetadata(null, OnPropertyChangedCallback));

        private static void OnPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (FilterableDropdownCNameMenu)d;
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
                    SetDropdownViewModelValueFromCName();
                    break;
                default:
                    break;
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void RecalculateFilteredOptions()
        {
            var options = (Options ?? []).Where(o =>
                string.IsNullOrEmpty(FilterText) || o.Key.Contains(FilterText, StringComparison.Ordinal)).ToList();
            SetCurrentValue(FilteredOptionsProperty, options);
        }

        private void SetChunkViewModelValueFromDropdown()
        {
            if (string.IsNullOrWhiteSpace(SelectedOption))
            {
                return;
            }

            if (DataContext is ChunkViewModel { Data: CName cname } cvm &&
                (cname.GetResolvedText() is not string s ||
                 s != SelectedOption))
            {
                cvm.Data = (CName)SelectedOption;
            }
        }

        private void SetDropdownViewModelValueFromCName()
        {
            if (DataContext is not ChunkViewModel vm || vm.Data is not CName cname ||
                cname.GetResolvedText() is not string s)
            {
                Dropdown.SetCurrentValue(ComboBox.TextProperty, "");
                return;
            }

            var option = Options.FirstOrDefault(o => o.Value == s);
            if (option.Key is null)
            {
                Dropdown.SetCurrentValue(ComboBox.TextProperty, "");
                return;
            }
            SetCurrentValue(SelectedOptionProperty, option.Key ?? "");
        }


        private void RedCNameEditor_ValueChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is not ChunkViewModel vm || vm.Data is not CName cname ||
                cname.GetResolvedText() is not string s || s == SelectedOption)
            {
                return;
            }

            SetDropdownViewModelValueFromCName();
        }
    }
}