using System.Windows;
using System.Windows.Controls;
using Ab3d.Assimp;
using Assimp;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.Editor
{
    /// <summary>
    /// Interaction logic for ProjectExplorerView.xaml
    /// </summary>
    public partial class ProjectExplorerView
    {
        #region Constructors
        private ExportFormatDescription[] _exportFormatDescriptions;

        public ProjectExplorerView()
        {
            InitializeComponent();
            AssimpLoader.LoadAssimpNativeLibrary();


            var assimpWpfExporter = new AssimpWpfExporter();
            _exportFormatDescriptions = assimpWpfExporter.ExportFormatDescriptions;

            for (int i = 0; i < _exportFormatDescriptions.Length; i++)
            {
                var comboBoxItem = new ComboBoxItem()
                {
                    Content = string.Format("{0} (.{1})", _exportFormatDescriptions[i].Description, _exportFormatDescriptions[i].FileExtension),
                    Tag = _exportFormatDescriptions[i].FormatId
                };

                meshxport.Items.Add(comboBoxItem);
            }
            //ControlzEx.Theming.ThemeManager.Current.ChangeTheme(this, "Dark.Blue");
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Project Explorer");
            }
        }

        #endregion Methods

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
        }
        private string _selectedExportFormatId;

        private void meshxport_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int exportTypeIndex = meshxport.SelectedIndex;

            if (exportTypeIndex == -1)
                return;

            var selectedFileExtension = _exportFormatDescriptions[exportTypeIndex].FileExtension;

            _selectedExportFormatId = _exportFormatDescriptions[exportTypeIndex].FormatId;

        }
    }
}
