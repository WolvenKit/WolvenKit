using System.Collections;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using ReactiveUI;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.Views.Dialogs.Windows;
using WolvenKit.Views.Exporters;

namespace WolvenKit.Views.Dialogs;

public partial class ScriptSettingsDialog : ReactiveUserControl<ScriptSettingsDialogViewModel>
{
    public ScriptSettingsDialog()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            this.Bind(ViewModel, x => x.Settings, x => x.SettingsGrid.SelectedObject)
                .DisposeWith(disposables);

            this.BindCommand(ViewModel, x => x.OkCommand, x => x.OkButton)
                .DisposeWith(disposables);

            this.BindCommand(ViewModel, x => x.CancelCommand, x => x.CancelButton)
                .DisposeWith(disposables);
        });
    }

    private void SettingsGrid_OnAutoGeneratingPropertyGridItem(object sender, AutoGeneratingPropertyGridItemEventArgs e)
    {
        if (e.OriginalSource is not PropertyItem propertyItem ||
            sender is not PropertyGrid { SelectedObject: { } args } propertyGrid)
        {
            return;
        }

        if (propertyItem.PropertyType.IsAssignableTo(typeof(IList)))
        {
            propertyItem.Editor = new CustomCollectionEditor(InitCollectionEditor, new CallbackArguments(args, propertyItem.DisplayName));
        }
    }

    private Task InitCollectionEditor(CallbackArguments args)
    {
        if (args.Arg is not ScriptSettingsDialogViewModel.SettingsTypeDescriptor typeDescriptor)
        {
            return Task.CompletedTask;
        }

        var list = typeDescriptor.Settings[args.PropertyName];

        var collectionEditorView = new CollectionEditorView((IList)list.Value, list.InnerType);
        if (collectionEditorView.ShowDialog() == true)
        {
            typeDescriptor.Settings[args.PropertyName].Value = collectionEditorView.ResultList;
        }

        SettingsGrid.RefreshPropertygrid();
        return Task.CompletedTask;
    }
}
