using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.ViewModels.Importers;
using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.Views.Exporters;
/// <summary>
/// Interaction logic for TextureExportView.xaml
/// </summary>
public partial class TextureExportView : IViewFor<TextureExportViewModel>
{
    public TextureExportView()
    {
        InitializeComponent();

        ViewModel = Locator.Current.GetService<TextureExportViewModel>();
        DataContext = ViewModel;



        this.WhenActivated(disposables =>
        {
            this.OneWayBind(ViewModel,
                    x => x.SelectedObject.Properties,
                    x => x.OverlayPropertyGrid.SelectedObject)
                .DisposeWith(disposables);

            this.Bind(ViewModel,
                        x => x.ExportableItems,
                        x => x.ExportGrid.ItemsSource)
                    .DisposeWith(disposables);

            this.Bind(ViewModel,
                   x => x.SelectedObject,
                   x => x.ExportGrid.SelectedItem)
               .DisposeWith(disposables);

        });
    }

    public TextureExportViewModel ViewModel { get; set; }
    object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (TextureExportViewModel)value; }

    public bool? ShowDialog(System.Windows.Window owner)
    {
        Owner = owner;
        return ShowDialog();
    }

    private void OverlayPropertyGrid_AutoGeneratingPropertyGridItem(object sender, AutoGeneratingPropertyGridItemEventArgs e)
    {
        switch (e.DisplayName)
        {
            case nameof(ReactiveObject.Changed):
            case nameof(ReactiveObject.Changing):
            case nameof(ReactiveObject.ThrownExceptions):
                e.Cancel = true;
                return;
        }
    }


}
