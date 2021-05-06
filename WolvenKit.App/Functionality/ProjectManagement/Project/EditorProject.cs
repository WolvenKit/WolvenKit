using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Common;

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

        public string Location { get; set; }

        public string Author { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }



        #region not serialized

        public abstract GameType GameType { get; }

        public abstract string PackedDlcDirectory { get; }

        public abstract string PackedModDirectory { get; }


        public bool IsDirty { get; set; }

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
