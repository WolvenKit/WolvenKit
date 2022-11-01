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

        //public string ScriptDirectory
        //{
        //    get
        //    {
        //        var dir = Path.Combine(FileDirectory, "scripts");
        //        if (!Directory.Exists(dir))
        //        {
        //            Directory.CreateDirectory(dir);
        //        }

        //        return dir;
        //    }
        //}

        //public string TweakDirectory
        //{
        //    get
        //    {
        //        var oldDir = Path.Combine(FileDirectory, "tweakdbs");
        //        if (Directory.Exists(oldDir))
        //        {
        //            return oldDir;
        //        }
        //        var dir = Path.Combine(FileDirectory, "tweaks");
        //        if (!Directory.Exists(dir))
        //        {
        //            Directory.CreateDirectory(dir);
        //        }

        //        return dir;
        //    }
        //}

        //public string ArchiveXLDirectory
        //{
        //    get
        //    {
        //        var dir = Path.Combine(FileDirectory, "archiveXL");
        //        if (!Directory.Exists(dir))
        //        {
        //            Directory.CreateDirectory(dir);
        //        }

        //        return dir;
        //    }
        //}

        public override string ResourcesDirectory
        {
            get
            {
                var dir = Path.Combine(FileDirectory, "resources");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }

        // packed folders

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

        public override string PackedRedModDirectory
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

        public string GetPackedArchiveDirectory(bool isRedMod)
        {
            var dir = isRedMod ? Path.Combine(PackedRedModDirectory, "archives") : Path.Combine(PackedRootDirectory, "archive", "pc", "mod");

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
                var dir = Path.Combine(PackedRedModDirectory, "customSounds");
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


        // Methods

        public void CreateDefaultDirectories()
        {
            // create top-level directories
            _ = ModDirectory;
            _ = RawDirectory;
            _ = ResourcesDirectory;
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
    }
}
