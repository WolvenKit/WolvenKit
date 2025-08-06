using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using ReactiveUI;
using Splat;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Templates;

public abstract class FilterableDropdownMenuBase<T> : ReactiveUserControl<ChunkViewModel>
{
    protected readonly DocumentTools _documentTools;

    /// <summary>
    /// When CVM data is empty and dropdown has only one option, use that option as default?
    /// </summary>
    protected bool _useDefaultOption = false;

    /// <summary>
    /// Should using the filter reset the option cache?
    /// </summary>
    protected bool _filterResetsCache = false;

    /// <summary>
    /// When user filters dropdown, force initialization of options. Since we're refreshing cache,
    /// this should be called only once.
    /// </summary>
    protected bool _optionsInitialized = false;

    protected FilterableDropdownMenuBase()
    {
        _documentTools = Locator.Current.GetService<DocumentTools>();

        Options = [];
        FilteredOptions = [];
        ShowRefreshButton = false;
    }

    #region properties

    /// <summary>
    /// Dictionary of options for the dropdown menu. Key is used for display, value is written back to CVM.
    /// </summary>
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
            typeof(FilterableDropdownMenuBase<T>),
            new PropertyMetadata(null, OnPropertyChangedCallback));

    /// <summary>
    /// Filtered based on <see cref="FilterText"/> and bound to view model.
    /// </summary>
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
            typeof(FilterableDropdownMenuBase<T>),
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
            typeof(FilterableDropdownMenuBase<T>),
            new PropertyMetadata(false));

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
            typeof(FilterableDropdownMenuBase<T>),
            new PropertyMetadata(null, OnPropertyChangedCallback));


    /// <summary>
    /// Show the refresh button?
    /// </summary>
    public bool ShowRbgColorDropdown
    {
        get => (bool)GetValue(ShowRbgColorDropdownProperty);
        set => SetValue(ShowRbgColorDropdownProperty, value);
    }

    /// <summary>Identifies the <see cref="ShowRbgColorDropdown"/> dependency property.</summary>
    public static readonly DependencyProperty ShowRbgColorDropdownProperty =
        DependencyProperty.Register(
            nameof(ShowRbgColorDropdown),
            typeof(bool),
            typeof(FilterableDropdownMenuBase<T>),
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
            typeof(FilterableDropdownMenuBase<T>),
            new PropertyMetadata(null, OnPropertyChangedCallback));

    #endregion

    protected void RecalculateFilteredOptions(bool forceRecalculate = false)
    {
        if ((forceRecalculate || _filterResetsCache) && DataContext is ChunkViewModel vm)
        {
            _optionsInitialized = true;
            var searchString = _filterResetsCache ? FilterText : null;
            SetCurrentValue(OptionsProperty,
                CvmDropdownHelper.GetDropdownOptions(vm, _documentTools, true, searchString));
        }

        var options = Options.ToList();
        if (!string.IsNullOrWhiteSpace(FilterText))
        {
            options = options.Where(o => o.Key.Contains(FilterText, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        SetCurrentValue(FilteredOptionsProperty, options);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected static void OnPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var control = (FilterableDropdownMenuBase<T>)d;
        control.OnPropertyChanged(e.Property.Name);
    }

    protected virtual void OnPropertyChanged(string pName)
    {
        switch (pName)
        {
            case (nameof(Options)) or (nameof(FilterText)):
                // If user is filtering and we have no options, populate view model initially
                var forceRecalculate = !_optionsInitialized && pName is nameof(FilterText) && Options.Count == 0;
                RecalculateFilteredOptions(forceRecalculate);
                break;
            case nameof(SelectedOption):
                SetChunkViewModelValueFromDropdown();
                break;
            case nameof(ChunkViewModel.Data):
                SetDropdownValueFromDataContext();
                break;
            default:
                break;
        }

        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pName));
    }

    /// <summary>
    /// Get matching option key from data type. Override in implementing classes.
    /// </summary>
    private string GetOptionKey(T optionValue)
    {
        var optionValueString = GetString(optionValue);

        if (optionValueString == string.Empty)
        {
            return string.Empty;
        }

        var option = Options.FirstOrDefault(o => o.Value == optionValueString);
        return option.Key ?? "";
    }

    /// <summary>
    /// Get matching option key from data type. Override in implementing classes.
    /// </summary>
    private string GetString(T optionValue)
    {
        var ret = optionValue switch
        {
            CName cname => cname.GetResolvedText(),
            CString cStr => cStr.GetString(),
            IRedRef redRef => redRef.DepotPath.GetResolvedText(),
            _ => string.Empty
        };
        return ret?.Replace("None", "") ?? "";
    }

    /// <summary>
    /// This needs to be in the class with the view
    /// </summary>
    protected abstract void SetChunkViewModelValueFromDropdown();

    /// <summary>
    /// This needs to be in the class with the view
    /// </summary>
    protected abstract void ResetDropdownValue();

    protected void InitializePropertyValues(ChunkViewModel chunkViewModel)
    {
        if (DataContext is not ChunkViewModel vm)
        {
            return;
        }

        SetCurrentValue(OptionsProperty, CvmDropdownHelper.GetDropdownOptions(vm, _documentTools, false));
        SetCurrentValue(ShowRefreshButtonProperty, CvmDropdownHelper.ShouldShowRefreshButton(vm));

        SetCurrentValue(ShowRbgColorDropdownProperty, CvmDropdownHelper.ShouldShowColourInDropdown(vm));
    }

    protected void SetDropdownValueFromDataContext()
    {
        if (DataContext is not ChunkViewModel { Data: T value })
        {
            return;
        }

        if (GetOptionKey(value) is string optionKey && !string.IsNullOrEmpty(optionKey))
        {
            SetCurrentValue(SelectedOptionProperty, optionKey);
            return;
        }

        // If the dropdown has only one value and CVM is empty, we can default to the only option. 
        if (_useDefaultOption && Options.Count == 1 && string.IsNullOrEmpty(SelectedOption))
        {
            SetCurrentValue(SelectedOptionProperty, Options.First().Key);
            return;
        }

        ResetDropdownValue();
    }


    protected void RefreshButton_OnClick(object sender, RoutedEventArgs e)
    {
        if (DataContext is not ChunkViewModel vm)
        {
            return;
        }

        _optionsInitialized = true;

        SetCurrentValue(OptionsProperty,
            CvmDropdownHelper.GetDropdownOptions(vm, _documentTools, true));

        RecalculateFilteredOptions();
    }
}