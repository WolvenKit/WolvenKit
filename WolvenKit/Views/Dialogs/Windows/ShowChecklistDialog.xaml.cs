using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Converters;
using WolvenKit.Views.Editors;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs.Windows;

public partial class ShowChecklistDialog : IViewFor<ShowChecklistDialogViewModel>
{
    private static List<string> s_lastSelection = [];
    private static string s_lastFileName = "";

    public ShowChecklistDialog(Dictionary<string, bool> checklistOptions, string fileName, string title, string text)
    {
        InitializeComponent();

        if (s_lastFileName != "")
        {
            fileName = s_lastFileName;
        }

        foreach (var se in s_lastSelection.Where(checklistOptions.ContainsKey))
        {
            checklistOptions[se] = true;
        }

        ViewModel = new ShowChecklistDialogViewModel(checklistOptions, fileName, title, text);
        DataContext = ViewModel;

        this.WhenActivated(disposables =>
        {
            // bind to filteredChecklistMenu
            this.Bind(ViewModel,
                    x => x.ChecklistOptions,
                    x => x.FilterableChecklistMenu.CheckboxOptionsAndStates)
                .DisposeWith(disposables);

            // bind to selectedoptions
            this.Bind(ViewModel,
                    x => x.SelectedOptions,
                    x => x.FilterableChecklistMenu.SelectedOptions,
                    viewToVMConverterOverride: new CollectionToCollectionTypeConverter(),
                    vmToViewConverterOverride: new CollectionToCollectionTypeConverter()
                )
                .DisposeWith(disposables);

            // Load last selection if available
            ViewModel.SelectedOptions = checklistOptions.Where(x => x.Value).Select(x => x.Key).ToList();

            // bind rest of properties
            this.Bind(ViewModel,
                    x => x.FileName,
                    x => x.FileNameBox.Text)
                .DisposeWith(disposables);

            this.Bind(ViewModel,
                    x => x.RememberValues,
                    x => x.RememberValuesCheckBox.IsChecked)
                .DisposeWith(disposables);
        });
    }


    public ShowChecklistDialogViewModel ViewModel { get; set; }

    object IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = (ShowChecklistDialogViewModel)value;
    }

    public bool? ShowDialog(Window owner)
    {
        Owner = owner;
        return ShowDialog();
    }


    private void SaveLastSelection()
    {
        if (ViewModel?.RememberValues != true)
        {
            s_lastSelection.Clear();
            s_lastFileName = "";
            return;
        }

        s_lastSelection = ViewModel.SelectedOptions.ToList();
        s_lastFileName = ViewModel.FileName;
    }

    private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key != Key.Enter)
        {
            return;
        }

        SaveLastSelection();
        e.Handled = true;
        DialogResult = true;
        Close();
    }

    private void WizardControl_OnFinish(object sender, RoutedEventArgs e) => SaveLastSelection();

    private void FileNameBox_OnLostFocus_(object sender, RoutedEventArgs e)
    {
        if (ViewModel is null || string.IsNullOrEmpty(ViewModel.FileName))
        {
            return;
        }

        if (!ViewModel.FileName.EndsWith(".txt"))
        {
            ViewModel.FileName += ".txt";
        }
    }

    private void ChecklistMenu_OnSelectionChanged(object _, List<string> selection)
    {
        if (ViewModel is null)
        {
            return;
        }

        ViewModel.SelectedOptions ??= [];

        ViewModel.SelectedOptions.Clear();
        ViewModel.SelectedOptions.AddRange(selection);
    }
}