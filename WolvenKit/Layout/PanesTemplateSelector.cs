using AvalonDock.Layout;

namespace WolvenKit.Layout
{
	using System.Windows.Controls;
	using System.Windows;
	using ViewModels;
    using WolvenKit.Views.AssetBrowser;
    using WolvenKit.ViewModels.AssetBrowser;
    using WolvenKit.ViewModels.CodeEditor;
    using WolvenKit.ViewModels.CsvEditor;
    using WolvenKit.ViewModels.HexEditor;
    using WolvenKit.ViewModels.AudioTool;
    using WolvenKit.ViewModels.VisualEditor;
    using WolvenKit.ViewModels.JournalEditor;
    using WolvenKit.ViewModels.WccTool;
    using WolvenKit.ViewModels.RadishTool;
    using WolvenKit.ViewModels.CR2WToTextTool;
    using WolvenKit.ViewModels.GameDebuggerTool;
    using WolvenKit.ViewModels.PluginManager;
    using WolvenKit.ViewModels.ImporterTool;
    using WolvenKit.ViewModels.Tools.MenuTool;

    /// <summary>
    /// Implements a <see ref="DataTemplateSelector"/> for AvalonDock's documents and toolwindows.
    ///
    /// One instance of this class is usually initialized in XAML and it returns
    /// a view for a specific given type of viewmodel.
    /// </summary>
    internal class PanesTemplateSelector : DataTemplateSelector
	{
		/// <summary>
		/// Default class constructor.
		/// </summary>
		public PanesTemplateSelector()
		{
		}

		/// <summary>
		/// Gets/sets the view instance of the file document.
		/// </summary>
		public DataTemplate FileViewTemplate { get; set; }

		/// <summary>
		/// Gets/sets the view instance of the LogView.
		/// </summary>
		public DataTemplate LogViewTemplate { get; set; }

		/// <summary>
		/// Gets/sets the view instance of the ProjectExplorerView.
		/// </summary>
		public DataTemplate ProjectExplorerTemplate { get; set; }


        /// <summary>
        /// Gets/sets the view instance of the AssetBrowser.
        /// </summary>
        public DataTemplate AssetBrowserTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the CodeEditor.
        /// </summary>
        public DataTemplate CodeEditorTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the BulkEditor.
        /// </summary>
        public DataTemplate BulkEditorTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the CsvEditor.
        /// </summary>
        public DataTemplate CsvEditorTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the HexEditor.
        /// </summary>
        public DataTemplate HexEditorTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the JournalEditor.
        /// </summary>
        public DataTemplate JournalEditorTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the AnimationTool.
        /// </summary>
        public DataTemplate AnimationToolTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the AudioTool.
        /// </summary>
        public DataTemplate AudioToolTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the CR2WToTextTool.
        /// </summary>
        public DataTemplate CR2WToTextToolTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the GameDebuggerTool.
        /// </summary>
        public DataTemplate GameDebuggerToolTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the ImporterTool.
        /// </summary>
        public DataTemplate ImporterToolTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the MenuTool.
        /// </summary>
        public DataTemplate MenuToolTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the PluginManager.
        /// </summary>
        public DataTemplate PluginManagerTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the RadishTool.
        /// </summary>
        public DataTemplate RadishToolTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the WccTool.
        /// </summary>
        public DataTemplate WccToolTemplate { get; set; }

        /// <summary>
        /// Gets/sets the view instance of the VisualEditor.
        /// </summary>
        public DataTemplate VisualEditorTemplate { get; set; }


        /// <summary>
        /// Determines the matching view for a specific given type of viewmodel.
        /// </summary>
        /// <param name="item">Identifies the viewmodel object for which we require an associated view.</param>
        /// <param name="container">Identifies the container's instance that wants to resolve this association.</param>
        public override System.Windows.DataTemplate SelectTemplate(object item,
																   System.Windows.DependencyObject container)
        {
            return item switch
            {               // AnimationToolViewModel _ => AssetBrowserTemplate,

                IDocumentViewModel _ => FileViewTemplate,
                LogViewModel _ => LogViewTemplate,
                ProjectExplorerViewModel _ => ProjectExplorerTemplate,
                AssetBrowserViewModel _ => AssetBrowserTemplate,
                WolvenKit.ViewModels.BulkEditor.BulkEditorViewModel _ => BulkEditorTemplate,
                CodeEditorViewModel _ => CodeEditorTemplate,
                CsvEditorViewModel _ => CsvEditorTemplate,
                HexEditorViewModel _ => HexEditorTemplate,
                JournalEditorViewModel _ => JournalEditorTemplate,
                VisualEditorViewModel _ => VisualEditorTemplate,
                AudioToolViewModel _ => AudioToolTemplate,
                CR2WToTextToolViewModel _ => CR2WToTextToolTemplate,
                GameDebuggerToolViewModel _ => GameDebuggerToolTemplate,
                ImporterToolViewModel _ => ImporterToolTemplate,
                MenuCreatorToolViewModel _ => MenuToolTemplate,
                PluginManagerViewModel _ => PluginManagerTemplate,
                RadishToolViewModel _ => RadishToolTemplate,
                WccToolViewModel _ => WccToolTemplate,

                _ => base.SelectTemplate(item, container)
            };
        }
	}
}
