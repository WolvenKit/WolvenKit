
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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






        public DebugPageView()
        {
            InitializeComponent();
        }




        private void DialogCB_SelectionChanged(object sender, SelectionChangedEventArgs e)  // Dialog Demo  Dont have own close / minimize buttons
        {
            if (IsLoaded && DialogCB.SelectedItem != null)
            {
                var z = (Catel.Windows.Controls.UserControl)DialogCB.SelectedItem;
                z.Margin = new System.Windows.Thickness(0, 35, 0, 0);
                var vm = new DialogControlHostWindowViewModel(z);
                var xd = new DialogControlHostWindowView(vm);
                xd.Show();

            }

        }

        private void WizardsCB_SelectionChanged(object sender, SelectionChangedEventArgs e) // Dont have own close / minimize buttons
        {
            if (IsLoaded && WizardsCB.SelectedItem != null)
            {
                var z = (Catel.Windows.Controls.UserControl)WizardsCB.SelectedItem;
                var vm = new UserControlHostWindowViewModel(z);
                var xd = new UserControlHostWindowView(vm);
                xd.Show();

            }
        }

        private void EditorsCB_SelectionChanged(object sender, SelectionChangedEventArgs e) // Editors should have their own close / minimize buttons 
        {
            if (IsLoaded && EditorsCB.SelectedItem != null)
            {
                var z = (Catel.Windows.Controls.UserControl)EditorsCB.SelectedItem;
                var vm = new ToolControlHostWindowViewModel(z);
                var xd = new ToolControlHostWindowView(vm);
                xd.Show();
            }
        }

        private void ToolsCB_SelectionChanged(object sender, SelectionChangedEventArgs e) // Same as for editors
        {
            if (IsLoaded && ToolsCB.SelectedItem != null)
            {
                var z = (Catel.Windows.Controls.UserControl)ToolsCB.SelectedItem;
                var vm = new ToolControlHostWindowViewModel(z);
                var xd = new ToolControlHostWindowView(vm);
                xd.Show();

            }
        }
    }
}

