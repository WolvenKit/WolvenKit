using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit
{
    using ViewModels;
    using Common;
    using Common.Services;
    /// <summary>
    /// Radish-modding-community-tools handler
    /// </summary>
    public class RadishController : ObservableObject
    {
        public enum ERadishStatus
        {
            NoRadish,
            SettingsError,
            Healthy
        }


        private static RadishController radishController;

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
        #endregion

        private RadishController() { }

        public static RadishController Get()
        {
            if (radishController == null)
            {
                radishController = new RadishController();
                radishController.Configuration = RadishConfiguration.Load();
            }
            return radishController;
        }

        public string WkitLoggedFiles
        {
            get
            {
                var dir = Path.Combine(MainController.Get().ActiveMod.RadishDirectory, "WkitLoggedFiles");
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);
                return dir;
            }
        }

        public static RadishConfiguration GetConfig() => Get().Configuration;

        public bool UpdatdeSelf()
        {
            if (!IsHealthy())
                return false;

            // read the settings file
            ReadSettings(out string modname, out string idspace, out string DIR_W3, out string DIR_MODKIT, out string DIR_ENCODER);


            // update the radish config if necessary
            if (modname != Configuration.modname)
            {
                MainController.LogString($"Radish modname updated: {modname}\r\n", Logtype.Important);
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
                MainController.LogString($"Radish modkit directory updated: {DIR_MODKIT}\r\n", Logtype.Important);
                Configuration.DIR_MODKIT = DIR_MODKIT;
            }
            if (DIR_ENCODER != Configuration.DIR_ENCODER)
            {
                MainController.LogString($"Radish tools directory updated: {DIR_ENCODER}\r\n", Logtype.Important);
                Configuration.DIR_ENCODER = DIR_ENCODER;
            }


            return true;
        }

        private void ReadSettings(out string modname, out string idspace, out string DIR_W3, out string DIR_MODKIT, out string DIR_ENCODER)
        {
            FileInfo settingsbat = new FileInfo(Directory.GetFiles(Configuration.RadishProjectPath, "*.bat", SearchOption.AllDirectories)?
                .First(_ => _.EndsWith("_settings_.bat")));
            string[] settingslines = File.ReadAllLines(settingsbat.FullName);
            modname = settingslines.First(_ => _.StartsWith("set MODNAME=")).Substring("set MODNAME=".Length);
            idspace = settingslines.First(_ => _.StartsWith("set idspace=")).Substring("set idspace=".Length);
            DIR_W3 = settingslines.First(_ => _.StartsWith("set DIR_W3=")).Substring("set DIR_W3=".Length);
            DIR_MODKIT = settingslines.First(_ => _.StartsWith("set DIR_MODKIT=")).Substring("set DIR_MODKIT=".Length);
            DIR_ENCODER = settingslines.First(_ => _.StartsWith("set DIR_ENCODER=")).Substring("set DIR_ENCODER=".Length);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ERadishStatus CheckSelf()
        {
            // first check if a file and directory with the _settings.bat exists in the modproject file folder
            DirectoryInfo filedir = new DirectoryInfo(MainController.Get().ActiveMod.FileDirectory);
            FileInfo settingsbat = filedir.GetFiles("*.bat", SearchOption.AllDirectories)?.FirstOrDefault(_ => _.Name == "_settings_.bat");
            if (settingsbat == null)
            {
                MainController.LogString("ERROR! No radish settingsfile found.\r\n", Logtype.Error);
                return ERadishStatus.NoRadish;
            }
            DirectoryInfo radishdir = settingsbat.Directory;
            if (radishdir == null)
            {
                MainController.LogString("ERROR! No radish mod directory found.\r\n", Logtype.Error);
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
            string modname = "";
            string idspace = "";
            string DIR_W3 = "";
            string DIR_MODKIT = "";
            string DIR_ENCODER = "";
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
                MainController.LogString("ERROR! ModName was not found! adjust the name in the _settings_.bat\r\n", Logtype.Error);
                return ERadishStatus.SettingsError;
            }
            if (string.IsNullOrEmpty(idspace))
            {
                MainController.LogString("ERROR! idspace was not found! adjust the name in the _settings_.bat\r\n", Logtype.Error);
                return ERadishStatus.SettingsError;
            }
            if (! new DirectoryInfo(DIR_W3).Exists)
            {
                MainController.LogString("ERROR! Game directory was not found! adjust the paths in the _settings_.bat\r\n", Logtype.Error);
                return ERadishStatus.SettingsError;
            }
            if (!new DirectoryInfo(DIR_MODKIT).Exists)
            {
                MainController.LogString("ERROR! Modkit directory was not found! adjust the paths in the _settings_.bat\r\n", Logtype.Error);
                return ERadishStatus.SettingsError;
            }
            if (!new DirectoryInfo(DIR_ENCODER).Exists)
            {
                MainController.LogString("ERROR! Radish Tools directory was not found! adjust the paths in the _settings_.bat\r\n", Logtype.Error);
                return ERadishStatus.SettingsError;
            }  
            #endregion

            MainController.LogString($"Radish project healthy.\r\n", Logtype.Success);
            return ERadishStatus.Healthy;
        }

        public void UpdateSettingsBat()
        {
            try
            {
                DirectoryInfo filedir = new DirectoryInfo(Configuration.RadishProjectPath);
                FileInfo settingsbat = filedir.GetFiles("*.bat", SearchOption.AllDirectories)?.FirstOrDefault(_ => _.Name == "_settings_.bat");
                string[] settingslines = File.ReadAllLines(settingsbat.FullName);
                for (int i = 0; i < settingslines.Length; i++)
                {
                    if (settingslines[i].StartsWith("set MODNAME="))
                        settingslines[i] = $"set MODNAME={Configuration.modname}";
                    if (settingslines[i].StartsWith("set idspace="))
                        settingslines[i] = $"set idspace={Configuration.idspace}";
                    if (settingslines[i].StartsWith("set DIR_W3="))
                        settingslines[i] = $"set DIR_W3={Configuration.DIR_W3}";
                    if (settingslines[i].StartsWith("set DIR_MODKIT="))
                        settingslines[i] = $"set DIR_MODKIT={Configuration.DIR_MODKIT}";
                    if (settingslines[i].StartsWith("set DIR_ENCODER="))
                        settingslines[i] = $"set DIR_ENCODER={Configuration.DIR_ENCODER}";
                }
                File.WriteAllLines(settingsbat.FullName, settingslines);
                MainController.LogString("Sucessfully updated the radish settings file.\r\n", Logtype.Success);
            }
            catch (Exception ex)
            {
                MainController.LogString($"Writing the radish settings file failed. It may be corrupted. Error message: {ex.Message}\r\n", Logtype.Important);
            }
        }

        public bool IsHealthy() => CheckSelf() == ERadishStatus.Healthy;

        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
    }
}
