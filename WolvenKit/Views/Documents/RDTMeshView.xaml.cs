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
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Documents;
using Material = WolvenKit.ViewModels.Documents.Material;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for RDTTextureView.xaml
    /// </summary>
    public partial class RDTMeshView : ReactiveUserControl<RDTMeshViewModel>
    {

        private Dictionary<string, DiffuseMaterial> _materials = new();

        public RDTMeshView()
        {
            InitializeComponent();
            this.WhenActivated(disposables =>
            {
                ViewModel.WhenAnyValue(x => x.SelectedAppearance).Subscribe(source =>
                {
                    if (source is { } app)
                    {
                        LoadModels(app);
                    }
                });
            });

            MainDXViewportView.DXSceneInitialized += delegate (object sender, EventArgs args)
            {
                if (MainDXViewportView.DXScene == null) // Probably WPF 3D rendering
                    return;

                LoadModels(ViewModel.SelectedAppearance);
            };

            if (DataContext != null)
                ViewModel = DataContext as RDTMeshViewModel;
        }

        public void LoadModels(Appearance app)
        {
            if (app != null && app.Models != null)
            {
                foreach (var model in app.Models)
                {
                    LoadModel(model);
                }
                //Parallel.For(0, app.Models.Count, (i) => LoadModel(app.Models[i]));
                GC.Collect();
                //GC.WaitForPendingFinalizers();
                //GC.Collect();
                ShowAppearance(app, true);
            }
        }

        public void SetupMaterial(Material material, out DiffuseMaterial diffuseMaterial)
        {
            if (_materials.ContainsKey(material.Name))
            {
                diffuseMaterial = _materials[material.Name];
            }
            else
            { 
                ViewModel.LoadMaterial(material).Wait();

                diffuseMaterial = new DiffuseMaterial();
                diffuseMaterial.SetName($"{material.Name}");

                var physicallyBasedMaterial = new PhysicallyBasedMaterial();

                var filename_b = System.IO.Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + ".png");
                var filename_bn = System.IO.Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + "_n.png");
                var filename_d = System.IO.Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + "_d.dds");
                var filename_n = System.IO.Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + "_n.dds");

                if (File.Exists(filename_d))
                {
                    var shaderResourceView = TextureLoader.LoadShaderResourceView(MainDXViewportView.DXScene.Device,
                                                                                           filename_d,
                                                                                           loadDdsIfPresent: false,
                                                                                           convertTo32bppPRGBA: true,
                                                                                           generateMipMaps: true,
                                                                                           textureInfo: out var textureInfo);

                    physicallyBasedMaterial.TextureMaps.Add(new TextureMapInfo(TextureMapTypes.BaseColor, shaderResourceView, null, filename_d));

                    // Get recommended BlendState based on HasTransparency and HasPreMultipliedAlpha values.
                    // Possible values are: CommonStates.Opaque, CommonStates.PremultipliedAlphaBlend or CommonStates.NonPremultipliedAlphaBlend.
                    var recommendedBlendState = MainDXViewportView.DXScene.DXDevice.CommonStates.GetRecommendedBlendState(textureInfo.HasTransparency, textureInfo.HasPremultipliedAlpha);

                    physicallyBasedMaterial.BlendState = recommendedBlendState;
                    physicallyBasedMaterial.HasTransparency = textureInfo.HasTransparency;

                    //    var effect = new RedEffect();

                    //    MainDXViewportView.DXScene.DXDevice.EffectsManager.RegisterEffect(effect);

                    //    // test with "vehicle_mesh_decal CompiledTechnique [Index: 0, Pass 'renderstage_post_gbuffer', PassIndex: 0, Fallback: 0, RenderStageContext: [ID: 184, VF: MeshStaticVehicle]" 
                    //    byte[] vertexShaderBytecode = File.ReadAllBytes(System.IO.Path.Combine(ISettingsManager.GetTemp_OBJPath(), "shaders", "17053951590085590000.compiled_hlsl"));
                    //    byte[] pixelShaderBytecode = File.ReadAllBytes(System.IO.Path.Combine(ISettingsManager.GetTemp_OBJPath(), "shaders", "8347648445514612362.compiled_hlsl"));
                    //    // "MatMod_MaterialParam3IDSlot"        2 1
                    //    // "MatMod_MaterialParam4IDSlot"        1 1
                    //    // "MatMod_VehicleGridCorners"          4 1
                    //    // "MatMod_VehicleMeshPivotInGridSpace" 3 1

                    //    // 0 POSITION U16
                    //    // 0

                    //    effect.SetShaders(vertexShaderBytecode, pixelShaderBytecode);
                }

                else if (File.Exists(filename_b))
                {
                    var shaderResourceView = TextureLoader.LoadShaderResourceView(MainDXViewportView.DXScene.Device,
                                                                                           filename_b,
                                                                                           loadDdsIfPresent: false,
                                                                                           convertTo32bppPRGBA: true,
                                                                                           generateMipMaps: true,
                                                                                           textureInfo: out var textureInfo);

                    physicallyBasedMaterial.TextureMaps.Add(new TextureMapInfo(TextureMapTypes.BaseColor, shaderResourceView, null, filename_b));

                    // Get recommended BlendState based on HasTransparency and HasPreMultipliedAlpha values.
                    // Possible values are: CommonStates.Opaque, CommonStates.PremultipliedAlphaBlend or CommonStates.NonPremultipliedAlphaBlend.
                    var recommendedBlendState = MainDXViewportView.DXScene.DXDevice.CommonStates.GetRecommendedBlendState(textureInfo.HasTransparency, textureInfo.HasPremultipliedAlpha);

                    physicallyBasedMaterial.BlendState = recommendedBlendState;
                    physicallyBasedMaterial.HasTransparency = textureInfo.HasTransparency;
                }


                if (File.Exists(filename_n))
                {
                    var shaderResourceView = TextureLoader.LoadShaderResourceView(MainDXViewportView.DXScene.Device,
                                                                                           filename_n,
                                                                                           loadDdsIfPresent: false,
                                                                                           convertTo32bppPRGBA: true,
                                                                                           generateMipMaps: true,
                                                                                           textureInfo: out var textureInfo);

                    physicallyBasedMaterial.TextureMaps.Add(new TextureMapInfo(TextureMapTypes.NormalMap, shaderResourceView, null, filename_n));
                }
                else if (File.Exists(filename_bn))
                {
                    var shaderResourceView = TextureLoader.LoadShaderResourceView(MainDXViewportView.DXScene.Device,
                                                                                           filename_bn,
                                                                                           loadDdsIfPresent: false,
                                                                                           convertTo32bppPRGBA: true,
                                                                                           generateMipMaps: true,
                                                                                           textureInfo: out var textureInfo);

                    physicallyBasedMaterial.TextureMaps.Add(new TextureMapInfo(TextureMapTypes.NormalMap, shaderResourceView, null, filename_bn));
                }

                physicallyBasedMaterial.Roughness = 0.75f;
                physicallyBasedMaterial.Metalness = 0f;
                if (material.TemplateName == "vehicle_lights")
                {
                    physicallyBasedMaterial.EmissiveColor = Colors.Red.ToColor3();
                    physicallyBasedMaterial.HasTransparency = true;
                }

                //physicallyBasedMaterial.SetTextureMap(TextureMapTypes.EnvironmentCubeMap)



                diffuseMaterial.SetUsedDXMaterial(physicallyBasedMaterial);

                _materials[material.Name] = diffuseMaterial;

            }
        }

        public void LoadModel(LoadableModel model)
        {
            if (MainDXViewportView.DXScene == null) // Probably WPF 3D rendering
                return;

            if (model.Model != null || ViewModel == null)
            {
                return;
            }

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
                assimpWpfImporter.DefaultMaterial = new DiffuseMaterial(Brushes.Gray);

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
    
                    var assimpScene = assimpWpfImporter.ReadFileToAssimpScene(model.FilePath);

                    //var assimpWpfConverter = new AssimpWpfConverter();
                    //var readModel3D = assimpWpfConverter.ConvertAssimpModel(assimpScene);

                    //model3D = assimpWpfImporter.ReadModel3D(model.FilePath); // we can also define a textures path if the textures are located in some other directory (this is parameter can be skipped, but is defined here so you will know that you can use it)

                    var assimpWpfConverter = new AssimpWpfConverter();
                    model3D = assimpWpfConverter.ConvertAssimpModel(assimpScene);

                    foreach (var assimpMesh in assimpScene.Meshes)
                    {
                        var geometryModel3D = assimpWpfConverter.GetGeometryModel3DForAssimpMesh(assimpMesh);
                        if (geometryModel3D == null)
                            continue;

                        //var geometryModel3D = assimpWpfConverter.GetGeometryModel3DForAssimpMesh(assimpMesh);
                        SetMeshTangentData(assimpMesh, geometryModel3D);
                    }
                        //var assimpWpfConverter = new AssimpWpfConverter();
                        //model3D = assimpWpfConverter.ConvertAssimpModel(assimpScene);


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
                    //ShowAppearance(isNewFile); // If we just reloaded the previous file, we preserve the current camera TargetPosition and Distance
                    model3D.Transform = model.Transform;
                    model3D.SetName(model.Name);

                    if (model3D is Model3DGroup mg)
                    {
                        var i = 0;
                        foreach (var submesh in mg.Children)
                        {
                            Random r = new Random();
                            //var color = Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233));
                            var color = Colors.Gray;
                            Brush brush = new SolidColorBrush(color);

                            var material = new DiffuseMaterial(brush);

                            if (i < model.Materials.Count)
                            {
                                submesh.SetName($"{model.Name}_{i:D2}_{model.Materials[i].Name}");
                                SetupMaterial(model.Materials[i], out material);
                            }
                            else
                            {
                                material.SetName($"{model.Name}_{i:D2}");
                                submesh.SetName($"{model.Name}_{i:D2}");
                            }

                            ModelUtils.ChangeMaterial(submesh, material, material);

                            i++;
                        }
                    }
                    else
                    {
                        Random r = new Random();
                        //var color = Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233));
                        var color = Colors.Gray;
                        Brush brush = new SolidColorBrush(color);

                        var material = new DiffuseMaterial(brush);

                        if (0 < model.Materials.Count)
                        {
                            SetupMaterial(model.Materials[0], out material);
                        }
                        else
                        {
                            material.SetName($"{model.Name}");
                        }

                        ModelUtils.ChangeMaterial(model3D, material, material);

                    }

                    //var pbm = new PhysicallyBasedMaterial()
                    //{
                    //    BaseColor = new SharpDX.Color4((float)(r.Next(1, 255) / 256.0), (float)(r.Next(1, 255) / 256.0), (float)(r.Next(1, 233) / 256.0), 1)
                    //};
                    //pbm.SetTextureMap(TextureMapTypes.NormalMap, new SharpDX.Direct3D11.ShaderResourceView());

                    //material.SetUsedDXMaterial(pbm);
                    //ModelUtils.ChangeMaterial(model3D, material, material);
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

        private static void SetMeshTangentData(Mesh assimpMesh, GeometryModel3D geometryModel3D)
        {
            var assimpTangents = assimpMesh.Tangents;

            if (assimpTangents != null && assimpTangents.Count > 0)
            {
                var count = assimpTangents.Count;
                var dxTangents = new SharpDX.Vector3[count];

                for (int i = 0; i < count; i++)
                    dxTangents[i] = new SharpDX.Vector3(assimpTangents[i].X, assimpTangents[i].Y, assimpTangents[i].Z);

                // Tangent values are stored with the MeshGeometry3D object.
                // This is done with using DXAttributeType.MeshTangentArray:
                geometryModel3D.Geometry.SetDXAttribute(DXAttributeType.MeshTangentArray, dxTangents);
            }
        }

        public void ShowAppearance(Appearance app, bool updateCamera)
        {
            if (ViewModel == null)
                return;
            try
            {
                //ContentVisual.SetCurrentValue(ModelVisual3D.ContentProperty, model3D);

                var collection = new Model3DCollection(app.Models.Where(x => x.Model != null && x.IsEnabled).Select(x => x.Model));

                 var group = new Model3DGroup()
                {
                    Children = collection
                };

                // export the whole group/collection
                var assimpWpfExporter = new AssimpWpfExporter();
                assimpWpfExporter.AddModel(group);
                assimpWpfExporter.Export(System.IO.Path.Combine(ISettingsManager.GetTemp_OBJPath(), System.IO.Path.GetFileNameWithoutExtension(ViewModel.File.ContentId) + "_" + app.Name + ".glb"), "glb2");


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
                    Camera1.SetCurrentValue(Ab3d.Cameras.BaseTargetPositionCamera.DistanceProperty, modelSize / 2);
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
            if (ViewModel != null)
                LoadModels(ViewModel.SelectedAppearance);
        }

        private void SfTreeGrid_NodeCheckStateChanged(object sender, Syncfusion.UI.Xaml.TreeGrid.NodeCheckStateChangedEventArgs e)
        {
            if (ViewModel != null)
                LoadModels(ViewModel.SelectedAppearance);
        }
    }
}
