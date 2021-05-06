using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Catel.IoC;
using Catel.Logging;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.MVVM.Model.ProjectManagement.Project
{
    public sealed class Cp77Project : EditorProject, ICloneable
    {

        public Cp77Project(string location) : base(location)
        {
        }

        private Cp77Project() : base("")
        {
        }


        public override GameType GameType => GameType.Cyberpunk2077;

        [XmlIgnore]
        public override string PackedDlcDirectory
        {
            get
            {
                if (string.IsNullOrEmpty(GetDlcName()))
                {
                    return null;
                }
                var dir = Path.Combine(ProjectDirectory, "packed", "archive", "pc", "dlc", $"mod{Name}");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        [XmlIgnore]
        public override string PackedModDirectory
        {
            get
            {
                var dir = Path.Combine(ProjectDirectory, "packed", "archive", "pc", "mod", $"mod{Name}");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }


        #region methods

        public string GetDlcName() => $"dlc{Name}";

        public void CreateDefaultDirectories()
        {
            // create top-level directories
            _ = ModDirectory;
            _ = DlcDirectory;
        }

        public object Clone()
        {
            var clone = new Cp77Project()
            {
                Name = Name,
                Author = Author,
                Email = Email,
                Version = Version,
                Location = Location
            };
            return clone;
        }

        public override string ToString() => Location;

        #endregion methods
    }
}
