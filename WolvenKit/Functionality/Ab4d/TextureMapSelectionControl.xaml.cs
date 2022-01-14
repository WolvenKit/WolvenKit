using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Ab3d.DirectX;
using Ab3d.DirectX.Materials;
using SharpDX.Direct3D;
using MessageBox = System.Windows.MessageBox;
using UserControl = System.Windows.Controls.UserControl;

namespace WolvenKit.Functionality.Ab4d
{
    /// <summary>
    /// Interaction logic for TextureMapSelectionControl.xaml
    /// </summary>
    public partial class TextureMapSelectionControl : UserControl
    {
        private PhysicallyBasedMaterial _physicallyBasedMaterial;

        private TextureMapInfo _textureMapInfo;
        private bool _showTextureTextBox;
        private bool _showFilter;
        private bool _showMask;
        private Color _currentMaskColor;
        private float _currentFilterValue;

        public IMultiMapMaterial Material { get; private set; }

        public TextureMapTypes TextureMapType { get; private set; }

        // If you want that the ShaderResourceView is loaded in this control, then you need to set the DXDevice
        public DXDevice DXDevice { get; set; }


        public bool ShowTextureTextBox
        {
            get => _showTextureTextBox;
            set
            {
                _showTextureTextBox = value;
                TextureGrid.SetCurrentValue(VisibilityProperty, value ? Visibility.Visible : Visibility.Hidden);

                if (!value)
                {
                    TextureCheckBox.SetCurrentValue(System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, false);
                }
            }
        }

        public bool ShowFilter
        {
            get => _showFilter;
            set
            {
                _showFilter = value;

                if (value)
                {
                    FilterSlider.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    FilterValueTextBlock.SetCurrentValue(VisibilityProperty, Visibility.Visible);

                    UpdateShownFilterValue();
                }
                else
                {
                    FilterSlider.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    FilterValueTextBlock.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                }

                ShowMask = false;
            }
        }

        public bool ShowMask
        {
            get => _showMask;
            set
            {
                _showMask = value;

                if (value)
                {
                    MaskHeadingTextBlock.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    MaskTextBox.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                    MaskColorRectangle.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                }
                else
                {
                    MaskHeadingTextBlock.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    MaskTextBox.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                    MaskColorRectangle.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
                }
            }
        }

        public float CurrentFilterValue
        {
            get => _currentFilterValue;
            set
            {
                _currentFilterValue = value;

                FilterSlider.SetValue(System.Windows.Controls.Primitives.RangeBase.ValueProperty, (double)value);
                UpdateShownFilterValue();
            }
        }

        public Color CurrentMaskColor
        {
            get => _currentMaskColor;
            set
            {
                _currentMaskColor = value;

                MaskColorRectangle.SetCurrentValue(Shape.FillProperty, new SolidColorBrush(CurrentMaskColor));
                MaskTextBox.SetCurrentValue(TextBox.TextProperty, string.Format("{0:X2}{1:X2}{2:X2}", CurrentMaskColor.R, CurrentMaskColor.G, CurrentMaskColor.B));
            }
        }


        public string BaseFolder { get; set; }

        public event EventHandler MapSettingsChanged;


        public TextureMapSelectionControl(IMultiMapMaterial material, TextureMapTypes textureMapType, string baseFolder = null)
        {
            Material = material;
            _physicallyBasedMaterial = material as PhysicallyBasedMaterial;

            TextureMapType = textureMapType;

            if (baseFolder != null && !baseFolder.EndsWith("\\") && !baseFolder.EndsWith("/"))
            {
                baseFolder += '\\';
            }

            BaseFolder = baseFolder;

            _textureMapInfo = Material.TextureMaps.FirstOrDefault(m => m.MapType == TextureMapType);


            InitializeComponent();

            ShowTextureTextBox = true;



            if (_physicallyBasedMaterial != null)
            {
                ShowFilter = textureMapType == TextureMapTypes.Metalness ||
                             textureMapType == TextureMapTypes.Glossiness ||
                             textureMapType == TextureMapTypes.Roughness ||
                             textureMapType == TextureMapTypes.MetalnessRoughness ||
                             textureMapType == TextureMapTypes.AmbientOcclusion;

                ShowMask = textureMapType == TextureMapTypes.Albedo ||
                           textureMapType == TextureMapTypes.BaseColor ||
                           textureMapType == TextureMapTypes.DiffuseColor;

                if (textureMapType == TextureMapTypes.Metalness || textureMapType == TextureMapTypes.MetalnessRoughness)
                {
                    CurrentFilterValue = _physicallyBasedMaterial.Metalness;
                }

                if (textureMapType == TextureMapTypes.Roughness || textureMapType == TextureMapTypes.MetalnessRoughness)
                {
                    CurrentFilterValue = _physicallyBasedMaterial.Roughness;
                }

                if (ShowMask)
                {
                    CurrentMaskColor = _physicallyBasedMaterial.BaseColor.ToWpfColor();
                }
            }
            else
            {
                ShowFilter = false;
                ShowMask = false;
            }

            // To add support for drop into TextBox, we need to use PreviewDrop and PreviewDragOver events in DragAndDropHelper
            //var dragAndDropHelper = new DragAndDropHelper(FileNameTextBox, ".*");
            //dragAndDropHelper.FileDroped += delegate (object sender, FileDroppedEventArgs e)
            //{
            //    FileNameTextBox.Text = e.FileName;
            //    MasterCheckBox.IsChecked = true;

            //    LoadCurrentTexture();
            //};


            MapTypeTextBlock.Text = textureMapType.ToString();

            if (_textureMapInfo == null)
            {
                FileNameTextBox.Text = "";
                TextureCheckBox.IsChecked = false;
            }
            else
            {
                if (BaseFolder != null && _textureMapInfo.TextureResourceName.StartsWith(BaseFolder))
                {
                    FileNameTextBox.Text = _textureMapInfo.TextureResourceName.Substring(BaseFolder.Length);
                }
                else
                {
                    FileNameTextBox.Text = _textureMapInfo.TextureResourceName;
                }

                TextureCheckBox.IsChecked = true;
            }

            UpdateMaskHeadingTextBlock();
        }


        private void LoadCurrentTexture()
        {
            if (DXDevice == null)
            {
                return;
            }

            var hasChanges = false;


            if (_textureMapInfo != null)
            {
                if (_textureMapInfo.ShaderResourceView != null)
                {
                    _textureMapInfo.ShaderResourceView.Dispose();
                }

                if (_textureMapInfo.SamplerState != null)
                {
                    _textureMapInfo.SamplerState.Dispose();
                }

                Material.TextureMaps.Remove(_textureMapInfo);

                _textureMapInfo = null;

                hasChanges = true;
            }

            FileNameTextBox.ClearValue(ForegroundProperty);
            FileNameTextBox.SetCurrentValue(ToolTipProperty, null);


            if (TextureCheckBox.IsChecked ?? false)
            {
                var fileName = FileNameTextBox.Text;

                if (!string.IsNullOrEmpty(fileName))
                {
                    if (BaseFolder != null && !System.IO.Path.IsPathRooted(fileName))
                    {
                        fileName = System.IO.Path.Combine(BaseFolder, fileName);
                    }

                    if (!System.IO.File.Exists(fileName))
                    {
                        FileNameTextBox.SetCurrentValue(ForegroundProperty, Brushes.Red);
                        FileNameTextBox.SetCurrentValue(ToolTipProperty, fileName + " does not exist!");
                        return;
                    }


                    var isBaseColor = (TextureMapType == TextureMapTypes.BaseColor ||
                                       TextureMapType == TextureMapTypes.Albedo ||
                                       TextureMapType == TextureMapTypes.DiffuseColor);

                    // To load a texture from file, you can use the TextureLoader.LoadShaderResourceView (this supports loading standard image files and also loading dds files).
                    // This method returns a ShaderResourceView and it can also set a textureInfo parameter that defines some of the properties of the loaded texture (bitmap size, dpi, format, hasTransparency).
                    var shaderResourceView = Ab3d.DirectX.TextureLoader.LoadShaderResourceView(DXDevice.Device,
                                                                                               fileName,
                                                                                               loadDdsIfPresent: true,
                                                                                               convertTo32bppPRGBA: isBaseColor,
                                                                                               generateMipMaps: true,
                                                                                               textureInfo: out var textureInfo);

                    // Only 2D textures are supported
                    if (shaderResourceView.Description.Dimension != ShaderResourceViewDimension.Texture2D)
                    {
                        MessageBox.Show("Invalid texture dimension: " + shaderResourceView.Description.Dimension.ToString());
                        TextureCheckBox.SetCurrentValue(System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, false);

                        return;
                    }

                    _textureMapInfo = new TextureMapInfo(TextureMapType, shaderResourceView, null, fileName);
                    Material.TextureMaps.Add(_textureMapInfo);


                    var physicallyBasedMaterial = Material as PhysicallyBasedMaterial;
                    if (isBaseColor && physicallyBasedMaterial != null)
                    {
                        // Get recommended BlendState based on HasTransparency and HasPreMultipliedAlpha values.
                        // Possible values are: CommonStates.Opaque, CommonStates.PremultipliedAlphaBlend or CommonStates.NonPremultipliedAlphaBlend.
                        var recommendedBlendState = DXDevice.CommonStates.GetRecommendedBlendState(textureInfo.HasTransparency, textureInfo.HasPremultipliedAlpha);

                        physicallyBasedMaterial.BlendState = recommendedBlendState;
                        physicallyBasedMaterial.HasTransparency = textureInfo.HasTransparency;
                    }


                    if (CurrentMaskColor == Colors.Black)
                    {
                        CurrentMaskColor = Colors.White;
                    }

                    if (CurrentFilterValue <= 0.01)
                    {
                        CurrentFilterValue = 1.0f;
                    }

                    hasChanges = true;
                }
            }


            if (hasChanges)
            {
                OnMapSettingsChanged();
            }
        }

        private void OpenFileButton_OnClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "All texture files (*.*)|*.*",
                Title = "Select texture file"
            };

            if (!string.IsNullOrEmpty(BaseFolder) && System.IO.Directory.Exists(BaseFolder))
            {
                openFileDialog.InitialDirectory = BaseFolder;
            }

            if ((openFileDialog.ShowDialog() ?? false) && !string.IsNullOrEmpty(openFileDialog.FileName))
            {
                TextureCheckBox.SetCurrentValue(System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, true);
                FileNameTextBox.SetCurrentValue(TextBox.TextProperty, openFileDialog.FileName);

                LoadCurrentTexture();
            }
        }

        protected void OnMapSettingsChanged()
        {
            if (MapSettingsChanged != null)
            {
                MapSettingsChanged(this, null);
            }
        }

        private void OnTextureCheckBoxCheckedChanged(object sender, RoutedEventArgs e)
        {
            if (!IsLoaded)
            {
                return;
            }

            LoadCurrentTexture();

            UpdateMaskHeadingTextBlock();
        }

        private void UpdateMaskHeadingTextBlock()
        {
            if (TextureCheckBox.IsChecked ?? false)
            {
                MaskHeadingTextBlock.SetCurrentValue(TextBlock.TextProperty, "Mask: #");
            }
            else
            {
                MaskHeadingTextBlock.SetCurrentValue(TextBlock.TextProperty, "Color: #");
            }
        }

        private void UpdateShownFilterValue()
        {
            FilterValueTextBlock.SetCurrentValue(TextBlock.TextProperty, string.Format("{0:0}%", FilterSlider.Value * 100));

            OnMapSettingsChanged();
        }

        private void FilterSlider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (!IsLoaded)
            {
                return;
            }

            CurrentFilterValue = (float)FilterSlider.Value;
            UpdateShownFilterValue();

            if (_physicallyBasedMaterial != null)
            {
                if (TextureMapType == TextureMapTypes.Metalness || TextureMapType == TextureMapTypes.MetalnessRoughness)
                {
                    _physicallyBasedMaterial.Metalness = CurrentFilterValue;
                }

                if (TextureMapType == TextureMapTypes.Roughness || TextureMapType == TextureMapTypes.MetalnessRoughness)
                {
                    _physicallyBasedMaterial.Roughness = CurrentFilterValue;
                }

                if (TextureMapType == TextureMapTypes.AmbientOcclusion)
                {
                    _physicallyBasedMaterial.AmbientOcclusionFactor = CurrentFilterValue;
                }

                OnMapSettingsChanged();
            }
        }

        private void MaskTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var isMaskValid = false;

            try
            {
                // Usinig color converter is not a good solution because in case of an invalid text it throws an exception
                // and this moves focus from sample application into Visual Studio
                //if (_colorConverter == null)
                //    _colorConverter = System.ComponentModel.TypeDescriptor.GetConverter(typeof(Color));
                //
                //CurrentMaskColor = (Color)_colorConverter.ConvertFromString(MaskTextBox.Text);

                var maskText = MaskTextBox.Text.Trim();
                if (maskText.Length == 6)
                {
                    var red = HexToByte(maskText, 0);
                    var green = HexToByte(maskText, 2);
                    var blue = HexToByte(maskText, 4);

                    if (red != -1 && green != -1 && blue != -1)
                    {
                        CurrentMaskColor = Color.FromRgb((byte)red, (byte)green, (byte)blue);
                        MaskColorRectangle.SetCurrentValue(Shape.FillProperty, new SolidColorBrush(CurrentMaskColor));

                        isMaskValid = true;
                    }
                }
            }
            catch
            {
                isMaskValid = false;
            }

            if (isMaskValid)
            {
                MaskTextBox.ClearValue(ForegroundProperty);

                if (_physicallyBasedMaterial != null)
                {
                    if (TextureMapType == TextureMapTypes.Albedo || TextureMapType == TextureMapTypes.BaseColor || TextureMapType == TextureMapTypes.DiffuseColor)
                    {
                        _physicallyBasedMaterial.BaseColor = CurrentMaskColor.ToColor4();
                    }

                    OnMapSettingsChanged();
                }

                OnMapSettingsChanged();
            }
            else
            {
                MaskTextBox.SetCurrentValue(ForegroundProperty, Brushes.Red);
            }
        }

        // Returns -1 if not valid
        private int HexCharToInt(string text, int index)
        {
            if (index >= text.Length)
            {
                return -1;
            }

            var ch = text[index];

            if (ch >= '0' && ch <= '9')
            {
                return ch - '0';
            }

            if (ch >= 'A' && ch <= 'F')
            {
                return ch - 'A' + 10;
            }

            if (ch >= 'a' && ch <= 'f')
            {
                return ch - 'a' + 10;
            }

            return -1;
        }

        // Returns -1 if not valid
        private int HexToByte(string text, int index)
        {
            var v1 = HexCharToInt(text, index);
            var v2 = HexCharToInt(text, index + 1);

            if (v1 == -1 || v2 == -1)
            {
                return -1;
            }

            return v1 * 16 + v2;
        }
    }
}
