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

        bool ShowGuidedTour { get; set; }

        /*public*/
        string W3ExecutablePath { get; set; }
        /*public*/
        /*public*/
        string WccLitePath { get; set; }

        string MaterialRepositoryPath { get; set; }
        string W3GameContentDir { get; }
        string W3GameDlcDir { get; }
        string W3GameModDir { get; }
        string W3GameRootDir { get; }

        #endregion Properties

        /*public*/

        #region Methods

        void Save();

        #endregion Methods
    }
}
