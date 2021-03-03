using System;
using System.IO;
using System.Linq;
using WolvenKit.Common;
using WolvenKit.Common.Services;

namespace WolvenKit.Functionality.Controllers
{
    /// <summary>
    /// Radish-modding-community-tools handler
    /// </summary>
    public class RadishController : ObservableObject
    {
        #region Fields

        private static RadishController radishController;

        #endregion Fields

        #region Constructors

        private RadishController()
        {
        }

        #endregion Constructors



        #region Enums

        public enum ERadishStatus
        {
            NoRadish,
            SettingsError,
            Healthy
        }

        #endregion Enums

        //public RadishConfiguration Configuration { get; private set; }

        #region modname

        private RadishConfiguration _configuration;

        public RadishConfiguration Configuration
        {
            get => _configuration;
            set
            {
                if (_configuration != value)
                {
                    _configuration = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion modname



        #region Properties

        public string WkitLoggedFiles
        {
            get
            {
                var dir = Path.Combine(MainController.Get().ActiveMod.RadishDirectory, "WkitLoggedFiles");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        #endregion Properties



        #region Methods

        public static RadishController Get()
        {
            if (radishController == null)
            {
                radishController = new RadishController
                {
                    Configuration = RadishConfiguration.Load()
                };
            }
            return radishController;
        }

        public static RadishConfiguration GetConfig() => Get().Configuration;

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public ERadishStatus CheckSelf()
        {
            // first check if a file and directory with the _settings.bat exists in the modproject file folder
            var filedir = new DirectoryInfo(MainController.Get().ActiveMod.FileDirectory);
            var settingsbat = filedir.GetFiles("*.bat", SearchOption.AllDirectories)?.FirstOrDefault(_ => _.Name == "_settings_.bat");
            if (settingsbat == null)
            {
                MainController.LogString("ERROR! No Radish settings file found.\r\n", Logtype.Error);
                return ERadishStatus.NoRadish;
            }
            var radishdir = settingsbat.Directory;
            if (radishdir == null)
            {
                MainController.LogString("ERROR! No Radish mod directory found.\r\n", Logtype.Error);
                return ERadishStatus.NoRadish;
            }
            // update the radish config if necessary
            if (radishdir.FullName != Configuration.RadishProjectPath)
            {
                MainController.LogString("Radish directory updated.\r\n", Logtype.Important);
                Configuration.RadishProjectPath = radishdir.FullName;
            }

            // read the settings file

            #region read settings

            var modname = "";
            var idspace = "";
            var DIR_W3 = "";
            var DIR_MODKIT = "";
            var DIR_ENCODER = "";
            //try
            {
                ReadSettings(out modname, out idspace, out DIR_W3, out DIR_MODKIT, out DIR_ENCODER);
            }
            //catch (Exception ex)
            //{
            //    MainController.LogString($"Parsing the radish settings file failed. It may be corrupted. Error message: {ex.Message}\r\n", Logtype.Important);
            //    return ERadishStatus.SettingsError;
            //}

            if (string.IsNullOrEmpty(modname))
            {
                MainController.LogString("ERROR! ModName not found. Adjust in _settings_.bat.\r\n", Logtype.Error);
                return ERadishStatus.SettingsError;
            }
            if (string.IsNullOrEmpty(idspace))
            {
                MainController.LogString("ERROR! idspace not found. Adjust in the _settings_.bat\r\n", Logtype.Error);
                return ERadishStatus.SettingsError;
            }
            if (!new DirectoryInfo(DIR_W3).Exists)
            {
                MainController.LogString("ERROR! Game directory not found. Adjust paths in _settings_.bat\r\n", Logtype.Error);
                return ERadishStatus.SettingsError;
            }
            if (!new DirectoryInfo(DIR_MODKIT).Exists)
            {
                MainController.LogString("ERROR! ModKit directory not found. Adjust paths in _settings_.bat\r\n", Logtype.Error);
                return ERadishStatus.SettingsError;
            }
            if (!new DirectoryInfo(DIR_ENCODER).Exists)
            {
                MainController.LogString("ERROR! Radish Tools directory not found. Adjust paths in _settings_.bat\r\n", Logtype.Error);
                return ERadishStatus.SettingsError;
            }

            #endregion read settings

            MainController.LogString($"Radish project healthy.\r\n", Logtype.Success);
            return ERadishStatus.Healthy;
        }

        public bool IsHealthy() => CheckSelf() == ERadishStatus.Healthy;

        public bool UpdatdeSelf()
        {
            if (!IsHealthy())
            {
                return false;
            }

            // read the settings file
            ReadSettings(out var modname, out var idspace, out var DIR_W3, out var DIR_MODKIT, out var DIR_ENCODER);

            // update the radish config if necessary
            if (modname != Configuration.modname)
            {
                MainController.LogString($"Radish ModName updated: {modname}\r\n", Logtype.Important);
                Configuration.modname = modname;
            }
            if (idspace != Configuration.idspace)
            {
                MainController.LogString($"Radish idspace updated: {idspace}\r\n", Logtype.Important);
                Configuration.idspace = idspace;
            }
            if (DIR_W3 != Configuration.DIR_W3)
            {
                MainController.LogString($"Radish game directory updated: {DIR_W3}\r\n", Logtype.Important);
                Configuration.DIR_W3 = DIR_W3;
            }
            if (DIR_MODKIT != Configuration.DIR_MODKIT)
            {
                MainController.LogString($"Radish ModKit directory updated: {DIR_MODKIT}\r\n", Logtype.Important);
                Configuration.DIR_MODKIT = DIR_MODKIT;
            }
            if (DIR_ENCODER != Configuration.DIR_ENCODER)
            {
                MainController.LogString($"Radish Tools directory updated: {DIR_ENCODER}\r\n", Logtype.Important);
                Configuration.DIR_ENCODER = DIR_ENCODER;
            }

            return true;
        }

        public void UpdateSettingsBat()
        {
            try
            {
                var filedir = new DirectoryInfo(Configuration.RadishProjectPath);
                var settingsbat = filedir.GetFiles("*.bat", SearchOption.AllDirectories)?.FirstOrDefault(_ => _.Name == "_settings_.bat");
                var settingslines = File.ReadAllLines(settingsbat.FullName);
                for (var i = 0; i < settingslines.Length; i++)
                {
                    if (settingslines[i].StartsWith("set MODNAME="))
                    {
                        settingslines[i] = $"set MODNAME={Configuration.modname}";
                    }

                    if (settingslines[i].StartsWith("set idspace="))
                    {
                        settingslines[i] = $"set idspace={Configuration.idspace}";
                    }

                    if (settingslines[i].StartsWith("set DIR_W3="))
                    {
                        settingslines[i] = $"set DIR_W3={Configuration.DIR_W3}";
                    }

                    if (settingslines[i].StartsWith("set DIR_MODKIT="))
                    {
                        settingslines[i] = $"set DIR_MODKIT={Configuration.DIR_MODKIT}";
                    }

                    if (settingslines[i].StartsWith("set DIR_ENCODER="))
                    {
                        settingslines[i] = $"set DIR_ENCODER={Configuration.DIR_ENCODER}";
                    }
                }
                File.WriteAllLines(settingsbat.FullName, settingslines);
                MainController.LogString("Radish settings file successfully updated.\r\n", Logtype.Success);
            }
            catch (Exception ex)
            {
                MainController.LogString($"Failed to write Radish settings file. Potential corruption. Error message: {ex.Message}.\r\n", Logtype.Important);
            }
        }

        private static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            var arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private void ReadSettings(out string modname, out string idspace, out string DIR_W3, out string DIR_MODKIT, out string DIR_ENCODER)
        {
            var settingsbat = new FileInfo(Directory.GetFiles(Configuration.RadishProjectPath, "*.bat", SearchOption.AllDirectories)?
                .First(_ => _.EndsWith("_settings_.bat")));
            var settingslines = File.ReadAllLines(settingsbat.FullName);
            modname = settingslines.First(_ => _.StartsWith("set MODNAME=")).Substring("set MODNAME=".Length);
            idspace = settingslines.First(_ => _.StartsWith("set idspace=")).Substring("set idspace=".Length);
            DIR_W3 = settingslines.First(_ => _.StartsWith("set DIR_W3=")).Substring("set DIR_W3=".Length);
            DIR_MODKIT = settingslines.First(_ => _.StartsWith("set DIR_MODKIT=")).Substring("set DIR_MODKIT=".Length);
            DIR_ENCODER = settingslines.First(_ => _.StartsWith("set DIR_ENCODER=")).Substring("set DIR_ENCODER=".Length);
        }

        #endregion Methods
    }
}
