using System;
using System.Collections.Specialized;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Scripting;
using WolvenKit.Modkit.Scripting;
using SelectionChangedEventArgs = System.Windows.Controls.SelectionChangedEventArgs;

namespace WolvenKit.Views.Dialogs;
/// <summary>
/// Interaktionslogik für ScriptManagerView.xaml
/// </summary>
public partial class ScriptManagerView : ReactiveUserControl<ScriptManagerViewModel>
{
    public ScriptManagerView()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            this.BindCommand(ViewModel, viewModel => viewModel.CancelCommand, view => view.CloseButton)
                .DisposeWith(disposables);
        });
    }

    private void ScriptsTreeGrid_OnItemsSourceChanged(object sender, TreeGridItemsSourceChangedEventArgs e)
    {
        if (ScriptsTreeGrid.View != null)
        {
            // TODO MB
            //ScriptsTreeGrid.View.NodeCollectionChanged += ScriptsTreeGridView_OnNodeCollectionChanged;

            ScriptsTreeGrid.View.Filter = IsScriptType;
            ScriptsTreeGrid.View.RefreshFilter();
        }
    }

    // TODO MB
    //private void ScriptsTreeGridView_OnNodeCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    //{
    //    ScriptsTreeGrid.ExpandAllNodes();
    //}

    private void TabControl_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (ScriptsTreeGrid.View != null)
        {
            ScriptsTreeGrid.View.Filter = IsScriptType;
            ScriptsTreeGrid.View.RefreshFilter();
        }
    }

    private bool IsScriptType(object o)
    {
        if (o is ScriptDirectoryViewModel scriptDirectory && scriptDirectory.Type == GetSelectedTabType())
        {
            return true;
        }

        if (o is ScriptFileViewModel scriptFile && scriptFile.Type == GetSelectedTabType())
        {
            return true;
        }

        return false;
    }

    private async void ScriptsTreeGrid_OnCellDoubleTapped(object sender, TreeGridCellDoubleTappedEventArgs e)
    {
        if (ViewModel == null)
        {
            return;
        }

        if (e.Column is not TreeGridTextColumn)
        {
            return;
        }

        if (e.Node.Item is not ScriptFileViewModel scriptFile)
        {
            return;
        }

        await ViewModel.OpenFile(scriptFile);
    }

    private async void Run_OnClick(object sender, RoutedEventArgs e)
    {
        if (ViewModel == null)
        {
            return;
        }

        if (sender is not Button { DataContext: ScriptFileViewModel scriptFile })
        {
            return;
        }

        await ViewModel.RunFile(scriptFile);
    }

    private async void Delete_OnClick(object sender, RoutedEventArgs e)
    {
        if (ViewModel == null)
        {
            return;
        }

        if (sender is not Button { DataContext: ScriptFileViewModel scriptFile })
        {
            return;
        }

        await ViewModel.DeleteFile(scriptFile);
    }

    private void Add_OnClick(object sender, RoutedEventArgs e)
    {
        if (ViewModel == null)
        {
            return;
        }

        ViewModel.AddScript(FileNameTextBox.Text, GetSelectedTabType());
    }

    private ScriptType GetSelectedTabType() =>
        ScriptTypeTabControl.SelectedIndex switch
        {
            0 => ScriptType.General,
            1 => ScriptType.Hook,
            2 => ScriptType.Lib,
            3 => ScriptType.Ui,
            _ => throw new ArgumentOutOfRangeException(nameof(TabControl.SelectedIndex))
        };

    private void ScriptsTreeGrid_OnSelectionChanged(object sender, GridSelectionChangedEventArgs e)
    {
        var version = "";
        var author = "";
        var description = "";
        var usage = "";

        if (e.AddedItems.Count > 0 && e.AddedItems[0] is TreeGridRowInfo { RowData: ScriptFileViewModel scriptFile })
        {
            version = scriptFile.Version;
            author = scriptFile.Author;
            description = scriptFile.Description;
            usage = scriptFile.Usage;
        }

        VersionLabel.SetCurrentValue(ContentProperty, version);
        AuthorLabel.SetCurrentValue(ContentProperty, author);
        DescriptionLabel.SetCurrentValue(ContentProperty, description);
        UsageLabel.SetCurrentValue(ContentProperty, usage);
    }
}
