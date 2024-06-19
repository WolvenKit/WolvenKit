using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;
using WolvenKit.Common;
using WolvenKit.Core.Extensions;

namespace WolvenKit.App.Models.ProjectManagement.Project;

public sealed class Cp77Project(string location, string name, string modName) : IEquatable<Cp77Project>, ICloneable
{
    public string Name { get; set; } = name;

    /// <summary>
    /// Location of active project (the folder containing the .cdproj file)
    /// </summary>
    public string Location { get; set; } = location;

    public string ModName { get; set; } = modName;

    public int ActiveTab { get; set; } = 0;

    public string? Author { get; set; }

    public string? Email { get; set; }

    public string? Description { get; set; }

    public string? Version { get; set; }

    public static GameType GameType => GameType.Cyberpunk2077;


    /// <summary>
    /// Returns all files inside <see cref="FileDirectory"/> 
    /// </summary>
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


    /// <summary>
    /// Returns all files inside <see cref="ModDirectory"/> 
    /// </summary>
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


    /// <summary>
    /// Returns all files inside <see cref="RawDirectory"/> 
    /// </summary>
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


    /// <summary>
    /// Path to root level directory (where the .csproj file is)
    /// </summary>
    public string ProjectDirectory
    {
        get
        {
            var oldDir = Path.Combine(Path.GetDirectoryName(Location).NotNull(), Name).NotNull();
            return Directory.Exists(oldDir) ? oldDir : Path.GetDirectoryName(Location).NotNull();
        }
    }


    /// <summary>
    /// Path to /source/raw
    /// </summary>
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

    /// <summary>
    /// Path to /source/archive
    /// </summary>
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

    /// <summary>
    /// Path to /_backups
    /// </summary>
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

    /// <summary>
    /// Path to /source/raw
    /// </summary>
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


    /// <summary>
    /// Path to /source/customSounds
    /// </summary>
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

    /// <summary>
    /// Path to /source/resources
    /// </summary>
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


    /// <summary>
    /// Path to /source/resources/r6/tweaks
    /// </summary>
    public string ResourceTweakDirectory
    {
        get
        {
            var dir = Path.Combine(ResourcesDirectory, "r6", "tweaks", Name);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }

    /// <summary>
    /// Path to /source/resources/r6/scripts
    /// </summary>
    public string ResourceScriptsDirectory
    {
        get
        {
            var dir = Path.Combine(ResourcesDirectory, "r6", "scripts", Name);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }

    /// <summary>
    /// Path to /packed
    /// </summary>
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

    /// <summary>
    /// Path to /packed/mods
    /// </summary>
    public string PackedRedModDirectory
    {
        get
        {
            var dir = Path.Combine(PackedRootDirectory, "mods", ModName);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }

    /// <summary>
    /// Path to /packed/mods
    /// </summary>
    public string PackedLegacyModDirectory
    {
        get
        {
            var dir = Path.Combine(PackedRootDirectory, "archive", "pc", "mod");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            return dir;
        }
    }


    /// <summary>
    /// Path to /packed/archive/pc/mod or /packed/mods
    /// </summary>
    public string GetPackedArchiveDirectory(bool isRedMod)
    {
        var dir = isRedMod ? Path.Combine(PackedRedModDirectory, "archives") : Path.Combine(PackedRootDirectory, "archive", "pc", "mod");

        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }

    /// <summary>
    /// Path to /packed/customSounds
    /// </summary>
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

    /// <summary>
    /// Path to /packed/r6/tweaks
    /// </summary>
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

    public string GetRelativePath(string fullPath)
    {
        if (fullPath.Equals(FileDirectory, StringComparison.Ordinal))
        {
            return "";
        }
        // hack so that we get proper hashes
        if (fullPath.Equals(ModDirectory, StringComparison.Ordinal))
        {
            return "wkitmoddir";
        }
        if (fullPath.Equals(RawDirectory, StringComparison.Ordinal))
        {
            return "wkitrawdir";
        }
        if (fullPath.Equals(PackedRootDirectory, StringComparison.Ordinal))
        {
            return "wkitpackeddir";
        }

        if (fullPath.StartsWith(ModDirectory, StringComparison.Ordinal))
        {
            return fullPath[(ModDirectory.Length + 1)..];
        }
        if (fullPath.StartsWith(RawDirectory, StringComparison.Ordinal))
        {
            var rel = fullPath[(RawDirectory.Length + 1)..];
            return rel;
        }

        return fullPath.StartsWith(FileDirectory, StringComparison.Ordinal)
            ? fullPath[(FileDirectory.Length + 1)..]
            : fullPath.StartsWith(PackedRootDirectory, StringComparison.Ordinal) ? fullPath[(PackedRootDirectory.Length + 1)..] : fullPath;
    }

    // Conversions

    public FileSystemArchive AsArchive() => new(this);

    #region implements ICloneable

    public object Clone()
    {
        Cp77Project clone = new(Location, Name, ModName)
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
        ModInfo modInfo = new(ModName, Version ?? "1.0")
        {
            Description = Description,
        };
        return modInfo;
    }

    #endregion implements IEquatable

    public override string ToString() => Location;
}
