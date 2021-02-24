using Catel.MVVM;
using SharpVectors.Converters;
using SharpVectors.Renderers.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WolvenKit.ViewModels;
using WolvenKit.Views.AnimationTool;
using WolvenKit.Views.BulkEditor;
using WolvenKit.Views.CR2WToTextTool;
using WolvenKit.Views.CsvEditor;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.EditorBars;
using WolvenKit.Views.GameDebuggerTool;
using WolvenKit.Views.ImporterTool;
using WolvenKit.Views.JournalEditor;
using WolvenKit.Views.RadishTool;
using WolvenKit.Views.Tools.MenuTool;
using WolvenKit.Views.WccTool;
using WolvenKit.Views.Wizards;


namespace WolvenKit.ViewModels.HomePage.Pages
{
    public class DebugPageViewModel : ViewModelBase
    {
        public static ObservableCollection<UserControl> _DialogsUC = new ObservableCollection<UserControl>();
        public static ObservableCollection<UserControl> _WizardsUC = new ObservableCollection<UserControl>();
        public static ObservableCollection<UserControl> _ToolsUC = new ObservableCollection<UserControl>();
        public static ObservableCollection<UserControl> _EditorsUC = new ObservableCollection<UserControl>();




        public ObservableCollection<UserControl> DialogsUC { get { return _DialogsUC; } }
        public ObservableCollection<UserControl> WizardsUC { get { return _WizardsUC; } }
        public ObservableCollection<UserControl> ToolsUC { get { return _ToolsUC; } }
        public ObservableCollection<UserControl> EditorsUC { get { return _EditorsUC; } }

        public DebugPageViewModel() { InitThis(); }

     

        public void InitThis()
        {
            _DialogsUC.Add(new AddChunkDialog());
            _DialogsUC.Add(new ExtractAmbigiousDialog());
            _DialogsUC.Add(new RenameDialog());
            _DialogsUC.Add(new StringsGUIImporterIDDialog());
            _DialogsUC.Add(new StringsGuiScriptsPrefixDialog());
            _EditorsUC.Add(new BulkEditorView());
            _EditorsUC.Add(new CsvEditorView());
            _EditorsUC.Add(new ArrayEditorView());
            _EditorsUC.Add(new ByteArrayEditorView());
            _EditorsUC.Add(new IdTagEditorView());
            _EditorsUC.Add(new PtrEditorView());
            _EditorsUC.Add(new JournalEditorView());
            _ToolsUC.Add(new AnimsView());
            _ToolsUC.Add(new MimicsView());
            _ToolsUC.Add(new CR2WToTextToolView());
            _ToolsUC.Add(new GameDebuggerToolView());
            _ToolsUC.Add(new ImporterToolView());
            _ToolsUC.Add(new MenuCreatorToolView());
            _ToolsUC.Add(new RadishToolView());
            _ToolsUC.Add(new WccToolView());
        }
    }
}
