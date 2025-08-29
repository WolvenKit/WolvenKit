using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using DynamicData;
using WolvenKit.App.Services;

namespace WolvenKit.Views.Templates
{
    public partial class FilterableChecklistMenu : UserControl, INotifyPropertyChanged
    {
        public FilterableChecklistMenu()
        {
            InitializeComponent();
            DataContext = this;

            SetCurrentValue(SelectedOptionsProperty, new ObservableCollection<string>());
            SetCurrentValue(AvailableOptionsProperty, new ObservableCollection<string>());
        }

        #region Dependency Properties

        public string Key
        {
            get => (string)GetValue(KeyProperty);
            set => SetValue(KeyProperty, value);
        }

        public static readonly DependencyProperty KeyProperty =
            DependencyProperty.Register(nameof(Key), typeof(string),
                typeof(FilterableChecklistMenu), new PropertyMetadata(null));

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register(nameof(Label), typeof(string),
                typeof(FilterableChecklistMenu), new PropertyMetadata(null));

        public string ControlName
        {
            get => (string)GetValue(ControlNameProperty);
            set => SetValue(ControlNameProperty, value);
        }

        public static readonly DependencyProperty ControlNameProperty =
            DependencyProperty.Register(nameof(ControlName), typeof(string),
                typeof(FilterableChecklistMenu), new PropertyMetadata(null));

        public string FilterText
        {
            get => (string)GetValue(FilterTextProperty);
            set => SetValue(FilterTextProperty, value);
        }

        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register(nameof(FilterText), typeof(string),
                typeof(FilterableChecklistMenu),
                new PropertyMetadata("", OnFilterTextChanged));

        public ObservableCollection<string> SelectedOptions
        {
            get => (ObservableCollection<string>)GetValue(SelectedOptionsProperty);
            set => SetValue(SelectedOptionsProperty, value);
        }

        public static readonly DependencyProperty SelectedOptionsProperty =
            DependencyProperty.Register(nameof(SelectedOptions), typeof(ObservableCollection<string>),
                typeof(FilterableChecklistMenu),
                new PropertyMetadata(null, OnSelectedOptionsChanged));

        public ObservableCollection<string> AvailableOptions
        {
            get => (ObservableCollection<string>)GetValue(AvailableOptionsProperty);
            set => SetValue(AvailableOptionsProperty, value);
        }

        public static readonly DependencyProperty AvailableOptionsProperty =
            DependencyProperty.Register(nameof(AvailableOptions), typeof(ObservableCollection<string>),
                typeof(FilterableChecklistMenu),
                new PropertyMetadata(null, OnAvailableOptionsChanged));

        private static List<string> FilteredOptions { get; set; } = [];

        public Dictionary<string, bool> CheckboxOptionsAndStates
        {
            get => (Dictionary<string, bool>)GetValue(CheckboxOptionsAndStatesProperty);
            set => SetValue(CheckboxOptionsAndStatesProperty, value);
        }

        public static readonly DependencyProperty CheckboxOptionsAndStatesProperty =
            DependencyProperty.Register(nameof(CheckboxOptionsAndStates), typeof(Dictionary<string, bool>),
                typeof(FilterableChecklistMenu),
                new PropertyMetadata(null, OnCheckboxOptionsAndStatesChanged));

        #endregion

        #region Filtered Options Handling

        private static void OnFilterTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is FilterableChecklistMenu control)
            {
                control.UpdateFilteredOptions();
            }
        }

        private static void OnAvailableOptionsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not FilterableChecklistMenu control)
            {
                return;
            }

            if (e.OldValue is ObservableCollection<string> oldCollection)
            {
                oldCollection.CollectionChanged -= control.AvailableOptions_CollectionChanged;
            }

            if (e.NewValue is ObservableCollection<string> newCollection)
            {
                newCollection.CollectionChanged += control.AvailableOptions_CollectionChanged;
            }

            control.UpdateFilteredOptions();
        }

        private static void OnCheckboxOptionsAndStatesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not FilterableChecklistMenu control)
            {
                return;
            }


            if (e.NewValue is Dictionary<string, bool> newCollection)
            {
                control.AvailableOptions = new ObservableCollection<string>(newCollection.Keys);
                control.SelectedOptions = new ObservableCollection<string>(
                    newCollection.Where(kvp => kvp.Value).Select(kvp => kvp.Key));
            }
            else
            {
                control.AvailableOptions = new ObservableCollection<string>();
                control.SelectedOptions = new ObservableCollection<string>();
            }

            control.UpdateFilteredOptions();
        }

        private static void OnSelectedOptionsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not FilterableChecklistMenu control)
            {
                return;
            }

            if (e.OldValue is ObservableCollection<string> oldCollection)
            {
                oldCollection.CollectionChanged -= control.SelectedOptions_CollectionChanged;
            }

            if (e.NewValue is ObservableCollection<string> newCollection)
            {
                newCollection.CollectionChanged += control.SelectedOptions_CollectionChanged;
                control.UpdateListBoxSelections();
            }
            else
            {
                control.multiselectList.SelectedItems.Clear();
            }
        }

        private void AvailableOptions_CollectionChanged(object sender,
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e) =>
            UpdateFilteredOptions();

        private void SelectedOptions_CollectionChanged(object sender,
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e) =>
            UpdateListBoxSelections();

        private void UpdateFilteredOptions()
        {
            if (AvailableOptions == null)
            {
                return;
            }

            FilteredOptions.Clear();

            FilteredOptions.AddRange(string.IsNullOrWhiteSpace(FilterText)
                ? AvailableOptions
                : AvailableOptions.Where(o => o.Contains(FilterText, StringComparison.OrdinalIgnoreCase))
            );

            multiselectList.SetCurrentValue(ItemsControl.ItemsSourceProperty, null);
            multiselectList.SetCurrentValue(ItemsControl.ItemsSourceProperty, FilteredOptions);
            UpdateListBoxSelections();
        }

        private void UpdateListBoxSelections()
        {
            if (SelectedOptions == null || multiselectList.ItemsSource == null)
            {
                return;
            }

            // Temporarily disable selection change handling
            multiselectList.SelectionChanged -= ListBox_OnSelectionChanged;

            try
            {
                multiselectList.SelectedItems.Clear();
                foreach (var item in multiselectList.Items)
                {
                    if (item is string option && SelectedOptions.Contains(option))
                    {
                        multiselectList.SelectedItems.Add(item);
                    }
                }
            }
            finally
            {
                // Re-enable selection change handling
                multiselectList.SelectionChanged += ListBox_OnSelectionChanged;
            }
        }

        #endregion

        #region Event Handlers

        public event EventHandler<List<string>> SelectionChanged;

        private void ListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedOptions ??= [];

            var selectedStrings = multiselectList.SelectedItems.OfType<string>().ToList();

            // Shift-click to select/deselect all
            if (ModifierViewStateService.IsShiftBeingHeld)
            {
                var skipAddFiltered = selectedStrings.SequenceEqual(FilteredOptions);
                selectedStrings.Clear();
                if (!skipAddFiltered)
                {
                    selectedStrings.AddRange(FilteredOptions);
                }
            }

            if (selectedStrings.SequenceEqual(SelectedOptions))
            {
                // Only update if different to prevent infinite loops
                return;
            }

            // Create a new collection to trigger property change notification
            var newSelection = new ObservableCollection<string>(selectedStrings);

            SetCurrentValue(SelectedOptionsProperty, newSelection);
            SelectionChanged?.Invoke(this, selectedStrings);
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #endregion

        public void ToggleSelection()
        {
            if (SelectedOptions.Count == 0)
            {
                SelectedOptions.AddRange(FilteredOptions);
            }
            else
            {
                SelectedOptions.Clear();
                UpdateListBoxSelections();
            }
        }
    }
}
