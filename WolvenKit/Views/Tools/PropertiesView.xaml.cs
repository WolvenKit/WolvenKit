using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Threading;
using Ab3d;
using Ab3d.Assimp;
using Ab3d.Common.Cameras;
using Ab3d.DirectX;
using Ab3d.Utilities;
using Ab3d.Visuals;
using Assimp;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.Common.Extensions;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Tools;
using WolvenKit.Views.Editor.AudioTool;
using WPFSoundVisualizationLib;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for PropertiesView.xaml
    /// </summary>
    public partial class PropertiesView : ReactiveUserControl<PropertiesViewModel>
    {
        public string _fileName;

        private readonly MediaPlayer mediaPlayer = new MediaPlayer();

        public PropertiesView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<PropertiesViewModel>();
            DataContext = ViewModel;

            Helpers.LoadAssimpNativeLibrary();

            var assimpWpfImporter = new AssimpWpfImporter();
            var supportedImportFormats = assimpWpfImporter.SupportedImportFormats;
            var assimpWpfExporter = new AssimpWpfExporter();
            var supportedExportFormats = assimpWpfExporter.ExportFormatDescriptions.Select(f => f.FileExtension).ToArray();

            //var themeResources = Application.LoadComponent(new Uri("Resources/Styles/ExpressionDark.xaml", UriKind.Relative)) as ResourceDictionary;
            //Resources.MergedDictionaries.Add(themeResources);

            spectrumAnalyzer.RegisterSoundPlayer(NAudioSimpleEngine.Instance);
            waveformTimeline.RegisterSoundPlayer(NAudioSimpleEngine.Instance);

            nAudioSimple = NAudioSimpleEngine.Instance;
            NAudioSimpleEngine.Instance.PropertyChanged += NAudioEngine_PropertyChanged;

            //appControl.ExeName = "binkpl64.exe";
            //appControl.Args = "test2.bk2 /J /I2 /P";
            //this.Unloaded += new RoutedEventHandler((s, e) => { appControl.Dispose(); });

            this.WhenActivated(disposables =>
            {
                ViewModel.WhenAnyValue(x => x.LoadedBitmapFrame).Subscribe(source =>
                {
                    if (source is { } frame)
                    {
                        LoadImage(frame);
                    }
                });
                ViewModel.WhenAnyValue(x => x.LoadedModelPath).Subscribe(source =>
                {
                    if (source is { } modelpath)
                    {
                        LoadModel(modelpath);
                    }
                });

                ViewModel.PreviewAudioCommand.Subscribe(path =>
                {
                    TempConvertToWemWav(path);
                });
            });
        }

        #region properties

        public NAudioSimpleEngine nAudioSimple { get; set; }

        //public TimeSpan ChannelPosition { get; set; }

        //public string AudioPositionText { get; set; }

        //public string CurrentTrackName { get; set; }

        //public string ChannelLength { get; set; }

        #endregion

        private void PropertyGrid_OnAutoGeneratingPropertyGridItem(object sender, AutoGeneratingPropertyGridItemEventArgs e)
        {
            switch (e.DisplayName)
            {
                case nameof(ReactiveObject.Changed):
                case nameof(ReactiveObject.Changing):
                case nameof(ReactiveObject.ThrownExceptions):
                    e.Cancel = true;
                    break;
            }
            e.ReadOnly = true;
        }

        private Stream StreamFromBitmapSource(BitmapSource writeBmp)
        {
            Stream bmp = new MemoryStream();

            BitmapEncoder enc = new BmpBitmapEncoder();
            enc.Frames.Add(BitmapFrame.Create(writeBmp));
            enc.Save(bmp);

            return bmp;
        }

        public void LoadImage(BitmapSource qa) => bold.SetCurrentValue(Syncfusion.UI.Xaml.ImageEditor.SfImageEditor.ImageProperty, StreamFromBitmapSource(qa));

        public void LoadModel(string fileName)
        {
            var isNewFile = false;

            // Create an instance of AssimpWpfImporter
            var assimpWpfImporter = new AssimpWpfImporter();

            var fileExtension = System.IO.Path.GetExtension(fileName);
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
                Model3D readModel3D;

                try
                {
                    readModel3D = assimpWpfImporter.ReadModel3D(fileName, texturesPath: null); // we can also define a textures path if the textures are located in some other directory (this is parameter can be skipped, but is defined here so you will know that you can use it)

                    isNewFile = (_fileName != fileName);
                    _fileName = fileName;
                }
                catch (Exception ex)
                {
                    readModel3D = null;
                    MessageBox.Show("Error importing file:\r\n" + ex.Message);
                }

                // After the model is read and if the object names are defined in the file,
                // you can get the model names by assimpWpfImporter.ObjectNames
                // or get object by name with assimpWpfImporter.NamedObjects

                // To get the  object model of the assimp importer, you can observe the assimpWpfImporter.ImportedAssimpScene

                // Show the model
                if (readModel3D != null)
                {
                    ShowModel(readModel3D, updateCamera: isNewFile); // If we just reloaded the previous file, we preserve the current camera TargetPosition and Distance
                }

                // Force garbage collection to clear the previously loaded objects from memory.
                // Note that sometimes when a lot of objects are created in large objects heap,
                // it may take two garbage collections to release the memory
                // (e.g. - after reading one large file, you will need to read two smaller files to clean the memory taken by the large file).
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
            finally
            {
                // Dispose unmanaged resources
                assimpWpfImporter.Dispose();

                Mouse.OverrideCursor = null;
            }
        }

        public void ShowModel(Model3D model3D, bool updateCamera)
        {
            try
            {
                ContentVisual.SetCurrentValue(ModelVisual3D.ContentProperty, model3D);

                // NOTE:
                // We could show both solid model and wireframe in WireframeVisual3D (ContentWireframeVisual) with using WireframeWithOriginalSolidModel for WireframeType.
                // But in this sample we show solid frame is separate ModelVisual3D and therefore we show only wireframe in WireframeVisual3D.
                ContentWireframeVisual.BeginInit();
                ContentWireframeVisual.SetCurrentValue(Ab3d.Visuals.WireframeVisual3D.ShowPolygonLinesProperty, ReadPolygonIndicesCheckBox.IsChecked ?? false);
                ContentWireframeVisual.SetCurrentValue(Ab3d.Visuals.WireframeVisual3D.OriginalModelProperty, model3D);
                ContentWireframeVisual.EndInit();

                if (AddLineDepthBiasCheckBox.IsChecked ?? false)
                {
                    // To specify line depth bias to the Ab3d.PowerToys line Visual3D objects,
                    // we use SetDXAttribute extension method and use LineDepthBias as DXAttributeType
                    // NOTE: This can be used only before the Visual3D is created by DXEngine.
                    // If you want to change the line bias after the object has been rendered, use the SetDepthBias method (see OnAddLineDepthBiasCheckBoxCheckedChanged)
                    //
                    // See DXEngineVisuals/LineDepthBiasSample for more info.
                    ContentWireframeVisual.SetDXAttribute(DXAttributeType.LineDepthBias, model3D.Bounds.GetDiagonalLength() * 0.001);
                }

                // Calculate the center of the model and its size
                // This will be used to position the camera

                if (updateCamera)
                {
                    var bounds = model3D.Bounds;

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
                if (ModelUtils.HasAnyLight(model3D))
                {
                    Camera1.SetCurrentValue(Ab3d.Cameras.BaseCamera.ShowCameraLightProperty, ShowCameraLightType.Never);
                }
                else
                {
                    Camera1.SetCurrentValue(Ab3d.Cameras.BaseCamera.ShowCameraLightProperty, ShowCameraLightType.Always);
                }

                ShowInfoButton.SetCurrentValue(IsEnabledProperty, true);
            }
            catch
            {
            }
        }

        public void LoadButton_OnClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog
            {
                InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources"),

                Filter = "3D model file (*.*)|*.*",
                Title = "Open 3D model file file"
            };

            if ((openFileDialog.ShowDialog() ?? false) && !string.IsNullOrEmpty(openFileDialog.FileName))
            {
                LoadModel(openFileDialog.FileName);
            }
        }

        public void OnShowWireframeCheckBoxCheckedChanged(object sender, RoutedEventArgs e)
        {
            if (!IsLoaded)
            {
                return;
            }

            if (ShowWireframeCheckBox.IsChecked ?? false)
            {
                ContentWireframeVisual.SetCurrentValue(WireframeVisual3D.WireframeTypeProperty, WireframeVisual3D.WireframeTypes.Wireframe);
            }
            else
            {
                ContentWireframeVisual.SetCurrentValue(WireframeVisual3D.WireframeTypeProperty, WireframeVisual3D.WireframeTypes.None);
            }
        }

        public void OnAddLineDepthBiasCheckBoxCheckedChanged(object sender, RoutedEventArgs e)
        {
            if (ContentWireframeVisual == null || ContentWireframeVisual.OriginalModel == null)
            {
                return;
            }

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
            if (_fileName == null)
            {
                return;
            }

            if ((ReadPolygonIndicesCheckBox.IsChecked ?? false) && !(ShowWireframeCheckBox.IsChecked ?? false))
            {
                ShowWireframeCheckBox.SetCurrentValue(System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, true); // Turn on showing wireframe if it was off and if ReadPolygonIndicesCheckBox is checked
            }

            // Read file again
            LoadModel(_fileName);
        }

        public void ShowInfoButton_OnClick(object sender, RoutedEventArgs e)
        {
            var shownModel = ContentVisual.Content;

            if (shownModel == null)
            {
                return;
            }

            var objectInfo = Ab3d.Utilities.Dumper.GetObjectHierarchyString(shownModel);

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

        #region AudioPreview

        private void BrowseButton_Click(object sender, RoutedEventArgs e) => OpenFile();

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NAudioSimpleEngine.Instance.Dispose();
            if (NAudioSimpleEngine.Instance.CanStop)
            {
                NAudioSimpleEngine.Instance.Stop();
            }
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
        }

        private void DefaultThemeMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            //LoadDefaultTheme();
        }

        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => base.OnMouseLeftButtonDown(e);

        private void ExpressionDarkMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            //LoadExpressionDarkTheme();
        }

        private void ExpressionLightMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            //  LoadExpressionLightTheme();
        }

        private void OpenFile()
        {
            var openDialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "(*.mp3)|*.mp3"
            };
            if (openDialog.ShowDialog() == true)
            {
                NAudioSimpleEngine.Instance.OpenFile(openDialog.FileName);
                //FileText.SetCurrentValue(TextBox.TextProperty, openDialog.FileName);
                RunnerText.SetCurrentValue(ContentProperty, openDialog.FileName);
            }
        }

        private void OpenFileMenuItem_Click(object sender, RoutedEventArgs e) => OpenFile();

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            if (NAudioSimpleEngine.Instance.CanPause)
            {
                NAudioSimpleEngine.Instance.Pause();
            }
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (NAudioSimpleEngine.Instance.CanPlay)
            {
                NAudioSimpleEngine.Instance.Play();
            }
        }

        // Begin dragging the window
        private void PlayListView_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListBox).SelectedItem;
            if (item != null)
            {
                if (NAudioSimpleEngine.Instance.CanStop)
                {
                    NAudioSimpleEngine.Instance.Stop();
                }

                var path = (item as TextBlock).Text;
                NAudioSimpleEngine.Instance.OpenFile(path);
                //FileText.SetCurrentValue(TextBox.TextProperty, openDialog.FileName);
                NAudioSimpleEngine.Instance.Play();
            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if (NAudioSimpleEngine.Instance.CanStop)
            {
                NAudioSimpleEngine.Instance.Stop();
            }
        }

        /// <summary>
        /// convert a file to wav to preview it.
        /// </summary>
        /// <param name="path"></param>
        public void TempConvertToWemWav(string path)
        {
            var ManagerCacheDir = Path.Combine(ISettingsManager.GetTemp_AudioPath());

            //Clean directory
            Directory.CreateDirectory(ManagerCacheDir);

            foreach (var f in Directory.GetFiles(ManagerCacheDir))
            {
                try
                {
                    File.Delete(f);
                }
                catch
                {
                }
            }

            var outf = Path.Combine(ManagerCacheDir, Path.GetFileNameWithoutExtension(path) + ".wav");
            Trace.WriteLine(outf);
            Trace.WriteLine(path);

            var arg = path.ToEscapedPath() + " -o " + outf.ToEscapedPath();
            var p = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lib", "vgmstream", "test.exe");
            var si = new ProcessStartInfo(
                    p,
                    arg
                )
            {
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                Verb = "runas"
            };
            var proc = Process.Start(si);
            proc.WaitForExit();
            Trace.WriteLine(proc.StandardOutput.ReadToEnd());

            mediaPlayer.Open(new Uri(outf));

            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += Timer_Tick;

            timer.Start();

            var ChannelPositionTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(1)
            };
            ChannelPositionTimer.Tick += ChannelPositionTimer_Tick;
            ;

            ChannelPositionTimer.Start();

            //ChannelLength = $"{mediaPlayer.Position.TotalMinutes} : {mediaPlayer.Position.TotalSeconds} : {mediaPlayer.Position.TotalMilliseconds}";
            NAudioSimpleEngine.Instance.OpenFile(outf);
            RunnerText.SetCurrentValue(ContentProperty, Path.GetFileNameWithoutExtension(outf));


            //AudioFileList.Add(lvi);
        }


        /// <summary>
        /// property changed for naudio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NAudioEngine_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "ChannelPosition":
                    clockDisplay.SetCurrentValue(DigitalClock.TimeProperty, TimeSpan.FromSeconds(NAudioSimpleEngine.Instance.ChannelPosition));
                    break;

                default:
                    // Do Nothing
                    break;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer.Source != null)
            {
                clockDisplay.SetCurrentValue(DigitalClock.TimeProperty, mediaPlayer.Position);
            }
            else
            {
                //AudioPositionText = "No file selected...";
            }
        }

        private void ChannelPositionTimer_Tick(object sender, EventArgs e) => NAudioSimpleEngine.Instance.ChannelPosition = mediaPlayer.Position.TotalSeconds;

        private void PlayButton_Click_1(object sender, RoutedEventArgs e)
        {
            //Call Stop Playing if the media player is at the end of the track
            if (mediaPlayer.Position >= mediaPlayer.NaturalDuration.TimeSpan)
            {
                mediaPlayer.Stop();
                mediaPlayer.Position = new TimeSpan(0);
            }

            mediaPlayer.Play();
        }

        private void PauseButton_Click_1(object sender, RoutedEventArgs e) => mediaPlayer.Pause();

        private void StopButton_Click_1(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
            mediaPlayer.Position = new TimeSpan(0);
        }

        #endregion AudioPreview

        private void CopyMenuItem_Click(object sender, RoutedEventArgs e) => Clipboard.SetText((DataContext as PropertiesViewModel).PE_SelectedItem.FullName);
    }
}
