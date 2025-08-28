using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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
    ///            x => x.FilterableDropdownMenu.SelectedOption)
    ///        .DisposeWith(disposables);
    ///});
    /// </code>
    /// </example>
    public partial class FilterableDropdownMenu : UserControl, INotifyPropertyChanged
    {
        public FilterableDropdownMenu()
        {
            InitializeComponent();
            Options = [];

            DataContext = this;

            IsShowLabel = false;
        }

        #region properties

        public bool IsInline
        {
            get => (bool)GetValue(IsInlineProperty);
            set => SetValue(IsInlineProperty, value);
        }

        /// <summary>Identifies the <see cref="IsInline"/> dependency property.</summary>
        public static readonly DependencyProperty IsInlineProperty =
            DependencyProperty.Register(
                nameof(IsInline),
                typeof(bool),
                typeof(FilterableDropdownMenu),
                new PropertyMetadata(false, OnPropertyChangedCallback));

        /// <summary>
        /// Hide label if we don't have a text
        /// </summary>
        public bool IsShowLabel
        {
            get => (bool)GetValue(IsShowLabelProperty);
            set => SetValue(IsShowLabelProperty, value);
        }

        /// <summary>Identifies the <see cref="IsShowLabel"/> dependency property.</summary>
        public static readonly DependencyProperty IsShowLabelProperty =
            DependencyProperty.Register(
                nameof(IsShowLabel),
                typeof(bool),
                typeof(FilterableDropdownMenu),
                new PropertyMetadata(false, OnPropertyChangedCallback));

        public string Key
        {
            get => (string)GetValue(KeyProperty);
            set => SetValue(KeyProperty, value);
        }

        /// <summary>Identifies the <see cref="Key"/> dependency property.</summary>
        public static readonly DependencyProperty KeyProperty =
            DependencyProperty.Register(
                nameof(Key),
                typeof(string),
                typeof(FilterableDropdownMenu),
                new PropertyMetadata(null));

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        /// <summary>Identifies the <see cref="Label"/> dependency property.</summary>
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register(
                nameof(Label),
                typeof(string),
                typeof(FilterableDropdownMenu),
                new PropertyMetadata(null));

        public string ControlName
        {
            get => (string)GetValue(ControlNameProperty);
            set => SetValue(ControlNameProperty, value);
        }

        /// <summary>Identifies the <see cref="ControlName"/> dependency property.</summary>
        public static readonly DependencyProperty ControlNameProperty =
            DependencyProperty.Register(
                nameof(ControlName),
                typeof(string),
                typeof(FilterableDropdownMenu),
                new PropertyMetadata(null));

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
                typeof(FilterableDropdownMenu),
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
                typeof(FilterableDropdownMenu),
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
                typeof(FilterableDropdownMenu),
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
                typeof(FilterableDropdownMenu),
                new PropertyMetadata(null, OnPropertyChangedCallback));

        #endregion

        private void UpdateFilteredOptions()
        {
            if (Options == null)
            {
                SetCurrentValue(FilteredOptionsProperty, new List<KeyValuePair<string, string>>());
            }
            else
            {
                SetCurrentValue(FilteredOptionsProperty, Options
                    .Where(o => string.IsNullOrEmpty(FilterText) || o.Key.Contains(FilterText))
                    .ToList());
            }
        }

        private static void OnPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (FilterableDropdownMenu)d;
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
                    UpdateFilteredOptions();
                    break;
                case nameof(IsInline):
                    dropdown.SetCurrentValue(Grid.ColumnSpanProperty, IsInline ? 1 : 2);
                    dropdown.SetCurrentValue(Grid.ColumnProperty, IsInline ? 2 : 1);
                    dropdown.SetCurrentValue(Grid.RowProperty, IsInline ? 0 : 1);
                    filterTextBox.SetCurrentValue(Grid.ColumnSpanProperty, IsInline ? 1 : 2);
                    break;
                case nameof(Label) when !string.IsNullOrEmpty(Label):
                    SetCurrentValue(IsShowLabelProperty, true);
                    break;
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
