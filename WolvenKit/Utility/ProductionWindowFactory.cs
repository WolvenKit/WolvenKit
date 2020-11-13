using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Utility
{
    public class ProductionWindowFactory : IWindowFactory
    {
        public string ShowAddChunkFormModal(IEnumerable<string> availableTypes, ref string output)
        {
            using (var form = new frmAddChunk(availableTypes.ToList()))
            {
                var result = form.ShowDialog();
                output = result == System.Windows.Forms.DialogResult.OK 
                    ? form.ChunkType 
                    : "";
                return output;
            }
        }

        public void ShowStringsGUIModal()
        {
            var StringsGui = UIController.Get().StringsGui;

            if (StringsGui == null)
            {
                StringsGui = new frmStringsGui();
                StringsGui.ShowDialog();
            }
            else
                StringsGui.ShowDialog();
        }

        public void RequestStringsGUI()
        {
            var StringsGui = UIController.Get().StringsGui;

            if (StringsGui == null)
                StringsGui = new frmStringsGui();

            if (StringsGui.AreHashesDifferent())
            {
                var result =
                    MessageBox.Show(
                        "There are no encoded CSV files in your mod, do you want to open Strings Encoder GUI?",
                        "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    StringsGui.ShowDialog();
            }
        }
        
        public Common.WinFormsEnums.DialogResult ShowMessageBox(string message, string caption, Common.WinFormsEnums.MessageBoxButtons button, Common.WinFormsEnums.MessageBoxIcon icon)
        {
            var i = (int) button;
            var j = (int) icon;

            var r = (int)MessageBox.Show(message
                , caption
                , (System.Windows.Forms.MessageBoxButtons)i
                , (System.Windows.Forms.MessageBoxIcon)j);

            return (Common.WinFormsEnums.DialogResult) r;
        }

        public (bool, IWitcherFile) ResolveExtractAmbigious(bool skip, IEnumerable<IWitcherFile> options)
        {
            var dlg = new frmExtractAmbigious(options);
            if (!skip)
            {
                var res = dlg.ShowDialog();
                skip = dlg.Skip;
                if (res == DialogResult.Cancel)
                {
                    return (skip, null);
                }
            }
            var selectedBundle = dlg.SelectedBundle;
            return (skip, selectedBundle);
        }

        public PackSettings ShowPackSettings()
        {
            var frm = new frmPackSettings();
            var dlg = frm.ShowDialog();
            if (dlg == System.Windows.Forms.DialogResult.OK)
            {
                return frm.PackSettings;
            }

            return null;
        }

        public string ShowOpenFileDialog(string title, string filter, string initialDirectory)
        {
            var dlg = new OpenFileDialog
            {
                Title = title,
                Filter = filter,
                InitialDirectory = initialDirectory
            };
            return dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK 
                ? dlg.FileName 
                : "";
        }

        public void ShowConsole()
        {
            var Console = UIController.Get().Console;
            if (Console == null || Console.IsDisposed)
            {
                GetConsole();
                Console.Show(UIController.Get().Window.GetDockPanel(), WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);
            }

            Console.Activate();
        }
        public void ShowOutput()
        {
            var Output = UIController.Get().Output;
            if (Output == null || Output.IsDisposed)
            {
                GetOutput();
                Output.Show(UIController.Get().Window.GetDockPanel(), WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);
            }

            Output.Activate();
        }

        private WeifenLuo.WinFormsUI.Docking.IDockContent GetConsole()
        {
            var Console = UIController.Get().Console;
            if (Console == null || Console.IsDisposed)
                Console = new frmConsole();
            return Console;
        }
        private WeifenLuo.WinFormsUI.Docking.IDockContent GetOutput()
        {
            var Output = UIController.Get().Output;
            if (Output == null || Output.IsDisposed)
                Output = new frmOutput();
            return Output;
        }
    }
}
