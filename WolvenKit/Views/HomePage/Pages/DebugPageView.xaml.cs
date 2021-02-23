
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
        List<UserControl> AllUC = new List<UserControl>();



        public DebugPageView()
        {
            InitializeComponent();
            AllUC.Add(new AddChunkDialog());
            AllUC.Add(new ExtractAmbigiousDialog());
            AllUC.Add(new RenameDialog());
            AllUC.Add(new StringsGUIImporterIDDialog());
            AllUC.Add(new StringsGuiScriptsPrefixDialog());
            AllUC.Add(new BulkEditorView());
            AllUC.Add(new CsvEditorView());
            AllUC.Add(new ArrayEditorView());
            AllUC.Add(new ByteArrayEditorView());
            AllUC.Add(new IdTagEditorView());
            AllUC.Add(new PtrEditorView());
            AllUC.Add(new JournalEditorView());
            AllUC.Add(new AnimsView());
            AllUC.Add(new MimicsView());
            AllUC.Add(new CR2WToTextToolView());
            AllUC.Add(new GameDebuggerToolView());
            AllUC.Add(new ImporterToolView());
            AllUC.Add(new MenuCreatorToolView());
            AllUC.Add(new RadishToolView());
            AllUC.Add(new WccToolView());

            TesterBro.ItemsSource = AllUC;


        }


        public void TesterBroHelper(UserControl Testing)
        {
     


        }

        private void TesterBro_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsLoaded && TesterBro.SelectedItem != null)
            {
                var vm = new UserControlHostWindowViewModel((Catel.Windows.Controls.UserControl)TesterBro.SelectedItem, 600, 600);
                var xd = new UserControlHostWindowView(vm);
                xd.Show();
            }
           
        }
    }
}

