using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WolvenKit.Views.Editors
{
    public partial class FilterableDropdownMenu : UserControl, INotifyPropertyChanged
    {
        public FilterableDropdownMenu()
        {
            InitializeComponent();
            Options = [];

            DataContext = this;
        }

        public string Key
        {
            get => (string)GetValue(KeyProperty);
            set => SetValue(KeyProperty, value);
        }

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

        public static readonly DependencyProperty FilteredOptionsProperty =
            DependencyProperty.Register(
                nameof(FilteredOptions),
                typeof(List<KeyValuePair<string, string>>),
                typeof(FilterableDropdownMenu),
                new PropertyMetadata(null, OnPropertyChangedCallback));

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

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (propertyName == nameof(Options) || propertyName == nameof(FilterText))
            {
                UpdateFilteredOptions();
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}