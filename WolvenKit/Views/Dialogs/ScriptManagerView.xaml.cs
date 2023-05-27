using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ReactiveUI;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.App.ViewModels.Dialogs;

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
            ScriptsTreeGrid.View.NodeCollectionChanged += ScriptsTreeGridView_OnNodeCollectionChanged;

            ScriptsTreeGrid.View.Filter = IsScriptType;
            ScriptsTreeGrid.View.RefreshFilter();
        }
    }

    private void ScriptsTreeGridView_OnNodeCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        ScriptsTreeGrid.ExpandAllNodes();
    }

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
        if (o is ScriptDirectory scriptDirectory && scriptDirectory.ScriptType == GetSelectedTab())
        {
            return true;
        }

        if (o is ScriptFile scriptFile && scriptFile.ScriptType == GetSelectedTab())
        {
            return true;
        }

        return false;
    }

    private void ScriptsTreeGrid_OnCellDoubleTapped(object sender, TreeGridCellDoubleTappedEventArgs e)
    {
        if (ViewModel == null)
        {
            return;
        }

        if (e.Column is not TreeGridTextColumn)
        {
            return;
        }

        if (e.Node.Item is not ScriptFile scriptFile)
        {
            return;
        }

        ViewModel.OpenFile(scriptFile);
    }

    private async void Run_OnClick(object sender, RoutedEventArgs e)
    {
        if (ViewModel == null)
        {
            return;
        }

        if (sender is not Button { DataContext: ScriptFile scriptFile })
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

        if (sender is not Button { DataContext: ScriptFile scriptFile })
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

        ViewModel.AddScript(FileNameTextBox.Text, GetSelectedTab());
    }

    private ScriptType GetSelectedTab() =>
        ScriptTypeTabControl.SelectedIndex switch
        {
            0 => ScriptType.General,
            1 => ScriptType.OnSave,
            2 => ScriptType.Ui,
            _ => throw new ArgumentOutOfRangeException(nameof(TabControl.SelectedIndex))
        };
}
