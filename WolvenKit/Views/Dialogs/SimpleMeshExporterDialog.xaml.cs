using System;
using System.Collections.Generic;
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
using WolvenKit.Common.DDS;
using WolvenKit.Functionality.Controllers;
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
        public string SelectedRigFiles { get; set; }




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
            _assimpWpfImporter = new AssimpWpfImporter();
            _assimpWpfImporter.AssimpPostProcessSteps = PostProcessSteps.Triangulate;
            OutPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "WKitMeshExport.dae");
        }


        private bool ExportViewport3D(string fileName, string exportFormatId, Viewport3D viewport3D, Dictionary<string, object> namedObjects)
        {
            var assimpWpfExporter = new AssimpWpfExporter();
            assimpWpfExporter.NamedObjects = _namedObjects;
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

            Model3D readModel3D;
            try
            {
                var assimpWpfImporter = new AssimpWpfImporter();
                readModel3D = assimpWpfImporter.ReadModel3D(fileName);
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
            Camera2.TargetPosition = Camera1.TargetPosition;
            Camera2.SetCurrentValue(Ab3d.Cameras.SphericalCamera.HeadingProperty, Camera1.Heading);
            Camera2.SetCurrentValue(Ab3d.Cameras.SphericalCamera.AttitudeProperty, Camera1.Attitude);
            Camera2.SetCurrentValue(Ab3d.Cameras.BaseTargetPositionCamera.DistanceProperty, Camera1.Distance);
            ExportedSceneTitleTextBlock.SetCurrentValue(TextBlock.TextProperty, Path.GetFileName(fileName));
        }



        public void LoadModel(string fileName)
        {
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
                assimpWpfImporter.DefaultMaterial = new DiffuseMaterial(Brushes.Silver);
                assimpWpfImporter.AssimpPostProcessSteps = PostProcessSteps.Triangulate;
                Model3D readModel3D = assimpWpfImporter.ReadModel3D(fileName, texturesPath: null);
                _namedObjects = assimpWpfImporter.NamedObjects;
                ShowModel(readModel3D);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file:\r\n" + ex.Message);
            }
            finally
            {
                assimpWpfImporter.Dispose();
                Mouse.OverrideCursor = null;
            }
        }

        private void ShowModel(Model3D model3D)
        {
            ContentModelVisual3D.Children.Clear();
            ContentModelVisual3D.SetCurrentValue(ModelVisual3D.ContentProperty, model3D);
            Camera1.TargetPosition = model3D.Bounds.GetCenterPosition();
            Camera1.SetCurrentValue(Ab3d.Cameras.BaseTargetPositionCamera.DistanceProperty, model3D.Bounds.GetDiagonalLength() * 1.2);
            if (ModelUtils.HasAnyLight(model3D))
            { Camera1.SetCurrentValue(Ab3d.Cameras.BaseCamera.ShowCameraLightProperty, ShowCameraLightType.Never); }
            else
            { Camera1.SetCurrentValue(Ab3d.Cameras.BaseCamera.ShowCameraLightProperty, ShowCameraLightType.Always); }
            MainViewport2.Children.Clear();
            ExportedSceneTitleTextBlock.SetCurrentValue(TextBlock.TextProperty, "No Converted File");
        }



        private void ExportButton_OnClick(object sender, RoutedEventArgs e)
        {

            var Item = SelectedItem;
            var x = MainController.GetGame().GetArchiveManagersManagers();
            ArchiveManager z = (ArchiveManager)x[0];
            var list = z.Archives.Values.ToList();



            FileInfo FIItem = new FileInfo(OutPath);
            FileStream stream = new FileStream(Item.FullName, FileMode.Open);

            if (Item.FullName.Contains(".mesh", System.StringComparison.OrdinalIgnoreCase))
            {
                if (!ExtractRigged && !ExportMaterials && !CopyTextures && !UseMaterialsRepository)
                {
                    MESH.ExportMeshWithoutRig(stream, Item.Name, FIItem);
                }

                if (ExtractRigged)
                {
                    FileStream rigstream = new FileStream(SelectedRigFiles, FileMode.Open);
                    MESH.ExportMeshWithRig(stream, rigstream, Item.Name, FIItem);
                }
                if (ExportMaterials && UseMaterialsRepository && CopyTextures)
                {
                    var M = new MATERIAL(list);

                    M.ExportMeshWithMaterialsUsingAssetLib(stream, LibText, Item.Name, FIItem, true, true);
                }
                if (ExportMaterials && UseMaterialsRepository)
                {
                    var M = new MATERIAL(list);

                    M.ExportMeshWithMaterialsUsingAssetLib(stream, LibText, Item.Name, FIItem);
                }
                if (ExportMaterials)
                {
                    var M = new MATERIAL(list);
                    M.ExportMeshWithMaterialsUsingArchives(stream, Item.Name, FIItem);
                }
            }
            this.Close();


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
        }


    }
}

