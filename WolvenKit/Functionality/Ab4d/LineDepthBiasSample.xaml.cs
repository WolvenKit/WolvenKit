using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using Ab3d.Cameras;
using Ab3d.Common.Cameras;
using Ab3d.Controls;
using Ab3d.DirectX;
using Ab3d.DirectX.Controls;
using Ab3d.DirectX.Materials;
using Ab3d.DirectX.Models;
using Ab3d.Visuals;

namespace WolvenKit.Functionality.Ab4d
{
    /// <summary>
    /// Interaction logic for LineDepthBiasSample.xaml
    /// </summary>
    public partial class LineDepthBiasSample : Page
    {
        //private MultiLineVisual3D _multiLineVisual3D;

        private double _previousCameraDistance;

        private Model3D _sampleModel;

        private BaseVisual3D _shownLineVisual3D;

        private Viewport3D _customViewport3D;
        private DXViewportView _customDXViewportView;
        private TargetPositionCamera _customCamera;

        private DisposeList _disposables;

        // This sample shows how to prevent problems when 3D lines are rendered on top of 3D solid models.
        // In this case the lines can appear broken because they are rendered at the same 3D position as a solid model - a problem know as z-fighting.
        // The standard way to solve this problem is by applying a so called depth bias.
        //
        // This cannot be done with WPF 3D rendering, but line rendering in DXEngine supports that.
        //
        // The easiest way to set depth bias is to use the following code:
        // lineVisual3D.SetDXAttribute(DXAttributeType.LineDepthBias, depthBias);
        //
        // In this case the lineVisual3D will be moved for the depthBias amount (in world coordinates) closer to the camera.
        // This calculation is done in the vertex shader so this works for any camera orientation.
        //
        // The LineDepthBias attribute can be applied for all Visual3D objects from Ab3d.PowerToys library that show 3D lines
        // (LineVisual3D, MultiLineVisual3D, PolyLineVisual3D, WireframeVisual3D, etc.)
        //
        // Note that the scene is big (camera distance is big) then a bigger depth bias is needed.
        // For example:
        // When this sample is rendered with sphere with radius 10, the DepthBias 0.01 works well.
        // But when the sphere's radius is 1000, the 0.01 is not enough. In this case DepthBias 1 is needed.

        public LineDepthBiasSample()
        {
            InitializeComponent();


            SphereRadiusComboBox.ItemsSource = new double[] { 1, 10, 100, 1000 };
            SphereRadiusComboBox.SelectedItem = 100.0;

            DepthBiasComboBox.ItemsSource = new double[] { 0, 0.001, 0.005, 0.01, 0.05, 0.1, 0.5, 1.0, 5.0, 10.0 };
            DepthBiasComboBox.SelectedItem = 0.1;


            _disposables = new DisposeList();

            CreateAllScenes();

            RadiusInfoControl.InfoText =
@"This ComboBox changes the radius of the sphere on the left.
Because the camera distance is also adjusted, it looks
like the sphere is still the same size though the size has changed.

The size change can be seen with checking the 3D lines that
may appear too distance from the solid object or disconnected
because of z-fighting.

This shows that different object sizes require different bias values.";

            Unloaded += delegate (object sender, RoutedEventArgs args)
            {
                if (_disposables != null)
                {
                    _disposables.Dispose();
                    _disposables = null;
                }
            };
        }

        private void CreateAllScenes()
        {
            AddNewDXViewportView(RootGrid, rowIndex: 0, columnIndex: 1, sphereRadius: 100, depthBias: 0.0, createDXEngine: false, title: "WPF");
            AddNewDXViewportView(RootGrid, rowIndex: 0, columnIndex: 2, sphereRadius: 100, depthBias: 0.0, createDXEngine: true, title: "DXEngine\r\nNo bias");
            AddNewDXViewportView(RootGrid, rowIndex: 1, columnIndex: 1, sphereRadius: 100, depthBias: 0.2, createDXEngine: true, title: "DXEngine - correct bias\r\nRadius 100; Bias: 0.2");
            AddNewDXViewportView(RootGrid, rowIndex: 1, columnIndex: 2, sphereRadius: 1000, depthBias: 2.0, createDXEngine: true, title: "DXEngine - correct bias\r\nRadius 1000; Bias: 2.0\r\nbigger object => bigger bias");
            AddNewDXViewportView(RootGrid, rowIndex: 2, columnIndex: 1, sphereRadius: 10, depthBias: 2.0, createDXEngine: true, title: "DXEngine - too big bias\r\nRadius 10; Bias: 2.0");
            AddNewDXViewportView(RootGrid, rowIndex: 2, columnIndex: 2, sphereRadius: 1000, depthBias: 0.1, createDXEngine: true, title: "DXEngine - too small bias\r\nRadius 1000; Bias: 0.1");

            Border createdBorder;
            AddNewDXViewportView(RootGrid, rowIndex: 0, columnIndex: 0, sphereRadius: 100, depthBias: 0.1, createDXEngine: true, title: null,
                                 createdBorder: out createdBorder, createdViewport3D: out _customViewport3D, createdDXViewportView: out _customDXViewportView, createdTargetPositionCamera: out _customCamera);

            Grid.SetRowSpan(createdBorder, 3);

            _customCamera.CameraChanged += (sender, args) => CustomCamera_OnCameraChanged(sender, args);

            var mouseCameraController = new Ab3d.Controls.MouseCameraController()
            {
                RotateCameraConditions = MouseCameraController.MouseAndKeyboardConditions.LeftMouseButtonPressed,
                MoveCameraConditions = MouseCameraController.MouseAndKeyboardConditions.LeftMouseButtonPressed | MouseCameraController.MouseAndKeyboardConditions.ControlKey,
                EventsSourceElement = createdBorder,
                TargetCamera = _customCamera
            };

            RootGrid.Children.Add(mouseCameraController);
        }

        private void ClearAllScenes()
        {
            RootGrid.BeginInit();

            for (var i = RootGrid.Children.Count - 1; i >= 0; i--)
            {
                var oneChild = RootGrid.Children[i];

                if (!ReferenceEquals(oneChild, SettingsBorder) && !ReferenceEquals(oneChild, TitleTextBlock))
                    RootGrid.Children.Remove(oneChild);
            }

            RootGrid.EndInit();


            _disposables.Dispose();
            _disposables = new DisposeList();
        }

        private void AddNewDXViewportView(Grid parentGrid, int rowIndex, int columnIndex, double sphereRadius, double depthBias, bool createDXEngine, string title)
        {
            Border createdBorder;
            Viewport3D createdViewport3D;
            DXViewportView createdDXViewportView;
            TargetPositionCamera createdTargetPositionCamera;

            AddNewDXViewportView(parentGrid, rowIndex, columnIndex, sphereRadius, depthBias, createDXEngine, title,
                                 out createdBorder, out createdViewport3D, out createdDXViewportView, out createdTargetPositionCamera);
        }

        private void AddNewDXViewportView(Grid parentGrid, int rowIndex, int columnIndex, double sphereRadius, double depthBias, bool createDXEngine, string title,
                                          out Border createdBorder, out Viewport3D createdViewport3D, out DXViewportView createdDXViewportView, out TargetPositionCamera createdTargetPositionCamera)
        {
            createdBorder = new Border()
            {
                BorderBrush = Brushes.Black,
                BorderThickness = new Thickness(1, 1, 1, 1),
                SnapsToDevicePixels = true
            };


            createdViewport3D = new Viewport3D();

            createdTargetPositionCamera = new TargetPositionCamera()
            {
                Heading = 30,
                Attitude = -20,
                Distance = 200,
                TargetPosition = new Point3D(0, 0, 0),
                ShowCameraLight = ShowCameraLightType.Always,
                TargetViewport3D = createdViewport3D
            };

            bool showSphere = ShowSphereRadioButton.IsChecked ?? false;
            CreateScene(createdViewport3D, sphereRadius, depthBias, createdTargetPositionCamera, showSphere);

            if (createDXEngine)
            {
                createdDXViewportView = new DXViewportView(createdViewport3D)
                {
                    SnapsToDevicePixels = true
                };

                createdBorder.Child = createdDXViewportView;

                _disposables.Add(createdDXViewportView);
            }
            else
            {
                createdBorder.Child = createdViewport3D;
                createdDXViewportView = null;
            }

            Grid.SetRow(createdBorder, rowIndex);
            Grid.SetColumn(createdBorder, columnIndex);

            parentGrid.Children.Add(createdBorder);
            parentGrid.Children.Add(createdTargetPositionCamera);

            if (!string.IsNullOrEmpty(title))
            {
                var textBlock = new TextBlock()
                {
                    Text = title,
                    Foreground = Brushes.Black,
                    FontSize = 12,
                    Margin = new Thickness(10, 5, 5, 5),
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Top
                };

                Grid.SetRow(textBlock, rowIndex);
                Grid.SetColumn(textBlock, columnIndex);

                parentGrid.Children.Add(textBlock);
            }
        }

        private void CreateScene(Viewport3D parentViewport3D, double sphereRadius, double depthBias, TargetPositionCamera targetPositionCamera, bool showSphere)
        {
            parentViewport3D.Children.Clear();

            if (showSphere)
            {
                var sphereVisual3D = new Ab3d.Visuals.SphereVisual3D()
                {
                    CenterPosition = new Point3D(0, 0, 0),
                    Radius = sphereRadius,
                    Segments = 10,
                    Material = new DiffuseMaterial(Brushes.SkyBlue),
                    UseCachedMeshGeometry3D = false // This will create a new MeshGeometry3D and will not use the shared MeshGeometry3D with radius = 1
                };

                parentViewport3D.Children.Add(sphereVisual3D);


                var sphereMesh = ((GeometryModel3D)sphereVisual3D.Content).Geometry as MeshGeometry3D;

                var sphereLinePositions = CollectWireframeLinePositions(sphereMesh);

                var multiLineVisual3D = new Ab3d.Visuals.MultiLineVisual3D()
                {
                    Positions = sphereLinePositions,
                    LineThickness = 0.5,
                    LineColor = Colors.Black,
                };

                // To specify line depth bias to the Ab3d.PowerToys line Visual3D objects,
                // we use SetDXAttribute extension method and use LineDepthBias as DXAttributeType
                // NOTE: This can be used only before the Visual3D is created by DXEngine.
                // If you want to change the line bias after the object has been rendered, use the SetDepthBias method (defined below)
                multiLineVisual3D.SetDXAttribute(DXAttributeType.LineDepthBias, depthBias);

                // It would be also possible to set the depth with changing the DepthBias on the WpfWireframeVisual3DNode.
                // This is done with using the SetDepthBias method
                //SetDepthBias(dxViewportView, wireframeVisual3D, depthBias);


                parentViewport3D.Children.Add(multiLineVisual3D);

                _shownLineVisual3D = multiLineVisual3D;
            }
            else
            {
                if (_sampleModel == null)
                {
                    var readerObj = new Ab3d.ReaderObj();
                    _sampleModel = readerObj.ReadModel3D(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Models\Teapot.obj"), null, new DiffuseMaterial(Brushes.SkyBlue));

                    _sampleModel.Freeze();
                }

                double readObjectRadius = Math.Sqrt(_sampleModel.Bounds.SizeX * _sampleModel.Bounds.SizeX + _sampleModel.Bounds.SizeZ + _sampleModel.Bounds.SizeZ) / 2;
                double scaleFactor = sphereRadius / readObjectRadius;

                var finalModel = new Model3DGroup();
                finalModel.Children.Add(_sampleModel);
                finalModel.Transform = new ScaleTransform3D(scaleFactor, scaleFactor, scaleFactor);
                finalModel.Freeze();

                var wireframeVisual3D = new WireframeVisual3D()
                {
                    OriginalModel = finalModel,
                    WireframeType = WireframeVisual3D.WireframeTypes.WireframeWithOriginalSolidModel,
                    UseModelColor = false,
                    LineColor = Colors.Black,
                    LineThickness = 0.5
                };

                // To specify line depth bias to the WireframeVisual3D,
                // we use SetDXAttribute extension method and use LineDepthBias as DXAttributeType
                wireframeVisual3D.SetDXAttribute(DXAttributeType.LineDepthBias, depthBias);

                // It would be also possible to set the depth with changing the DepthBias on the WpfWireframeVisual3DNode.
                // This is done with using the SetDepthBias method
                //SetDepthBias(dxViewportView, wireframeVisual3D, depthBias);


                parentViewport3D.Children.Add(wireframeVisual3D);

                _shownLineVisual3D = wireframeVisual3D;
            }

            _previousCameraDistance = sphereRadius * 4;
            targetPositionCamera.SetCurrentValue(BaseTargetPositionCamera.DistanceProperty, _previousCameraDistance);
            targetPositionCamera.SetCurrentValue(BaseCamera.OffsetProperty, new Vector3D(0, sphereRadius * 0.4, 0));
        }

        private static Point3DCollection CollectWireframeLinePositions(MeshGeometry3D meshGeometry)
        {
            Point3D p1, p2, p3;

            var meshPositions = meshGeometry.Positions;
            var meshIndices = meshGeometry.TriangleIndices;

            var triangleIndicesCount = meshGeometry.TriangleIndices.Count;

            var linePositions = new Point3DCollection(triangleIndicesCount * 2);

            for (int i = 0; i < triangleIndicesCount; i += 3)
            {
                p1 = meshPositions[meshIndices[i]];
                p2 = meshPositions[meshIndices[i + 1]];
                p3 = meshPositions[meshIndices[i + 2]];

                linePositions.Add(p1);
                linePositions.Add(p2);

                linePositions.Add(p2);
                linePositions.Add(p3);

                linePositions.Add(p3);
                linePositions.Add(p1);
            }

            return linePositions;
        }

        private void SphereRadiusComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!this.IsLoaded)
                return;

            double selectedRadius = (double)SphereRadiusComboBox.SelectedItem;
            double selectedDepthBias = (double)DepthBiasComboBox.SelectedItem;

            bool showSphere = ShowSphereRadioButton.IsChecked ?? false;
            CreateScene(_customViewport3D, selectedRadius, selectedDepthBias, _customCamera, showSphere);

            // With DXEngine v2.0 and newer we can also change the LineDepthBias DXAttribute after the _shownLineVisual3D was already shown
            _shownLineVisual3D.SetDXAttribute(DXAttributeType.LineDepthBias, selectedDepthBias);

            // It would be also possible to set the depth with changing the DepthBias on the WpfWireframeVisual3DNode.
            // This is done with using the SetDepthBias method
            //SetDepthBias(_customDXViewportView, _shownLineVisual3D, selectedDepthBias);

            _customCamera.Refresh(); // This will regenerate the camera light that was removed in the CreateScene: parentViewport3D.Children.Clear();
        }

        private void DepthBiasComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!this.IsLoaded)
                return;

            double selectedDepthBias = (double)DepthBiasComboBox.SelectedItem;

            // With DXEngine v2.0 and newer we can also change the LineDepthBias DXAttribute after the _shownLineVisual3D was already shown
            _shownLineVisual3D.SetDXAttribute(DXAttributeType.LineDepthBias, selectedDepthBias);

            // It would be also possible to set the depth with changing the DepthBias on the WpfWireframeVisual3DNode.
            // This is done with using the SetDepthBias method
            //SetDepthBias(_customDXViewportView, _shownLineVisual3D, selectedDepthBias);
        }

        private void CustomCamera_OnCameraChanged(object sender, CameraChangedRoutedEventArgs e)
        {
            double newCameraDistance = _customCamera.Distance;

            double distanceChangeFactor = newCameraDistance / _previousCameraDistance;
            _previousCameraDistance = newCameraDistance;

            // When custom camera (controller by user) is changed, we also change other cameras
            // But do not change distance (because this is different based on the size of the sphere)
            foreach (var targetPositionCamera in RootGrid.Children.OfType<TargetPositionCamera>())
            {
                if (ReferenceEquals(_customCamera, targetPositionCamera))
                    continue;

                targetPositionCamera.Heading = _customCamera.Heading;
                targetPositionCamera.Attitude = _customCamera.Attitude;
                targetPositionCamera.Distance *= distanceChangeFactor;
            }
        }

        private void ShowSphereRadioButton_OnChecked(object sender, RoutedEventArgs e)
        {
            if (!this.IsLoaded)
                return;

            ClearAllScenes();
            CreateAllScenes();
        }

        private void ShowTeapotRadioButton_OnChecked(object sender, RoutedEventArgs e)
        {
            if (!this.IsLoaded)
                return;

            ClearAllScenes();
            CreateAllScenes();
        }



        // This method can be used to change the depth bias value after the Visual3D (line visual or WireframeVisual3D) has already been rendered by DXEngine (or at least the DXEngine has already initialized the 3D SceneNodes).
        // To set initial line depth bias value, it is much easier to use the the following (see also the CreateScene method above):
        // _multiLineVisual3D.SetDXAttribute(DXAttributeType.LineDepthBias, depthBias);
        public static void SetDepthBias(DXViewportView parentDXViewportView, BaseVisual3D lineVisual3D, double depthBiasValue)
        {
            var lineSceneNode = parentDXViewportView.GetSceneNodeForWpfObject(lineVisual3D);

            if (lineSceneNode == null)
                return;


            // First check if we got WpfWireframeVisual3DNode that is created from WireframeVisual3D
            // This is handled differently then LineVisual3D objects because WpfWireframeVisual3DNode defines the DepthBias property
            var wpfWireframeVisual3DNode = lineSceneNode as WpfWireframeVisual3DNode;
            if (wpfWireframeVisual3DNode != null)
            {
                wpfWireframeVisual3DNode.DepthBias = (float)depthBiasValue;
                return;
            }


            // Handle other 3D lines Visual3D objects:

            // To change the DepthBias we need to get to the used LineMaterial
            // LineMaterial is used on the ScreenSpaceLineNode (in the DXEngine's scene nodes hierarchy).
            // Currently the MultiLineVisual3D is converted into WpfModelVisual3DNode with one ScreenSpaceLineNode set as child.
            // But this might be optimized in the future so that WpfModelVisual3DNode would be converted directly into ScreenSpaceLineNode.
            // Thefore here we check both options:

            var screenSpaceLineNode = lineSceneNode as ScreenSpaceLineNode;

            if (screenSpaceLineNode == null && lineSceneNode.ChildNodesCount == 1)
                screenSpaceLineNode = lineSceneNode.ChildNodes[0] as ScreenSpaceLineNode;


            if (screenSpaceLineNode != null)
            {
                // Get line material
                // The LineMaterial is of type ILineMaterial that does not provide setters for properties
                // Therefore we need to cast that into the actual LineMaterial object
                var lineMaterial = screenSpaceLineNode.LineMaterial as LineMaterial;

                if (lineMaterial != null)
                {
                    lineMaterial.DepthBias = (float)depthBiasValue; // Finally we can set DepthBias

                    // When we change properties on the DXEngine objects, we need to manually notify the DXEngine about the changes
                    // We do that with NotifySceneNodeChange method
                    screenSpaceLineNode.NotifySceneNodeChange(SceneNode.SceneNodeDirtyFlags.MaterialChanged);
                }
            }
        }
    }
}
