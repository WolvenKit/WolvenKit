using System.Xml.Serialization;
using MLib.Interfaces;

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

        [XmlIgnore]
        IThemeInfos Themes { get; }

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
