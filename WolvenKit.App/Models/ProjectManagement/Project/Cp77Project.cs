using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive;

namespace WolvenKit.App.Models.ProjectManagement.Project;

public sealed class Cp77Project : IEquatable<Cp77Project>, ICloneable
{
    private readonly IHashService _hashService;

    public Cp77Project(string location, string name, IHashService hashService)
    {
        Location = location;
        Name = name;

        _hashService= hashService;
    }

    public string Name { get; set; }

    public string Location { get; set; }


    public string? Author { get; set; }

    public string? Email { get; set; }

    public string? Description { get; set; }

    public string? Version { get; set; }


    public bool IsDirty { get; set; }



    public GameType GameType => GameType.Cyberpunk2077;



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
            var oldDir = Path.Combine(Path.GetDirectoryName(Location).NotNull(), Name).NotNull();
            return Directory.Exists(oldDir) ? oldDir : Path.GetDirectoryName(Location).NotNull();
        }
    }







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

    public string ResourcesDirectory
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

    public string PackedRootDirectory
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

    public string PackedRedModDirectory
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

    public static bool DirExistsMatchCase(string path)
    {
        // If it definitely doesn't return false
        if (!Directory.Exists(path))
        {
            return false;
        }

        // Figure out if the case (of the final part) is the same
        var thisDir = Path.GetFileName(path);
        var actualDir = Path.GetFileName(Directory.GetDirectories(Path.GetDirectoryName(path).NotNull(), thisDir)[0]);
        return thisDir == actualDir;
    }

    public void CreateDefaultDirectories()
    {
        // create top-level directories
        _ = ModDirectory;
        _ = RawDirectory;
        _ = ResourcesDirectory;
    }

    // Conversions

    public ICyberGameArchive AsArchive() => new FileSystemArchive(Name, ModDirectory, _hashService);


    #region implements ICloneable

    public object Clone()
    {
        Cp77Project clone = new(Location, Name, _hashService)
        {
            Author = Author,
            Email = Email,
            Version = Version
        };
        return clone;
    }

    #endregion implements ICloneable

    #region implements IEquatable

    public bool Equals(Cp77Project? other) => other is not null && (ReferenceEquals(this, other) || string.Equals(Location, other.Location));

    public override bool Equals(object? obj) => obj is not null && (ReferenceEquals(this, obj) || obj.GetType() == GetType() && Equals((Cp77Project)obj));

    public override int GetHashCode() => Location != null ? Location.GetHashCode() : 0;
    public ModInfo GetInfo()
    {
        ModInfo modInfo = new(Name, Version ?? "1.0")
        {
            Description = Description,
        };
        return modInfo;
    }

    #endregion implements IEquatable

    public override string ToString() => Location;
}
