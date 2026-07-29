using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using WolvenKit.Common;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Models;

public class FileSystemModel : INotifyPropertyChanged
{
    public const string ProjectDirName = "<ProjectDir>";

   private readonly string _projectDirectory;
    private string _name;
    private string _gameRelativePath = null!;
    private long _fileSize;
    private string _fileSizeStr = null!;
    private string _extension = "default";

    [Browsable(false)] public FileSystemModel? Parent { get; }

    public string Name
    {
        get => _name;
        private set => SetField(ref _name, value);
    }

    [Browsable(false)] public string RawRelativePath { get; private set; }

    [Display(Name = "Relative Path")]
    public string GameRelativePath
    {
        get => _gameRelativePath;
        private set => SetField(ref _gameRelativePath, value);
    }

    [Display(Name = "System Path")] public string FullName { get; private set; } = null!;

    [Browsable(false)]
    public ulong Hash
    {
        get
        {
            if (Parent?.Extension == Constants.ModDirectoryTop)
            {
                if (Parent.RawRelativePath == "archive" && ulong.TryParse(Path.GetFileNameWithoutExtension(Name), out var hash))
                {
                    return hash;
                }
                else
                {
                    return ResourcePath.CalculateHash(GameRelativePath);
                }
            }

            return 0;
        }
    }

    [Display(Name = "Hash")] public string HashStr => Hash.ToString();

    [Browsable(false)]
    public long FileSize
    {
        get => _fileSize;
        private set => SetField(ref _fileSize, value);
    }

    [Display(Name = "File Size")]
    public string FileSizeStr
    {
        get => _fileSizeStr;
        private set => SetField(ref _fileSizeStr, value);
    }

    public string Extension
    {
        get => _extension;
        private set => SetField(ref _extension, value);
    }

    [Browsable(false)] public DispatchedObservableCollection<FileSystemModel> Children { get; } = new();
    [Browsable(false)] public bool IsDirectory { get; }

    private bool _isExpanded;

    /// <summary>
    /// Indicates whether this directory node is expanded in the Project Explorer.
    /// This is the source of truth for expansion state and survives tree rebuilds.
    /// </summary>
    public bool IsExpanded
    {
        get => _isExpanded;
        set => SetField(ref _isExpanded, value);
    }

    /// <summary>
    /// FileSystemModel represents a file or directory on-disk.
    /// </summary>
    /// <param name="parent"></param><remark>FileSystemModel of the parent.</remark>
    /// <param name="name"></param><remark>Name of the file with extension but no paths.</remark>
    /// <param name="rawRelativePath"></param><remark>Path above 'source' to the file. E.g. archive/worlds/myfile.ent</remark>
    /// <param name="isDirectory"></param>
    public FileSystemModel(FileSystemModel? parent, string name, string rawRelativePath, bool isDirectory, bool isExpanded = false, bool shouldPublish = true)
    {
        Parent = parent;

        if (Parent == null)
        {
            _projectDirectory = rawRelativePath;
        }
        else
        {
            _projectDirectory = Parent._projectDirectory;
        }

        _name = name;
        RawRelativePath = rawRelativePath;
        IsDirectory = isDirectory;
        _isExpanded = isDirectory && isExpanded; // only directories can be expanded

        GetMetadata();
    }

    public void Rename(string? newName = null, bool updateChildren = true)
    {
        if (Parent == null)
        {
            throw new Exception();
        }

        if (newName != null)
        {
            Name = newName;
        }

        RawRelativePath = Path.Combine(Parent.RawRelativePath, Name);

        GetMetadata();

        if (!updateChildren)
        {
            return;
        }

        foreach (var child in Children)
        {
            child.Rename();
        }
    }

    public void UpdateFileInfo()
    {
        FileSize = new FileInfo(FullName).Length;
        FileSizeStr = GetFileSizeStr(FileSize);
    }

    private void GetMetadata()
    {
        FullName = Path.Combine(_projectDirectory, RawRelativePath);

        if (IsDirectory)
        {
            if (RawRelativePath.Equals("archive", StringComparison.CurrentCultureIgnoreCase))
            {
                Extension = Constants.ModDirectoryTop;
                GameRelativePath = "";
            }
            else if (RawRelativePath.Equals("raw", StringComparison.CurrentCultureIgnoreCase))
            {
                Extension = Constants.RawDirectoryTop;
                GameRelativePath = "";
            }
            else if (RawRelativePath.Equals("resources", StringComparison.CurrentCultureIgnoreCase))
            {
                Extension = Constants.ResourceDirectoryTop;
                GameRelativePath = "";
            }
            else if (Parent != null)
            {
                Extension = Parent.Extension;

                switch (Extension)
                {
                    case Constants.ModDirectoryTop:
                        GameRelativePath = RawRelativePath[8..];
                        break;
                    case Constants.RawDirectoryTop:
                        GameRelativePath = RawRelativePath[4..];
                        break;
                    case Constants.ResourceDirectoryTop:
                        GameRelativePath = RawRelativePath[10..];
                        break;
                    default:
                        var split =
                            RawRelativePath.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)[1..];
                        GameRelativePath = Path.Combine(split);
                        break;
                }
            }
        }
        else
        {
            Extension = Path.GetExtension(Name).TrimStart('.');

            if (Parent != null)
            {
                GameRelativePath = Parent.GameRelativePath + Path.DirectorySeparatorChar + Name;
            }

            UpdateFileInfo();
        }
    }

    public static string GetFileSizeStr(long fileSize)
    {
        string[] sizes = ["B", "KB", "MB", "GB", "TB"];
        double len = fileSize;
        var order = 0;
        while (len >= 1024 && order++ < sizes.Length - 1)
        {
            len /= 1024;
        }

        return string.Format(CultureInfo.InvariantCulture, "{0:0.##} {1}", len, sizes[order]);
    }

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    private bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
        {
            return false;
        }

        field = value;

        if (ShouldPublish(propertyName))
        {
            OnPropertyChanged(propertyName);
        }

        return true;
    }

    private bool ShouldPublish(string? propertyName)
    {
        var isBlacklisted =
            propertyName == null
            || propertyName == nameof(RawRelativePath)
            || propertyName == nameof(IsDirectory)
            || propertyName == nameof(FullName);

        return !isBlacklisted;
    }

    #endregion
}
