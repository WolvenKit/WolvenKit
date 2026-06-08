using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs;

public partial class ImportArgsDialog : ReactiveUserControl<ImportArgsDialogViewModel>
{
    private readonly HashSet<string> _hiddenProps = [
        "Target File Format"
    ];
    private readonly PropertyGrid _propertyGrid;

    public ImportArgsDialog()
    {
        InitializeComponent();

        _propertyGrid = FindName("OverlayPropertyGrid") as PropertyGrid;
    }

    private void OkButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is not Button { DataContext: ImportArgsDialogViewModel vm })
        {
            return;
        }

        vm.UserCanceled = false;
        vm.Close();
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is not Button { DataContext: ImportArgsDialogViewModel vm })
        {
            return;
        }

        vm.UserCanceled = true;
        vm.Close();
    }

    private void OverlayPropertyGrid_OnAutoGeneratingPropertyGridItem(object sender, AutoGeneratingPropertyGridItemEventArgs e)
    {
        if (_hiddenProps.Contains(e.DisplayName))
        {
            e.Cancel = true;
            return;
        }

        var selectedObject = _propertyGrid.SelectedObject;
        if (selectedObject == null)
        {
            return;
        }

        var propertyInfo = selectedObject.GetType().GetProperty(e.DisplayName);
        if (propertyInfo == null)
        {
            return;
        }
        var value = propertyInfo.GetValue(selectedObject);

        if (value == null)
        {
            e.Cancel = true;
        }
    }
}

