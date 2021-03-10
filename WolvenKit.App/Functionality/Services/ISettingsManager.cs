using System.Windows.Media;

namespace WolvenKit.Functionality.Services
{
    public interface ISettingsManager
    {
        #region Properties

        bool CheckForUpdates { get; set; }

        string CP77ExecutablePath { get; set; }

        string DepotPath { get; set; }

        string[] ManagerVersions { get; set; }

        public System.Windows.Media.ImageBrush ProfileImageBrush { get; set; }

        string TextLanguage { get; set; }

        Color ThemeAccent { get; set; }

        /*public*/
        string W3ExecutablePath { get; set; }
        /*public*/
        /*public*/
        string WccLitePath { get; set; }

        #endregion Properties

        /*public*/

        #region Methods

        void Save();

        #endregion Methods
    }
}
