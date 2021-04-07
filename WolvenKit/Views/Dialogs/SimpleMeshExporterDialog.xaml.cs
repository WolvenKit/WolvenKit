using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using Ab3d;
using Ab3d.Assimp;
using Ab3d.Common.Cameras;
using Ab3d.Utilities;
using Assimp;
using Catel.IoC;
using Orc.ProjectManagement;
using Orchestra.Services;
using WolvenKit.Common.DDS;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.MeshFile;
using WolvenKit.RED4.MeshFile.Materials;

namespace WolvenKit.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for SimpleMeshExporterDialog.xaml
    /// </summary>
    public partial class SimpleMeshExporterDialog : HandyControl.Controls.Window
    {
        private AssimpWpfImporter _assimpWpfImporter;

        private ExportFormatDescription[] _exportFormatDescriptions;

        private bool _isInternalCameraChange;

        private string _selectedExportFormatId;

        private Dictionary<string, object> _namedObjects;


        public DirectoryInfo LibText { get; set; }


        public FileSystemInfoModel SelectedItem { get; set; }

        public string OutPath { get; set; }
        public bool ExtractRigged { get; set; }
        public bool ExportMaterials { get; set; }
        public bool CopyTextures { get; set; }
        public bool UseMaterialsRepository { get; set; }

        public EUncookExtension TextureFormat { get; set; }
        public List<Stream> SelectedRigFile { get; set; }
        public List<Stream> SelectedMeshFiles { get; set; }




        public SimpleMeshExporterDialog(object selectedItem)
        {
            InitializeComponent();
            AssimpLoader.LoadAssimpNativeLibrary();
            SelectedItem = selectedItem as FileSystemInfoModel;
            ExtractRiggedMeshRadio.IsChecked = false;
            ExportMaterialsCheckbox.IsChecked = false;
            ExtractRigged = false;
            ExportMaterials = false;
            CopyTextures = false;
            UseMaterialsRepository = false;
            DataContext = this;
            SelectedItem = selectedItem as FileSystemInfoModel;
            SelectedRigFile = new List<Stream>();
            SelectedMeshFiles = new List<Stream>();


            var assimpWpfExporter = new AssimpWpfExporter();
            _exportFormatDescriptions = assimpWpfExporter.ExportFormatDescriptions;
            for (var i = 0; i < _exportFormatDescriptions.Length; i++)
            {
                var comboBoxItem = new ComboBoxItem()
                {
                    Content = string.Format("{0} (.{1})", _exportFormatDescriptions[i].Description, _exportFormatDescriptions[i].FileExtension),
                    Tag = _exportFormatDescriptions[i].FormatId
                };

                ExportTypeComboBox.Items.Add(comboBoxItem);
            }


            // _selectedExportFormatId = _exportFormatDescriptions[ExportTypeComboBox.SelectedIndex].FormatId;   ///// BOTH BOXES FOR EXPORTTYPEBOX




            _assimpWpfImporter = new AssimpWpfImporter();
            _assimpWpfImporter.AssimpPostProcessSteps = PostProcessSteps.Triangulate;
            OutPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), SelectedItem.Name + ".dae");
        }


        private void meshxport_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int exportTypeIndex = ExportTypeComboBox.SelectedIndex;

            if (exportTypeIndex == -1)
                return;

            var selectedFileExtension = _exportFormatDescriptions[exportTypeIndex].FileExtension;

            _selectedExportFormatId = _exportFormatDescriptions[exportTypeIndex].FormatId;

        }
        private bool ExportViewport3D(string fileName, string exportFormatId, Viewport3D viewport3D, Dictionary<string, object> namedObjects)
        {
            // First create an instance of AssimpWpfExporter
            var assimpWpfExporter = new AssimpWpfExporter();

            // To export objects with names, we can use one of the following methods:
            // 1) Set object names with SetName extension method that is added by Ab3d.PowerToys (for example: boxVisual3D.SetName("BoxVisual1"); or
            // 2) Set assimpWpfExporter.NamedObjects to a Dictionary<string, object> dictionary with set names as keys and objects as values or
            // 3) Set assimpWpfExporter.ObjectNames to a Dictionary<object, string> dictionary with set objects as keys and names as values

            // Here we use NamedObjects because NamedObjects dictionary is also set when the 3D models are read from file
            assimpWpfExporter.NamedObjects = _namedObjects;


            // We can export Model3D, Visual3D or entire Viewport3D:
            //assimpWpfExporter.AddModel(model3D);
            //assimpWpfExporter.AddVisual3D(ContentModelVisual3D);
            //assimpWpfExporter.AddViewport3D(MainViewport);

            // Here we export Viewport3D:
            assimpWpfExporter.AddViewport3D(viewport3D);

            bool isExported;

            try
            {
                isExported = assimpWpfExporter.Export(fileName, exportFormatId);

                if (!isExported)
                { MessageBox.Show("Not exported"); }
            }
            catch (Exception ex) { MessageBox.Show("Error exporting:\r\n" + ex.Message); isExported = false; }
            return isExported;
        }

        private void LoadExportedScene(string fileName)
        {
            // Now read the exported file and show in the right Viewport3D

            Model3D readModel3D;

            try
            {
                // With uncommenting the following few lines we would use Ab3d.ReaderObj from Ab3d.PowerToys to read obj files instead of Assimp
                //if (fileName.EndsWith(".obj", ignoreCase: true, culture: CultureInfo.InvariantCulture))
                //{
                //    var readerObj = new Ab3d.ReaderObj();
                //    readModel3D = readerObj.ReadModel3D(fileName);
                //}
                //else
                //{
                var assimpWpfImporter = new AssimpWpfImporter();
                readModel3D = assimpWpfImporter.ReadModel3D(fileName);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file:\r\n" + ex.Message);
                return;
            }


            var modelVisual3D = new ModelVisual3D();
            modelVisual3D.Content = readModel3D;

            MainViewport2.Children.Clear();
            MainViewport2.Children.Add(modelVisual3D);


            // Set Camera2 from Camera1
            Camera2.TargetPosition = Camera1.TargetPosition;
            Camera2.SetCurrentValue(Ab3d.Cameras.SphericalCamera.HeadingProperty, Camera1.Heading);
            Camera2.SetCurrentValue(Ab3d.Cameras.SphericalCamera.AttitudeProperty, Camera1.Attitude);
            Camera2.SetCurrentValue(Ab3d.Cameras.BaseTargetPositionCamera.DistanceProperty, Camera1.Distance);

            ExportedSceneTitleTextBlock.SetCurrentValue(TextBlock.TextProperty, Path.GetFileName(fileName));
        }

        private void CreateTestScene()
        {
            ContentModelVisual3D.Children.Clear();
            ContentModelVisual3D.SetCurrentValue(ModelVisual3D.ContentProperty, null);


            var greenMaterial = new DiffuseMaterial(Brushes.Green);
            var redMaterial = new DiffuseMaterial(Brushes.Red);

            _namedObjects = new Dictionary<string, object>();

            // Create 7 x 7 boxes with different height
            for (int y = -3; y <= 3; y++)
            {
                for (int x = -3; x <= 3; x++)
                {
                    // Height is based on the distance from the center
                    double height = (5 - Math.Sqrt(x * x + y * y)) * 60;

                    // Create the 3D Box visual element

                    var boxVisual3D = new Ab3d.Visuals.BoxVisual3D()
                    {
                        CenterPosition = new Point3D(x * 100, height / 2, y * 100),
                        Size = new Size3D(80, height, 80),
                    };

                    if (height > 200)
                        boxVisual3D.Material = redMaterial;
                    else
                        boxVisual3D.Material = greenMaterial;

                    // To preserve the object names we can fill the names into the _namedObjects dictionary
                    _namedObjects.Add(string.Format("Box_{0}_{1}", x + 4, y + 4), boxVisual3D);

                    // We could also use the SetName method (extension added by Ab3d.PowerToys)
                    //boxVisual3D.SetName(string.Format("Box_{0}_{1}", x + 4, y + 4));

                    ContentModelVisual3D.Children.Add(boxVisual3D);
                }
            }
        }

        public void LoadModel(string fileName)
        {
            // Create an instance of AssimpWpfImporter
            var assimpWpfImporter = new AssimpWpfImporter();

            string fileExtension = System.IO.Path.GetExtension(fileName);
            if (!assimpWpfImporter.IsImportFormatSupported(fileExtension))
            {
                MessageBox.Show("Assimp does not support importing files file extension: " + fileExtension);
                return;
            }

            try
            {
                Mouse.OverrideCursor = Cursors.Wait;

                // Before reading the file we can set the default material (used when no other material is defined - here we set the default value again)
                assimpWpfImporter.DefaultMaterial = new DiffuseMaterial(Brushes.Silver);

                // After assimp importer reads the file, it can execute many post processing steps to transform the geometry.
                // See the possible enum values to see what post processes are available.
                // By default we just execute the Triangulate step to convert all polygons to triangles that are needed for WPF 3D.
                assimpWpfImporter.AssimpPostProcessSteps = PostProcessSteps.Triangulate;
                Model3D readModel3D = assimpWpfImporter.ReadModel3D(fileName, texturesPath: null);
                _namedObjects = assimpWpfImporter.NamedObjects;

                // Show the model
                ShowModel(readModel3D);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file:\r\n" + ex.Message);
            }
            finally
            {
                // Dispose unmanaged resources
                assimpWpfImporter.Dispose();

                Mouse.OverrideCursor = null;
            }
        }

        private void ShowModel(Model3D model3D)
        {
            ContentModelVisual3D.Children.Clear();
            ContentModelVisual3D.SetCurrentValue(ModelVisual3D.ContentProperty, model3D);


            // Calculate the center of the model and its size
            // This will be used to position the camera
            Camera1.TargetPosition = model3D.Bounds.GetCenterPosition();
            Camera1.SetCurrentValue(Ab3d.Cameras.BaseTargetPositionCamera.DistanceProperty, model3D.Bounds.GetDiagonalLength() * 1.2);

            // If the read model already define some lights, then do not show the Camera's light
            if (ModelUtils.HasAnyLight(model3D))
            { Camera1.SetCurrentValue(Ab3d.Cameras.BaseCamera.ShowCameraLightProperty, ShowCameraLightType.Never); }
            else
            { Camera1.SetCurrentValue(Ab3d.Cameras.BaseCamera.ShowCameraLightProperty, ShowCameraLightType.Always); }
            MainViewport2.Children.Clear();
            ExportedSceneTitleTextBlock.SetCurrentValue(TextBlock.TextProperty, "No Converted File");
        }



        private void ExportButton_OnClick(object sender, RoutedEventArgs e)
        {
            // var isExported = ExportViewport3D(OutputFileName.Text, _selectedExportFormatId, MainViewport, _namedObjects);
            var Item = SelectedItem;
            var x = MainController.GetGame().GetArchiveManagersManagers();
            var z = (ArchiveManager)x[0];
            var list = z.Archives.Values.ToList();





            try
            {
                var FIItem = new FileInfo(OutPath);
                var stream = new FileStream(Item.FullName, FileMode.Open);
                if (Item.FullName.Contains(".mesh", System.StringComparison.OrdinalIgnoreCase))
                {
                    if (!ExtractRigged && !ExportMaterials && !CopyTextures && !UseMaterialsRepository)
                    {
                        MESH.ExportMeshWithoutRig(stream, Item.Name, FIItem);
                    }

                    if (ExtractRigged)
                    {
                        SelectedMeshFiles.Add(stream);
                        var xz = new List<string>();
                        foreach (var str in SelectedMeshFiles)
                        {
                            FileStream fs = stream as FileStream;

                            xz.Add(Path.GetFileName(fs.Name));

                        }
                        MESH.ExportMultiMeshWithRig(SelectedMeshFiles, SelectedRigFile, xz, FIItem);
                    }
                    if (ExportMaterials && UseMaterialsRepository && CopyTextures)
                    {

                        var M = new MATERIAL(list);
                        if (ReturnThisForMe() != null)
                        {
                            M.ExportMeshWithMaterialsUsingAssetLib(stream, ReturnThisForMe(), Item.Name, FIItem, true, true);

                        }
                    }
                    if (ExportMaterials && UseMaterialsRepository)
                    {
                        var M = new MATERIAL(list);
                        if (ReturnThisForMe() != null)
                        {
                            M.ExportMeshWithMaterialsUsingAssetLib(stream, ReturnThisForMe(), Item.Name, FIItem);

                        }
                    }
                    if (ExportMaterials)
                    {
                        var M = new MATERIAL(list);
                        M.ExportMeshWithMaterialsUsingArchives(stream, Item.Name, FIItem);
                    }

                    Trace.WriteLine(_selectedExportFormatId);

                    if (!OutPath.Contains("gltf") || !OutPath.Contains("glb"))
                    {


                        if (!_selectedExportFormatId.Contains("gltf") || !_selectedExportFormatId.Contains("glb"))
                        {
                            var assimpWpfImporter = new AssimpWpfImporter();
                            assimpWpfImporter.DefaultMaterial = new DiffuseMaterial(Brushes.Silver);
                            assimpWpfImporter.AssimpPostProcessSteps = PostProcessSteps.Triangulate;
                            string file_path = "";
                            if (File.Exists(Path.ChangeExtension(FIItem.FullName, ".glb")))
                            {
                                file_path = Path.ChangeExtension(FIItem.FullName, ".glb");

                            }
                            else if (File.Exists(Path.ChangeExtension(FIItem.FullName, ".gltf")))
                            {
                                file_path = Path.ChangeExtension(FIItem.FullName, ".gltf");
                            }
                            else
                            {
                                throw new Exception("Something went wrong!");
                            }

                            Model3D readModel3D = assimpWpfImporter.ReadModel3D(file_path, texturesPath: null);
                            var assimpexport = new AssimpWpfExporter();
                            assimpexport.NamedObjects = _namedObjects;
                            assimpexport.AddModel(readModel3D);
                            bool isExported;

                            isExported = assimpexport.Export(FIItem.FullName, _selectedExportFormatId);

                            if (!isExported)
                            {
                                throw new Exception("Failed to export!");

                            }

                        }
                    }
                }
                ServiceLocator.Default.ResolveType<IGrowlNotificationService>().Success("Export completed to " + OutPath);

                this.Close();
            }
            catch (Exception exception)
            {
                ServiceLocator.Default.ResolveType<IGrowlNotificationService>().Error("Failed to export mesh: " + exception.ToString());
                this.Close();
            }
        }


        private DirectoryInfo ReturnThisForMe()
        {
            var mrp = ServiceLocator.Default.ResolveType<ISettingsManager>().MaterialRepositoryPath;

            if (String.IsNullOrEmpty(mrp))
            {
                ServiceLocator.Default.ResolveType<IGrowlNotificationService>().Error("Please set up MaterialRepositoryPath in the settings before trying to export!");
                return null;
            }

            var o = new DirectoryInfo(mrp);
            return o;
        }

        private void Camera1_OnCameraChanged(object sender, CameraChangedRoutedEventArgs e)
        {
            if (!IsLoaded || _isInternalCameraChange)
            { return; }
            _isInternalCameraChange = true;

            Camera2.SetCurrentValue(Ab3d.Cameras.SphericalCamera.HeadingProperty, Camera1.Heading);
            Camera2.SetCurrentValue(Ab3d.Cameras.SphericalCamera.AttitudeProperty, Camera1.Attitude);
            Camera2.SetCurrentValue(Ab3d.Cameras.BaseTargetPositionCamera.DistanceProperty, Camera1.Distance);

            _isInternalCameraChange = false;
        }

        private void Camera2_OnCameraChanged(object sender, CameraChangedRoutedEventArgs e)
        {
            if (!IsLoaded || _isInternalCameraChange)
            { return; }

            //Synchronize Camera1 and Camera2
            _isInternalCameraChange = true;

            Camera1.SetCurrentValue(Ab3d.Cameras.SphericalCamera.HeadingProperty, Camera2.Heading);
            Camera1.SetCurrentValue(Ab3d.Cameras.SphericalCamera.AttitudeProperty, Camera2.Attitude);
            Camera1.SetCurrentValue(Ab3d.Cameras.BaseTargetPositionCamera.DistanceProperty, Camera2.Distance);

            _isInternalCameraChange = false;
        }

        private void OpenExportedButton_OnClick(object sender, RoutedEventArgs e)
        {
            // Open exported file in notepad
            if (System.IO.File.Exists(OutputFileName.Text))
                System.Diagnostics.Process.Start("notepad.exe", OutputFileName.Text);
        }

        private Dictionary<string, object> ConvertToNamedObjects(Dictionary<object, string> objectNames)
        {
            var namedObjects = new Dictionary<string, object>();

            foreach (KeyValuePair<object, string> keyValuePair in objectNames)
            {
                if (keyValuePair.Value == null)
                    continue;

                namedObjects[keyValuePair.Value] = keyValuePair.Key;
            }

            return namedObjects;
        }

        private void ExportTypeComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int exportTypeIndex = ExportTypeComboBox.SelectedIndex;

            if (exportTypeIndex == -1)
                return;

            var selectedFileExtension = _exportFormatDescriptions[exportTypeIndex].FileExtension;

            _selectedExportFormatId = _exportFormatDescriptions[exportTypeIndex].FormatId;

            OutputFileName.SetCurrentValue(TextBox.TextProperty, System.IO.Path.ChangeExtension(OutputFileName.Text, selectedFileExtension));
            OutPath = System.IO.Path.ChangeExtension(OutputFileName.Text, selectedFileExtension);
        }

        private void ProgressButton_Click(object sender, RoutedEventArgs e)
        {

            var projectManager = ServiceLocator.Default.ResolveType<IProjectManager>();


            var ofd = new Microsoft.Win32.OpenFileDialog()
            {
                Filter = "Rig Files (*.rig) | *.rig;",
                InitialDirectory = Path.GetDirectoryName(projectManager?.ActiveProject.Location),
                Multiselect = true

            };

            var result = ofd.ShowDialog();
            if (result == false)
            {
                return;
            }



            foreach (string strng in ofd.FileNames)
            {
                xzz.Items.Add(strng);

                SelectedRigFile.Add(new FileStream(strng, FileMode.Open));
            }

        }

        private void ProgressButton_Click_1(object sender, RoutedEventArgs e)
        {
            var projectManager = ServiceLocator.Default.ResolveType<IProjectManager>();


            var ofd = new Microsoft.Win32.OpenFileDialog()
            {
                Filter = "Mesh Files (*.mesh) | *.mesh;",
                InitialDirectory = Path.GetDirectoryName(projectManager?.ActiveProject.Location),
                Multiselect = true
            };

            var result = ofd.ShowDialog();
            if (result == false)
            {
                return;
            }


            foreach (string strng in ofd.FileNames)
            {
                x65zz.Items.Add(strng);

                SelectedMeshFiles.Add(new FileStream(strng, FileMode.Open));
            }

        }
    }
}

