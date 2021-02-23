
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Catel.Services;
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

namespace WolvenKit.Views.HomePage.Pages
{
    public partial class DebugPageView
    {
        Dictionary<UserControl, string> AllUC = new Dictionary<UserControl, string>();



        public DebugPageView()
        {
            InitializeComponent();
            AllUC.Add(new AddChunkDialog(), Name);
            AllUC.Add(new ExtractAmbigiousDialog(), Name);
            AllUC.Add(new RenameDialog(), Name);
            AllUC.Add(new StringsGUIImporterIDDialog(), Name);
            AllUC.Add(new StringsGuiScriptsPrefixDialog(), Name);
            AllUC.Add(new BulkEditorView(), Name);
            AllUC.Add(new CsvEditorView(), Name);
            AllUC.Add(new ArrayEditorView(), Name);
            AllUC.Add(new ByteArrayEditorView(), Name);
            AllUC.Add(new IdTagEditorView(), Name);
            AllUC.Add(new PtrEditorView(), Name);
            AllUC.Add(new JournalEditorView(), Name);
            AllUC.Add(new AnimsView(), Name);
            AllUC.Add(new MimicsView(), Name);
            AllUC.Add(new CR2WToTextToolView(), Name);
            AllUC.Add(new GameDebuggerToolView(), Name);
            AllUC.Add(new ImporterToolView(), Name);
            AllUC.Add(new MenuCreatorToolView(), Name);
            AllUC.Add(new RadishToolView(), Name);
            AllUC.Add(new WccToolView(), Name);

            TesterBro.ItemsSource = AllUC.Keys;


        }


        public void TesterBroHelper(UserControl Testing)
        {
     


        }

        private void TesterBro_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsLoaded && TesterBro.SelectedItem != null)
            {

                var z = (Catel.Windows.Controls.UserControl)TesterBro.SelectedItem;
                z.Margin = new System.Windows.Thickness(0, 35, 0, 0);
                var vm = new DialogControlHostWindowViewModel(z);
                var xd = new DialogControlHostWindowView(vm);
                xd.Show();
            }
           
        }
    }
}

