using System.Windows.Media;

namespace WolvenKit.Functionality.Services
{
    public interface ISettingsDto
    {
        #region Properties

        bool CheckForUpdates { get; set; }


        string TextLanguage { get; set; }

        string ThemeAccentString { get; set; }



        string[] ManagerVersions { get; set; }

        string DepotPath { get; set; }


        // red 4

        string CP77ExecutablePath { get; set; }

        string MaterialRepositoryPath { get; set; }

        // red 3

        string W3ExecutablePath { get; set; }

        string WccLitePath { get; set; }

        #endregion Properties

    }

    public interface ISettingsManager : ISettingsDto
    {
        // This is here because Catel can't expose inherited Properties ¯\_(ツ)_/¯
        // and we use this in teh first set up viewmodels
        bool ShowGuidedTour { get; set; }

        public ImageBrush ProfileImageBrush { get; set; }

        #region Methods

        string GetW3GameContentDir();
        string GetW3GameDlcDir();
        string GetW3GameModDir();
        string GetW3GameRootDir();


        string GetRED4GameRootDir();
        string GetRED4GameModDir();

        void Save();

        #endregion Methods

        bool ShowFirstTimeSetupForUser();
        Color GetThemeAccent();
        void SetThemeAccent(Color color);
    }
}
