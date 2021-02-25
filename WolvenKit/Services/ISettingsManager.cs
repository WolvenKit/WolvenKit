using MLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WolvenKit.Services
{
    public interface ISettingsManager
    {
        [XmlIgnore]
        IThemeInfos Themes { get; }


        bool CheckForUpdates { get; set; }

        /*public*/ string W3ExecutablePath { get; set; }
        /*public*/ string CP77ExecutablePath { get; set; }
        /*public*/ string WccLitePath { get; set; }

        //string GameModDir { get; set; }
        //string GameDlcDir { get; set; }

        string DepotPath { get; set; }

        /*public*/
        string[] ManagerVersions { get; set; }
        string TextLanguage { get; set; }

        public System.Windows.Media.ImageBrush ProfileImageBrush { get; set; }

        void Save();
        

    }
}
