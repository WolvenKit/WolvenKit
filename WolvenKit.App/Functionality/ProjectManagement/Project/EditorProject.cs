using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WolvenKit.Functionality.Services;
using WolvenKit.Common;
using WolvenKit.Common.Model;

namespace WolvenKit.MVVM.Model.ProjectManagement.Project
{
    public abstract class EditorProject : ObservableObject, IEquatable<EditorProject>
    {
        #region Constructors

        public EditorProject(string location)
        {
            Location = location;
        }

        #endregion Constructors

        #region properties

        public string Location { get; protected init; }

        public string Author { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }



        #region not serialized

        [XmlIgnore] public abstract GameType GameType { get; }

        [XmlIgnore] public abstract string PackedDlcDirectory { get; }

        [XmlIgnore] public abstract string PackedModDirectory { get; }


        [XmlIgnore] public bool IsDirty { get; set; }

        [XmlIgnore]
        public string FileDirectory
        {
            get
            {
                var dir = Path.Combine(ProjectDirectory, "files");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        [XmlIgnore]
        public string DlcDirectory
        {
            get
            {
                var dir = Path.Combine(FileDirectory, "DLC");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        [XmlIgnore]
        public string ModDirectory
        {
            get
            {
                var dir = Path.Combine(FileDirectory, "Mod");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        [XmlIgnore]
        public string BackupDirectory
        {
            get
            {
                var dir = Path.Combine(ProjectDirectory, "_backups");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        


        [XmlIgnore]
        public List<string> Files
        {
            get
            {
                if (!Directory.Exists(FileDirectory))
                {
                    Directory.CreateDirectory(FileDirectory);
                }
                return Directory.EnumerateFiles(FileDirectory, "*", SearchOption.AllDirectories)
                    .Select(file => file[(FileDirectory.Length + 1)..])
                    .ToList();
            }
        }

        [XmlIgnore]
        public List<string> DLCFiles
        {
            get
            {
                if (!Directory.Exists(DlcDirectory))
                {
                    Directory.CreateDirectory(DlcDirectory);
                }
                return Directory.EnumerateFiles(DlcDirectory, "*", SearchOption.AllDirectories)
                    .Select(file => file[(DlcDirectory.Length + 1)..])
                    .ToList();
            }
        }

        [XmlIgnore]
        public List<string> ModFiles
        {
            get
            {
                if (!Directory.Exists(ModDirectory))
                {
                    Directory.CreateDirectory(ModDirectory);
                }
                return Directory.EnumerateFiles(ModDirectory, "*", SearchOption.AllDirectories)
                    .Select(file => file[(ModDirectory.Length + 1)..])
                    .ToList();
            }
        }

        [XmlIgnore]
        public string ProjectDirectory => Path.Combine(Path.GetDirectoryName(Location), Name);

        #endregion not serialized

        #endregion properties

        #region Methods

        public override string ToString() => Location;

        #endregion Methods

        #region implements IEquatable

        public bool Equals(EditorProject other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return string.Equals(Location, other.Location);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == GetType() && Equals((EditorProject)obj);
        }

        public override int GetHashCode() => Location != null ? Location.GetHashCode() : 0;

        #endregion implements IEquatable

    }
}
