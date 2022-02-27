using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Common;
using WolvenKit.Models;

namespace WolvenKit.ProjectManagement.Project
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

        public string Description { get; set; }

        public string Version { get; set; }



        #region not serialized

        public abstract GameType GameType { get; }

        public abstract string PackedRootDirectory { get; }
        public abstract string PackedArchiveDirectory { get; }


        public bool IsDirty { get; set; }

        public string FileDirectory
        {
            get
            {
                var oldDir = Path.Combine(ProjectDirectory, "files");
                if (Directory.Exists(oldDir))
                {
                    return oldDir;
                }
                var dir = Path.Combine(ProjectDirectory, "source");
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
                var oldDir = Path.Combine(FileDirectory, "Mod");
                if (Directory.Exists(oldDir))
                {
                    return oldDir;
                }
                var dir = Path.Combine(FileDirectory, "archive");
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

        public string RawDirectory
        {
            get
            {
                var oldDir = Path.Combine(FileDirectory, "Raw");
                if (DirExistsMatchCase(oldDir))
                {
                    return oldDir;
                }
                var dir = Path.Combine(FileDirectory, "raw");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        public static bool DirExistsMatchCase(string path)
        {
            // If it definitely doesn't return false
            if (!Directory.Exists(path))
            {
                return false;
            }

            // Figure out if the case (of the final part) is the same
            var thisDir = Path.GetFileName(path);
            var actualDir = Path.GetFileName(Directory.GetDirectories(Path.GetDirectoryName(path), thisDir)[0]);
            return thisDir == actualDir;
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

        public List<string> RawFiles
        {
            get
            {
                if (!Directory.Exists(RawDirectory))
                {
                    Directory.CreateDirectory(RawDirectory);
                }
                return Directory.EnumerateFiles(RawDirectory, "*", SearchOption.AllDirectories)
                    .Select(file => file[(RawDirectory.Length + 1)..])
                    .ToList();
            }
        }

        public string ProjectDirectory
        {
            get
            {
                var oldDir = Path.Combine(Path.GetDirectoryName(Location), Name);
                if (Directory.Exists(oldDir))
                {
                    return oldDir;
                }
                return Path.GetDirectoryName(Location);
            }
        }

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
