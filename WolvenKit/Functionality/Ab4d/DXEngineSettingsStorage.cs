using System;
using Ab3d.DirectX.Client.Settings;

namespace WolvenKit.Functionality.Ab4d
{
    public class DXEngineSettingsStorage : IDXEngineSettingsStorage
    {
        public DXEngineSettingsStorage()
        {
        }

        /// <summary>
        /// Gets a graphics settings that (when set) will override the saved user settings with some other settings.
        /// This can be read from application startup parameters or config file.
        /// </summary>
        public string OverrideGraphicProfileText
        {
            get { return System.Configuration.ConfigurationManager.AppSettings.Get("DXEngineGraphicProfile"); }
        }

        /// <summary>
        /// Gets a Boolean that specifies if DXEngine will be using DirectX Overlay presentation type.
        /// </summary>
        public bool UseDirectXOverlay
        {
            get
            {
                string useDirectXOverlayText = System.Configuration.ConfigurationManager.AppSettings.Get("UseDirectXOverlay");
                if (!string.IsNullOrEmpty(useDirectXOverlayText))
                    return string.Equals(useDirectXOverlayText, "true", StringComparison.OrdinalIgnoreCase);

                return false;
            }
        }

        /// <summary>
        /// Gets or sets a user selected graphics settings.
        /// The text should be in format that can be used by the <see cref="GraphicsProfileSerializer"/>.
        /// </summary>
        public string UserGraphicProfileText
        {
            get;
            set;
        }
    }
}
