using System;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using Microsoft.Extensions.Logging;
using ReactiveUI;
using Syncfusion.Windows.Tools.Controls;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Scripting;
using WolvenKit.Common.Model;
using Key = System.Windows.Input.Key;

namespace WolvenKit.Views.Dialogs;
public partial class RedTypeTemplateManagerView : ReactiveUserControl<RedTypeTemplateManagerViewModel>
{
    private DispatcherTimer _debounceTimer;
    private ComboBoxAdv _typeSelectorComboBox;

    public RedTypeTemplateManagerView()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            this.BindCommand(ViewModel, viewModel => viewModel.CancelCommand, view => view.CloseButton)
                .DisposeWith(disposables);
        });

        _debounceTimer = new DispatcherTimer() { Interval = TimeSpan.FromMilliseconds(100) };
        _debounceTimer.Tick += (_, _) =>
        {
            _debounceTimer.Stop();
            ApplyTypeComboBoxFilter(_typeSelectorComboBox);
        };
    }

    private async void Edit_OnClick(object sender, RoutedEventArgs e)
    {
        if (ViewModel == null)
        {
            return;
        }

        if (sender is not Button { DataContext: RedTypeTemplateDescriptorManagerExt templateFile})
        {
            return;
        }

        await ViewModel.EditFile(templateFile);
    }

    private async void TemplateDataGrid_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        if (ViewModel == null)
        {
            return;
        }

        if (sender is not Syncfusion.UI.Xaml.Grid.SfDataGrid dataGrid)
        {
            return;
        }

        var record = dataGrid.SelectedItem;

        if (record is null)
        {
            return;
        }

        await ViewModel.EditFile((RedTypeTemplateDescriptorManagerExt)record);
    }

    private async void Delete_OnClick(object sender, RoutedEventArgs e)
    {
        if (ViewModel == null)
        {
            return;
        }

        if (sender is not Button { DataContext: RedTypeTemplateDescriptorManagerExt templateDesc })
        {
            return;
        }

        await ViewModel.DeleteFile(templateDesc);
    }

    private void Add_OnClick(object sender, RoutedEventArgs e)
    {
        if (ViewModel == null)
        {
            return;
        }

        _ = ViewModel.AddTemplate(ViewModel.SelectedType.Type, FileNameTextBox.Text);
    }

    private void TypeSelectorComboBox_OnKeyUp(object sender, KeyEventArgs e)
    {
        if (sender is not ComboBoxAdv cba)
        {
            return;
        }

        _typeSelectorComboBox = cba;

        if (e.Key is Key.Escape
            or Key.Enter
            or Key.Return)
        {
            return;
        }

        _debounceTimer.Stop();
        _debounceTimer.Start();
    }

    private void ApplyTypeComboBoxFilter(ComboBoxAdv cba)
    {
        if (cba == null)
        {
            return;
        }

        var items = (CollectionView)CollectionViewSource.GetDefaultView(cba.ItemsSource);
        items.Filter = (o) =>
        {
            if (string.IsNullOrEmpty(cba.Text))
                return true;

            return (o as TypeDesc)?.TypeName.Contains(cba.Text, StringComparison.InvariantCultureIgnoreCase) ?? true;
        };
        items.Refresh();

        cba.SetCurrentValue(ComboBoxAdv.IsDropDownOpenProperty, true);
    }
}
