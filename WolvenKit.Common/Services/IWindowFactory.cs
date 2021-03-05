using System.Collections.Generic;
using WolvenKit.Common.WinFormsEnums;

namespace WolvenKit.Common.Services
{
    public interface IWindowFactory
    {
        #region Methods

        void RequestStringsGUI();

        (bool, IGameFile) ResolveExtractAmbigious(IEnumerable<IGameFile> options);

        string ShowAddChunkFormModal(IEnumerable<string> availableTypes);

        void ShowConsole();

        DialogResult ShowMessageBox(string message, string caption, MessageBoxButtons button, MessageBoxIcon icon);

        string ShowOpenFileDialog(string title, string filter, string initialDirectory);

        void ShowOutput();

        PackSettings ShowPackSettings();

        string ShowRenameForm(string filepath);

        void ShowStringsGUIModal();

        #endregion Methods
    }

    public class PackSettings
    {
        #region Properties

        public (bool, bool) GenCollCache { get; set; }
        public (bool, bool) GenMetadata { get; set; }
        public (bool, bool) GenTexCache { get; set; }
        public bool InstallProject { get; set; }
        public (bool, bool) PackBundles { get; set; }
        public (bool, bool) Scripts { get; set; }
        public (bool, bool) Sound { get; set; }
        public (bool, bool) Strings { get; set; }

        #endregion Properties
    }
}
