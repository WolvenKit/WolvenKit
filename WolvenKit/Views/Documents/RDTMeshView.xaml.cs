using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ab3d;
using Ab3d.Assimp;
using Ab3d.Common.Cameras;
using Ab3d.DirectX;
using Ab3d.DirectX.Effects;
using Ab3d.DirectX.Materials;
using Ab3d.Utilities;
using Ab3d.Visuals;
using Assimp;
using ReactiveUI;
using SharpDX;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Documents;
using Material = WolvenKit.ViewModels.Documents.Material;
using Node = WolvenKit.ViewModels.Documents.Node;
using HelixToolkit.Wpf.SharpDX;
using HelixToolkit.SharpDX.Core.Assimp;
using HelixToolkit.SharpDX.Core;
using HelixToolkit.SharpDX.Core.Model.Scene;
using System.Reactive.Disposables;

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

        private void ReloadModels(object sender, RoutedEventArgs e)
        {
            hxViewport.ZoomExtents();
            //if (ViewModel != null)
            //    LoadModels(ViewModel.SelectedAppearance);
        }
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
