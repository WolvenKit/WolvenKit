using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Models;

public class FileModel : ObservableObject
{
    private readonly string _extension = ".default";

    public const string s_moddir = "wkitmoddir";

    public const string s_rawdir = "wkitrawdir";

    public FileModel(FileSystemInfo fileSystemInfo, Cp77Project project)
    {
        Project = project;
        FullName = fileSystemInfo.FullName;
        Name = fileSystemInfo.Name;

        string parentFullName;

        if (fileSystemInfo is DirectoryInfo directoryInfo)
        {
            IsDirectory = true;
            parentFullName = directoryInfo.Parent.NotNull().FullName;
            _extension = ECustomImageKeys.OpenDirImageKey.ToString();
            if (FullName.StartsWith(project.ResourcesDirectory))
            {
                _extension = Constants.ResourceDirectoryTop;
            }
            else if (FullName.StartsWith(project.ModDirectory))
            {
                _extension = Constants.ModDirectoryTop;
            }
            else if (FullName.ToLower().StartsWith(project.RawDirectory.ToLower()))
            {
                _extension = Constants.RawDirectoryTop;
            }

            FileSize = null;
        }
        else if (fileSystemInfo is FileInfo fileInfo)
        {
            IsDirectory = false;
            parentFullName = fileInfo.Directory.NotNull().FullName;
            _extension = fileInfo.Extension;
            var kilobyte = (double)fileInfo.Length / 1024;
            if (kilobyte > 1000)
            {
                FileSize = $"{kilobyte / 1024:F2} MB"; // Read the file size here
            }
            else
            {
                FileSize = $"{kilobyte :F2} KB"; // Read the file size here
            }

        }
        else
        {
            throw new NotSupportedException();
        }

        Hash = GenerateKey(FullName, project);
        ParentHash = GenerateKey(parentFullName, project);
        RelativePath = GetRelativeName(FullName, project);
    }

    public string? FileSize { get; set; }

    #region properties

    [Display(Name = "System Path")] public string FullName { get; }

    [Display(Name = "Relative Path")] public string RelativePath { get; }

    public string Name { get; }

    public string Extension => GetExtension();

    [Display(Name = "Hash")] public string HashStr => Hash.ToString();


    [Browsable(false)] public Cp77Project Project { get; }

    [Browsable(false)] public ulong Hash { get; }

    [Browsable(false)] public bool IsDirectory { get; }

    [Browsable(false)] public ulong ParentHash { get; }

    [Browsable(false)] public bool IsExpanded { get; set; }

    [Browsable(false)]
    public bool IsConvertable => !IsDirectory 
                                 && !string.IsNullOrEmpty(GetExtension())
                                 && Enum.GetNames(typeof(EConvertableFileFormat)).Contains(GetExtension());
    [Browsable(false)]
    public bool IsImportable
    {
        get
        {
            var ext = GetExtension();
            var dbg_disabled = new List<string>()
            {
                "bmp",
                "jpg",
                //"png",
                //"tga",
                "tiff",
            };

            return !IsDirectory
          && !string.IsNullOrEmpty(ext)
          && Enum.GetNames(typeof(ERawFileFormat)).Contains(ext)
          && !dbg_disabled.Contains(ext);
        }
    }

    [Browsable(false)]
    public bool IsExportable => !IsDirectory && !string.IsNullOrEmpty(GetExtension()) && Enum.GetNames(typeof(ECookedFileFormat)).Contains(GetExtension());

    #endregion

    public string GetExtension() => _extension.TrimStart('.');

    public override int GetHashCode() => (int)Hash;

    public ulong GetRedHash(Cp77Project project) => FNV1A64HashAlgorithm.HashString(GetRelativeName(FullName, project));

    public static string GetRelativeName(string FullName, Cp77Project project)
    {
        if (project == null)
        {
            return FullName;
        }

        var filedir = project.FileDirectory;
        var moddir = project.ModDirectory;
        var rawDirectory = project.RawDirectory;
        var packedDir = project.PackedRootDirectory;

        if (FullName.Equals(filedir, StringComparison.Ordinal))
        {
            return "";
        }
        // hack so that we get proper hashes
        if (FullName.Equals(moddir, StringComparison.Ordinal))
        {
            return s_moddir;
        }
        if (FullName.Equals(rawDirectory, StringComparison.Ordinal))
        {
            return s_rawdir;
        }
        if (FullName.Equals(packedDir, StringComparison.Ordinal))
        {
            return "wkitpackeddir";
        }

        if (FullName.StartsWith(moddir, StringComparison.Ordinal))
        {
            return FullName[(moddir.Length + 1)..];
        }
        if (FullName.StartsWith(rawDirectory, StringComparison.Ordinal))
        {
            var rel = FullName[(rawDirectory.Length + 1)..];
            return rel;
        }

        return FullName.StartsWith(filedir, StringComparison.Ordinal)
            ? FullName[(filedir.Length + 1)..]
            : FullName.StartsWith(packedDir, StringComparison.Ordinal) ? FullName[(packedDir.Length + 1)..] : FullName;
        //throw new System.NullReferenceException("fuzzy exception");
    }

    public static ulong GenerateKey(string fullname, Cp77Project? project)
    {
        if (project == null)
        {
            return 0;
        }

        if (fullname.Equals(project.FileDirectory, StringComparison.Ordinal))
        {
            return 0;
        }
        else if (fullname.Equals(project.PackedRootDirectory, StringComparison.Ordinal))
        {
            return 0;
        }
        else
        {
            if (fullname.StartsWith(project.ModDirectory))
            {
                var relpath = Path.GetRelativePath(project.ModDirectory, fullname);

                if (relpath != ".")
                {
                    var regex = new Regex("^(\\d+)\\.");
                    var match = regex.Match(relpath);
                    if (match.Success && ulong.TryParse(match.Groups[1].Value, out var hash))
                    {
                        return hash;
                    }
                    return ResourcePath.CalculateHash(relpath);
                }
            }

            return ResourcePath.CalculateHash(fullname);
        }
    }

    public static FileModel Create(string path, Cp77Project project)
    {
        var attr = File.GetAttributes(path);
        if (attr.HasFlag(FileAttributes.Directory))
        {
            return new FileModel(new DirectoryInfo(path), project);
        }
        return new FileModel(new FileInfo(path), project);
    }
}
