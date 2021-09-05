using System.Windows;
using System.Windows.Controls;
using WolvenKit.ViewModels.Documents;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.Functionality.Layout
{
    /// <summary>
    /// Implements a <see ref="DataTemplateSelector"/> for AvalonDock's documents and toolwindows.
    ///
    /// One instance of this class is usually initialized in XAML and it returns
    /// a view for a specific given type of viewmodel.
    /// </summary>
    internal class PanesTemplateSelector : DataTemplateSelector
    {
        #region Constructors

        /// <summary>
        /// Default class constructor.
        /// </summary>
        public PanesTemplateSelector()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets/sets the view instance of the AnimationTool.
        /// </summary>
        public DataTemplate AnimationToolTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the WccTool.
        /// </summary>
        public DataTemplate AnimsViewTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the AssetBrowser.
        /// </summary>
        public DataTemplate AssetBrowserTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the AudioTool.
        /// </summary>
        public DataTemplate AudioToolTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the BulkEditor.
        /// </summary>
        public DataTemplate BulkEditorTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the CodeEditor.
        /// </summary>
        public DataTemplate CodeEditorTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the CR2WEditor.
        /// </summary>
        public DataTemplate CR2WEditorTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the CR2WToTextTool.
        /// </summary>
        public DataTemplate CR2WToTextToolTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the CsvEditor.
        /// </summary>
        public DataTemplate CsvEditorTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the file document.
        /// </summary>
        public DataTemplate FileViewTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the GameDebuggerTool.
        /// </summary>
        public DataTemplate GameDebuggerToolTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the HexEditor.
        /// </summary>
        public DataTemplate HexEditorTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the ImporterTool.
        /// </summary>
        public DataTemplate ImporterToolTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the JournalEditor.
        /// </summary>
        public DataTemplate JournalEditorTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the LogView.
        /// </summary>
        public DataTemplate LogViewTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the MenuTool.
        /// </summary>
        public DataTemplate MenuToolTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the WccTool.
        /// </summary>
        public DataTemplate MimicsViewTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the PluginManager.
        /// </summary>
        public DataTemplate PluginManagerTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the ProjectExplorerView.
        /// </summary>
        public DataTemplate ProjectExplorerTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the Properties.
        /// </summary>
        public DataTemplate PropertiesTemplate { get; set; }
        public DataTemplate ImportExportToolTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the RadishTool.
        /// </summary>
        public DataTemplate RadishToolTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the VisualEditor.
        /// </summary>
        public DataTemplate VisualEditorTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the WccTool.
        /// </summary>
        public DataTemplate WccToolTemplate { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines the matching view for a specific given type of viewmodel.
        /// </summary>
        /// <param name="item">Identifies the viewmodel object for which we require an associated view.</param>
        /// <param name="container">Identifies the container's instance that wants to resolve this association.</param>
        public override System.Windows.DataTemplate SelectTemplate(object item, System.Windows.DependencyObject container) => item switch
        {
            IDocumentViewModel _ => FileViewTemplate,
            PropertiesViewModel _ => PropertiesTemplate,
            LogViewModel _ => LogViewTemplate,
            ProjectExplorerViewModel _ => ProjectExplorerTemplate,
            AssetBrowserViewModel _ => AssetBrowserTemplate,
            ImportExportViewModel _ => ImportExportToolTemplate,

            CodeEditorViewModel _ => CodeEditorTemplate,
            VisualEditorViewModel _ => VisualEditorTemplate,


            _ => base.SelectTemplate(item, container)
        };

        #endregion Methods
    }
}
