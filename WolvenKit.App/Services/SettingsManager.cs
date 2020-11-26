using MLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WolvenKit.App.Services
{
    public class SettingsManager : ISettingsManager
    {

        /// <summary>
		/// Gets the internal name and Uri source for all available themes.
		/// </summary>
		[XmlIgnore]
        public IThemeInfos Themes { get; private set; }


		/// <summary>
		/// Hidden default constructor.
		/// </summary>
		public SettingsManager()
		{
			
		}
	}
}
