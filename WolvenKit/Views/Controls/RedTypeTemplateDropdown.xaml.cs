using System.Collections;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.App.ViewModels.Controls;

namespace WolvenKit.Views.Controls;

public partial class RedTypeTemplateDropdown : ReactiveUserControl<RedTypeTemplateDropdownViewModel>
{
    public RedTypeTemplateDropdown()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            this.OneWayBind(ViewModel, vm => vm.CurrentRedTypeTemplates.View, v => v.RedTemplateComboBox.ItemsSource)
                .DisposeWith(disposables);

            this.Bind(ViewModel, vm => vm.SelectedRedTypeTemplate, v => v.RedTemplateComboBox.SelectedItem)
                .DisposeWith(disposables);

            this.BindCommand(ViewModel, x => x.RefreshCommand, x => x.RefreshButton)
                .DisposeWith(disposables);
        });
    }
}

