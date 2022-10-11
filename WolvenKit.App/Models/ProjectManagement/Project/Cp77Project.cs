using Splat;
using System;
using System.IO;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;


namespace WolvenKit.ProjectManagement.Project
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

        public string SoundDirectory
        {
            get
            {
                string dir = Path.Combine(FileDirectory, "customSounds");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }
        public string ScriptDirectory
        {
            get
            {
                string dir = Path.Combine(FileDirectory, "scripts");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        public string TweakDirectory
        {
            get
            {
                string oldDir = Path.Combine(FileDirectory, "tweakdbs");
                if (Directory.Exists(oldDir))
                {
                    return oldDir;
                }
                string dir = Path.Combine(FileDirectory, "tweaks");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        public override string PackedRootDirectory
        {
            get
            {
                string dir = Path.Combine(ProjectDirectory, "packed");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        public override string PackedRedModDirectory
        {
            get
            {
                string dir = Path.Combine(PackedRootDirectory, "mods", Name);
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        public string GetPackedArchiveDirectory(bool IsRedMod)
        {
            string dir = IsRedMod ? Path.Combine(PackedRedModDirectory, "archives") : Path.Combine(PackedRootDirectory, "archive", "pc", "mod");

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }

        public string PackedSoundsDirectory
        {
            get
            {
                string dir = Path.Combine(PackedRedModDirectory, "customSounds");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        public string PackedTweakDirectory
        {
            get
            {
                string dir = Path.Combine(PackedRootDirectory, "r6", "tweaks");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        #region methods

        //public string GetDlcName() => $"dlc{Name}";

        public void CreateDefaultDirectories()
        {
            // create top-level directories
            _ = ModDirectory;
            _ = RawDirectory;
            _ = TweakDirectory;
            _ = ScriptDirectory;
        }

        private void LoadProjectHashes()
        {
            if (Locator.Current.GetService<IHashService>() is HashService hashService)
            {
                hashService.ClearProjectHashes();

                string hashPath = Path.Combine(FileDirectory, "project_hashes.txt");
                if (!File.Exists(hashPath))
                {
                    return;
                }

                string[] paths = File.ReadAllLines(hashPath);
                foreach (string path in paths)
                {
                    hashService.AddProjectPath(path);
                }
            }
        }

        public object Clone()
        {
            Cp77Project clone = new()
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
