using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.WinFormsEnums;

namespace WolvenKit.Common.Services
{
    public interface IWindowFactory
    {
        string ShowAddChunkFormModal(IEnumerable<string> availableTypes);
        string ShowRenameForm(string filepath);
        DialogResult ShowMessageBox(string message, string caption, MessageBoxButtons button, MessageBoxIcon icon);
        PackSettings ShowPackSettings();
        string ShowOpenFileDialog(string title, string filter, string initialDirectory);

        (bool, IGameFile) ResolveExtractAmbigious(IEnumerable<IGameFile> options);

        void RequestStringsGUI();
        void ShowStringsGUIModal();

        void ShowConsole();
        void ShowOutput();
    }




    public class PackSettings
    {
        public (bool, bool) PackBundles { get; set; }
        public (bool, bool) GenMetadata { get; set; }
        public (bool, bool) GenTexCache { get; set; }
        public (bool, bool) GenCollCache { get; set; }
        public (bool, bool) Scripts { get; set; }
        public (bool, bool) Sound { get; set; }
        public (bool, bool) Strings { get; set; }

        public bool InstallProject { get; set; }
    }
}