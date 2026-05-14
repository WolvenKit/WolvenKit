using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Views.Exporters;

namespace WolvenKit.Views.Dialogs;

public partial class ExportArgsDialog : ReactiveUserControl<ExportArgsDialogViewModel>
{
    private readonly PropertyGrid _propertyGrid;

    public ExportArgsDialog()
    {
        InitializeComponent();
        _propertyGrid = FindName("OverlayPropertyGrid") as PropertyGrid;
    }

    private void OkButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is not Button { DataContext: ExportArgsDialogViewModel vm })
        {
            return;
        }

        vm.UserCanceled = false;
        vm.Close();
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is not Button { DataContext: ExportArgsDialogViewModel vm })
        {
            return;
        }

        vm.UserCanceled = true;
        vm.Close();
    }

    private void OverlayPropertyGrid_OnAutoGeneratingPropertyGridItem(object sender, AutoGeneratingPropertyGridItemEventArgs e)
    {
        var selectedObject = _propertyGrid.SelectedObject;
        if (selectedObject == null)
        {
            return;
        }

        var propertyInfo = selectedObject.GetType().GetProperty(e.DisplayName);
        if (propertyInfo != null)
        {
            var value = propertyInfo.GetValue(selectedObject);

            if (value == null)
            {
                e.Cancel = true;
                return;
            }
        }

        if (e.OriginalSource is not PropertyItem propertyItem || ViewModel is null)
        {
            return;
        }

        switch (propertyItem.DisplayName)
        {
            case nameof(MeshExportArgs.Rig):
            case nameof(MeshExportArgs.MultiMeshMeshes):
            case nameof(MeshExportArgs.MultiMeshRigs):
                if (ViewModel.ArgsWrapper.Mesh is null)
                {
                    break;
                }
                propertyItem.Editor = new CustomCollectionEditor(ViewModel.InitCollectionEditor,
                    new CallbackArguments(ViewModel.ArgsWrapper.Mesh, propertyItem.DisplayName));
                break;
            case nameof(OpusExportArgs.SelectedForExport):
                if (ViewModel.ArgsWrapper.Opus is null)
                {
                    break;
                }
                propertyItem.Editor = new CustomCollectionEditor(ViewModel.InitCollectionEditor,
                    new CallbackArguments(ViewModel.ArgsWrapper.Opus, propertyItem.DisplayName));
                break;
            default:
                break;
        }
    }
}

