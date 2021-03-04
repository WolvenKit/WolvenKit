using System;
using System.IO;
using System.Linq;
using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    public class W3Mod : EditorProjectData, ICloneable
    {
        #region Methods

        public object Clone()
        {
            var clone = new W3Mod
            {
                Name = Name,
                Author = Author,
                Email = Email,
                Version = Version,
                FileName = FileName,
                LastOpenedFiles = LastOpenedFiles
            };
            return clone;
        }

        public override void CreateDefaultDirectories()
        {
            // create top-level directories
            _ = ModDirectory;
            _ = DlcDirectory;
            _ = RawDirectory;
            _ = RadishDirectory;

            // create mod-level directories
            _ = ModUncookedDirectory;
            _ = ModCookedDirectory;

            // create dlc-level directories
            _ = DlcUncookedDirectory;
            _ = DlcCookedDirectory;

            // create raw-level directories
            _ = RawModDirectory;
            _ = RawDlcDirectory;
        }

        /// <summary>
        /// Returns the first folder name in the DlcCookedDirectory.
        /// Does not support multiple dlc
        /// </summary>
        /// <returns></returns>
        public override string GetDlcCookedRelativePath()
        {
            string relpath = "";
            var di = new DirectoryInfo(DlcCookedDirectory);
            if (di.Exists && di.GetDirectories().Any())
            {
                // support older projects
                if (di.GetDirectories().Any(_ => _.Name == "dlc"))
                {
                    var subdi = di.GetDirectories().First(_ => _.Name == "dlc");
                    if (subdi.Exists && subdi.GetDirectories().Any())
                    {
                        relpath = subdi.GetDirectories().First().FullName;
                        return relpath.Substring(DlcCookedDirectory.Length + 5);
                    }
                    else
                    {
                        return "";
                    }
                }
                else
                    relpath = di.GetDirectories().First().FullName;
                return relpath.Substring(DlcCookedDirectory.Length + 1);
            }
            return relpath;
        }

        /// <summary>
        /// Returns the first relative folder path in the ActiveMod/dlc directory
        /// Does not support multiple DLC
        /// </summary>
        /// <returns></returns>
        public override string GetDlcName()
        {
            if (!string.IsNullOrEmpty(GetDlcCookedRelativePath()))
                return GetDlcCookedRelativePath();
            if (!string.IsNullOrEmpty(GetDlcUncookedRelativePath()))
                return GetDlcUncookedRelativePath();
            return "";
        }

        /// <summary>
        /// Returns the first folder name in the DlcUncookedDirectory.
        /// Does not support multiple dlc
        /// </summary>
        /// <returns></returns>
        public override string GetDlcUncookedRelativePath()
        {
            string relpath = "";
            var di = new DirectoryInfo(DlcUncookedDirectory);
            if (di.Exists && di.GetDirectories().Any())
            {
                // support older projects
                if (di.GetDirectories().Any(_ => _.Name == "dlc"))
                {
                    var subdi = di.GetDirectories().First(_ => _.Name == "dlc");
                    if (subdi.Exists && subdi.GetDirectories().Any())
                    {
                        relpath = subdi.GetDirectories().First().FullName;
                        return relpath.Substring(DlcUncookedDirectory.Length + 5);
                    }
                    else
                    {
                        return "";
                    }
                }
                else
                    relpath = di.GetDirectories().First().FullName;
                return relpath.Substring(DlcUncookedDirectory.Length + 1);
            }
            return relpath;
        }

        #endregion Methods
    }
}
