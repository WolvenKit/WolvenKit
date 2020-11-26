using MLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WolvenKit.App.Services
{
    public interface ISettingsManager
    {
        [XmlIgnore]
        IThemeInfos Themes { get; }

    }
}
