using System;
using System.Collections.Generic;
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
using Ab3d.Utilities;
using Ab3d.Visuals;
using Assimp;
using ReactiveUI;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Ab4d;
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
            this.WhenActivated(disposables =>
            {
                ViewModel.WhenAnyValue(x => x.Models).Subscribe(source =>
                {
                    if (source is { })
                    {
                        LoadModels();
                    }
                });
            });
        }

        public void LoadModels()
        {
            foreach (var model in ViewModel.Models)
            {
                LoadModel(model);
            }
            GC.Collect();
            //GC.WaitForPendingFinalizers();
            //GC.Collect();
            ShowModel(true);
        }

        public void LoadModel(LoadableModel model)
        {
            if (model.Model != null)
                return;

            //bool isNewFile = false;

            // Create an instance of AssimpWpfImporter
            var assimpWpfImporter = new AssimpWpfImporter();

            string fileExtension = System.IO.Path.GetExtension(model.FilePath);
            if (!assimpWpfImporter.IsImportFormatSupported(fileExtension))
            {
                MessageBox.Show("Assimp does not support importing files file extension: " + fileExtension);
                return;
            }

            try
            {
                Mouse.OverrideCursor = Cursors.Wait;

                // Before readin the file we can set the default material (used when no other materila is defined - here we set the default value again)
                assimpWpfImporter.DefaultMaterial = new DiffuseMaterial(Brushes.Silver);

                // After assimp importer reads the file, it can execute many post processing steps to transform the geometry.
                // See the possible enum values to see what post processes are available.
                // Here we just set the AssimpPostProcessSteps to its default value - execute the Triangulate step to convert all polygons to triangles that are needed for WPF 3D.
                // Note that if ReadPolygonIndices is set to true in the next line, then the assimpWpfImporter will not use assimp's triangulation because it needs original polygon data.
                assimpWpfImporter.AssimpPostProcessSteps = PostProcessSteps.Triangulate;

                // When ReadPolygonIndices is true, assimpWpfImporter will read PolygonIndices collection that can be used to show polygons instead of triangles.
                assimpWpfImporter.ReadPolygonIndices = ReadPolygonIndicesCheckBox.IsChecked ?? false;

                // Read model from file
                Model3D model3D = null;

                try
                {
                    model3D = assimpWpfImporter.ReadModel3D(model.FilePath, texturesPath: null); // we can also define a textures path if the textures are located in some other directory (this is parameter can be skipped, but is defined here so you will know that you can use it)
                    //isNewFile = (_fileName != model.FilePath);
                    //_fileName = model.FilePath;
                }
                catch (Exception ex)
                {
                    model3D = null;
                    Locator.Current.GetService<ILoggerService>().Error(ex.Message);
                    //MessageBox.Show("Error importing file:\r\n" + ex.Message);
                }

                // After the model is read and if the object names are defined in the file,
                // you can get the model names by assimpWpfImporter.ObjectNames
                // or get object by name with assimpWpfImporter.NamedObjects

                // To get the  object model of the assimp importer, you can observe the assimpWpfImporter.ImportedAssimpScene

                // Show the model
                if (model3D != null)
                {
                    //ShowModel(isNewFile); // If we just reloaded the previous file, we preserve the current camera TargetPosition and Distance
                    model3D.Transform = model.Transform;
                    model.Model = model3D;
                }

                // Force garbage collection to clear the previously loaded objects from memory.
                // Note that sometimes when a lot of objects are created in large objects heap,
                // it may take two garbage collections to release the memory
                // (e.g. - after reading one large file, you will need to read two smaller files to clean the memory taken by the large file).
                //GC.Collect();
                //GC.WaitForPendingFinalizers();
                //GC.Collect();
            }
            finally
            {
                // Dispose unmanaged resources
                assimpWpfImporter.Dispose();

                Mouse.OverrideCursor = null;
            }
        }

        public void ShowModel(bool updateCamera)
        {
            try
            {
                //ContentVisual.SetCurrentValue(ModelVisual3D.ContentProperty, model3D);

                var collection = new Model3DCollection(ViewModel.Models.Where(x => x.Model != null && x.IsEnabled).Select(x => x.Model));
                var group = new Model3DGroup()
                {
                    Children = collection
                };

                ContentVisual.SetCurrentValue(ModelVisual3D.ContentProperty, group);

                // NOTE:
                // We could show both solid model and wireframe in WireframeVisual3D (ContentWireframeVisual) with using WireframeWithOriginalSolidModel for WireframeType.
                // But in this sample we show solid frame is separate ModelVisual3D and therefore we show only wireframe in WireframeVisual3D.
                ContentWireframeVisual.BeginInit();
                ContentWireframeVisual.SetCurrentValue(Ab3d.Visuals.WireframeVisual3D.ShowPolygonLinesProperty, ReadPolygonIndicesCheckBox.IsChecked ?? false);
                ContentWireframeVisual.SetCurrentValue(Ab3d.Visuals.WireframeVisual3D.OriginalModelProperty, group);
                ContentWireframeVisual.EndInit();

                if (AddLineDepthBiasCheckBox.IsChecked ?? false)
                {
                    // To specify line depth bias to the Ab3d.PowerToys line Visual3D objects,
                    // we use SetDXAttribute extension method and use LineDepthBias as DXAttributeType
                    // NOTE: This can be used only before the Visual3D is created by DXEngine.
                    // If you want to change the line bias after the object has been rendered, use the SetDepthBias method (see OnAddLineDepthBiasCheckBoxCheckedChanged)
                    //
                    // See DXEngineVisuals/LineDepthBiasSample for more info.
                    ContentWireframeVisual.SetDXAttribute(DXAttributeType.LineDepthBias, group.Bounds.GetDiagonalLength() * 0.001);
                }

                // Calculate the center of the model and its size
                // This will be used to position the camera

                if (updateCamera)
                {
                    var bounds = group.Bounds;

                    var modelCenter = new Point3D(bounds.X + bounds.SizeX / 2,
                        bounds.Y + bounds.SizeY / 2,
                        bounds.Z + bounds.SizeZ / 2);

                    var modelSize = Math.Sqrt(bounds.SizeX * bounds.SizeX +
                                              bounds.SizeY * bounds.SizeY +
                                              bounds.SizeZ * bounds.SizeZ);

                    Camera1.TargetPosition = modelCenter;
                    Camera1.SetCurrentValue(Ab3d.Cameras.BaseTargetPositionCamera.DistanceProperty, modelSize * 2);
                }

                // If the read model already define some lights, then do not show the Camera's light
                //if (ModelUtils.HasAnyLight(model3D))
                //    Camera1.SetCurrentValue(Ab3d.Cameras.BaseCamera.ShowCameraLightProperty, ShowCameraLightType.Never);
                //else
                //    Camera1.SetCurrentValue(Ab3d.Cameras.BaseCamera.ShowCameraLightProperty, ShowCameraLightType.Always);

                ShowInfoButton.SetCurrentValue(IsEnabledProperty, true);
            }
            catch (Exception e)
            {
                Locator.Current.GetService<ILoggerService>().Error(e.Message);
            }
        }


        public void LoadButton_OnClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

            openFileDialog.Filter = "3D model file (*.*)|*.*";
            openFileDialog.Title = "Open 3D model file file";

            if ((openFileDialog.ShowDialog() ?? false) && !string.IsNullOrEmpty(openFileDialog.FileName))
                LoadModel(new LoadableModel()
                {
                    FilePath = openFileDialog.FileName,
                    Transform = Transform3D.Identity
                });
        }

        public void OnShowWireframeCheckBoxCheckedChanged(object sender, RoutedEventArgs e)
        {
            if (!this.IsLoaded)
                return;

            if (ShowWireframeCheckBox.IsChecked ?? false)
                ContentWireframeVisual.SetCurrentValue(WireframeVisual3D.WireframeTypeProperty, WireframeVisual3D.WireframeTypes.Wireframe);
            else
                ContentWireframeVisual.SetCurrentValue(WireframeVisual3D.WireframeTypeProperty, WireframeVisual3D.WireframeTypes.None);
        }

        public void OnAddLineDepthBiasCheckBoxCheckedChanged(object sender, RoutedEventArgs e)
        {
            if (ContentWireframeVisual == null || ContentWireframeVisual.OriginalModel == null)
                return;

            double depthBiasValue;
            if (AddLineDepthBiasCheckBox.IsChecked ?? false)
            {
                depthBiasValue = ContentWireframeVisual.OriginalModel.Bounds.GetDiagonalLength() * 0.001;

                // To specify line depth bias to the Ab3d.PowerToys line Visual3D objects,
                // we use SetDXAttribute extension method and use LineDepthBias as DXAttributeType
                // NOTE: This can be used only before the Visual3D is created by DXEngine.
                // If you want to change the line bias after the object has been rendered, use the SetDepthBias method (defined below)
                //
                // See DXEngineVisuals/LineDepthBiasSample for more info.

                //ContentWireframeVisual.SetDXAttribute(DXAttributeType.LineDepthBias, depthBiasValue);
            }
            else
            {
                depthBiasValue = 0;
                //ContentWireframeVisual.ClearDXAttribute(DXAttributeType.LineDepthBias);
            }

            LineDepthBiasSample.SetDepthBias(MainDXViewportView, ContentWireframeVisual, depthBiasValue);
        }

        public void OnReadPolygonIndicesCheckBoxCheckedChanged(object sender, RoutedEventArgs e)
        {
            //if (_fileName == null)
            //    return;

            //if ((ReadPolygonIndicesCheckBox.IsChecked ?? false) && !(ShowWireframeCheckBox.IsChecked ?? false))
            //    ShowWireframeCheckBox.SetCurrentValue(System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, true); // Turn on showing wireframe if it was off and if ReadPolygonIndicesCheckBox is checked

            // Read file again
            //LoadModels();
        }

        public void ShowInfoButton_OnClick(object sender, RoutedEventArgs e)
        {
            var shownModel = ContentVisual.Content;

            if (shownModel == null)
                return;

            string objectInfo = Ab3d.Utilities.Dumper.GetObjectHierarchyString(shownModel);

            var textBox = new TextBox()
            {
                Margin = new Thickness(10, 10, 10, 10),
                HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                FontFamily = new FontFamily("Consolas"),
                Text = objectInfo
            };

            var window = new Window()
            {
                Title = "3D Object info"
            };

            window.Content = textBox;
            window.Show();
        }

        private void ReloadModels(object sender, RoutedEventArgs e)
        {
            LoadModels();
        }
    }
}
