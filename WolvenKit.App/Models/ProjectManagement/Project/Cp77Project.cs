using System;
using System.IO;
using Splat;
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
                var dir = Path.Combine(FileDirectory, "customSounds");
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
                var dir = Path.Combine(FileDirectory, "scripts");
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
                var oldDir = Path.Combine(FileDirectory, "tweakdbs");
                if (Directory.Exists(oldDir))
                {
                    return oldDir;
                }
                var dir = Path.Combine(FileDirectory, "tweaks");
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
                var dir = Path.Combine(ProjectDirectory, "packed");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        public override string PackedModDirectory
        {
            get
            {
                var dir = Path.Combine(PackedRootDirectory, "mods", Name);
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        public override string PackedArchiveDirectory
        {
            get
            {
                var dir = IsRedMod ? Path.Combine(PackedModDirectory, "archives") : Path.Combine(PackedRootDirectory, "archive", "pc", "mod");

                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        public string PackedSoundsDirectory
        {
            get
            {
                var dir = Path.Combine(PackedModDirectory, "customSounds");
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
                var dir = Path.Combine(PackedRootDirectory, "r6", "tweaks");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        public string PackedScriptsDirectory
        {
            get
            {
                var dir = Path.Combine(PackedRootDirectory, "r6", "scripts");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        public bool IsRedMod { get; set; }


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

                var hashPath = Path.Combine(FileDirectory, "project_hashes.txt");
                if (!File.Exists(hashPath))
                {
                    return;
                }

                var paths = File.ReadAllLines(hashPath);
                foreach (var path in paths)
                {
                    hashService.AddProjectPath(path);
                }
            }
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
