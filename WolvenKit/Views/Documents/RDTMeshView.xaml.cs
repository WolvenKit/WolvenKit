using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using WolvenKit.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for RDTTextureView.xaml
    /// </summary>
    public partial class RDTMeshView : ReactiveUserControl<RDTMeshViewModel>
    {
        public RDTMeshView()
        {
            InitializeComponent();

            //hxViewport.DXSceneInitialized += delegate (object sender, EventArgs args)
            //{
            //    if (MainDXViewportView.DXScene == null) // Probably WPF 3D rendering
            //        return;

            //    hxViewport.ZoomExtents();
            //};

            this.WhenActivated(disposables =>
            {
                if (DataContext is RDTMeshViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                }

                this.OneWayBind(ViewModel,
                        viewModel => viewModel.SelectedAppearance.ModelGroup,
                        view => view.hxContentVisual.ItemsSource)
                    .DisposeWith(disposables);
            });
        }

        private void ReloadModels(object sender, RoutedEventArgs e) => hxViewport.ZoomExtents();//if (ViewModel != null)//    LoadModels(ViewModel.SelectedAppearance);
        private void ComboBoxAdv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (ViewModel != null)
            //    //LoadModels(ViewModel.SelectedAppearance);
            //    ShowAppearance(ViewModel.SelectedAppearance, true);
        }

        private void SfTreeGrid_NodeCheckStateChanged(object sender, Syncfusion.UI.Xaml.TreeGrid.NodeCheckStateChangedEventArgs e)
        {
            //if (ViewModel != null)
            //    ShowAppearance(ViewModel.SelectedAppearance, true);
            ////LoadModels(ViewModel.SelectedAppearance);
        }
    }
}
