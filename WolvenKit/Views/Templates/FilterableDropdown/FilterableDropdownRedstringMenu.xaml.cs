﻿using System;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Syncfusion.Windows.Controls.Input;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Templates;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// RedString editor with optional dropdown
    /// </summary>
    public partial class FilterableDropdownRedstringMenu : FilterableDropdownMenuBase<IRedString>
    {
        private static string s_LastSearchTerm = string.Empty;

        public FilterableDropdownRedstringMenu()
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
                        v => (CString)v.Data,
                        x => x.RedStringEditor.RedString)
                    .DisposeWith(disposables);

                InitializePropertyValues(vm);

                if (!ShowRefreshButton)
                {
                    ColumnRefreshButton.SetCurrentValue(ColumnDefinition.WidthProperty, new GridLength(0));
                }

                if (IsJournalEntryField(vm) && string.IsNullOrEmpty(FilterText) &&
                    !string.IsNullOrEmpty(s_LastSearchTerm))
                {
                    SetCurrentValue(FilterTextProperty, s_LastSearchTerm);

                    SetCurrentValue(OptionsProperty,
                        CvmDropdownHelper.GetDropdownOptions(vm, _documentTools, true, FilterText));

                    RecalculateFilteredOptions();
                }

                if (Options.Count != 0 || ShowRefreshButton)
                {
                    return;
                }

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

                            s_LastSearchTerm = filter;
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
                    ColumnRefreshButton.SetCurrentValue(ColumnDefinition.WidthProperty, new GridLength(0));
                }

                // For journal entries, always show the filter UI even if no options are loaded initially
                if (IsJournalEntryField(vm))
                {
                    // Always show filter UI for journal entries
                    FilterRow.SetCurrentValue(RowDefinition.HeightProperty, GridLength.Auto);
                    FilterTextBox.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                }
                else if (Options.Count == 0 && !ShowRefreshButton)
                {
                    // For non-journal entries, hide UI if no options
                    FilterRow.SetCurrentValue(RowDefinition.HeightProperty, new GridLength(0));
                    FilterTextBox.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    Dropdown.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                }

                SetDropdownValueFromDataContext();
            });
        }

        private void RedStringEditor_ValueChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is ChunkViewModel { Data: CString var } &&
                ((var.ToString() ?? "") != SelectedOption))
            {
                SetDropdownValueFromDataContext();
            }
        }

        private static bool IsJournalEntryField(ChunkViewModel vm) =>
            vm.Parent?.ResolvedData is gameJournalPath && vm.Name == "realPath";

        private void FilterTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            switch (e.Key)
            {
                case System.Windows.Input.Key.Enter when !string.IsNullOrWhiteSpace(FilterText):
                {
                    e.Handled = true;

                    // Force refresh to load filtered results
                    if (DataContext is ChunkViewModel vm)
                    {
                        SetCurrentValue(OptionsProperty,
                            CvmDropdownHelper.GetDropdownOptions(vm, _documentTools, true, FilterText));
                        RecalculateFilteredOptions();
                    }

                    // Always move focus to dropdown and open it
                    Dropdown.SetCurrentValue(ComboBox.IsDropDownOpenProperty, true);
                    Dropdown.Focus();
                    break;
                }
                case System.Windows.Input.Key.Escape:
                    e.Handled = true;

                    // Clear the filter text
                    SetCurrentValue(FilterTextProperty, "");

                    // Close dropdown if open
                    Dropdown.SetCurrentValue(ComboBox.IsDropDownOpenProperty, false);

                    // Move focus back to filter textbox
                    FilterTextBox.Focus();
                    break;
                case System.Windows.Input.Key.Down when FilteredOptions?.Count > 0:
                    e.Handled = true;

                    // Open dropdown and move focus to it
                    Dropdown.SetCurrentValue(ComboBox.IsDropDownOpenProperty, true);
                    Dropdown.Focus();
                    break;
                default:
                    break;
            }
        }

        protected override void SetChunkViewModelValueFromDropdown()
        {
            if (string.IsNullOrWhiteSpace(SelectedOption))
            {
                return;
            }

            if (DataContext is ChunkViewModel { Data: CString var } cvm && ((var.ToString() ?? "") != SelectedOption))
            {
                cvm.Data = (CString)SelectedOption;
            }
        }

        protected override void ResetDropdownValue() => Dropdown.SetCurrentValue(ComboBox.TextProperty, "");

        private void FilterTextBox_OnFocusLost(object sender, RoutedEventArgs e)
        {
            if (sender is not SfTextBoxExt tb || tb.Text == FilterText)
            {
                return;
            }

            SetCurrentValue(FilterTextProperty, tb.Text);

            s_LastSearchTerm = FilterText;
            RefreshButton_OnClick(sender, e);
        }
    }
}
