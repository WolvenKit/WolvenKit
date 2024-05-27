using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using WolvenKit.Common;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Models;

public class FileSystemModel : INotifyPropertyChanged
{
    public const string ProjectDirName = "<ProjectDir>";

    private string _fileSizeStr = null!;
    private long _fileSize;

    [Browsable(false)] public FileSystemModel? Parent { get; }

    public string Name { get; }
    [Browsable(false)] public string RawRelativePath { get; private set; }
    [Display(Name = "Relative Path")] public string GameRelativePath { get; private set; } = null!;
    [Display(Name = "System Path")] public string FullName { get; private set; } = null!;

    [Browsable(false)] public ulong Hash { get; private set; }
    [Display(Name = "Hash")] public string HashStr { get; private set; } = "0";

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

    public string Extension { get; } = "default";

    [Browsable(false)] public DispatchedObservableCollection<FileSystemModel> Children { get; } = new();
    [Browsable(false)] public bool IsDirectory { get; }

    public FileSystemModel(FileSystemModel? parent, string name, string relativePath, bool isDirectory)
    {
        Parent = parent;
        Name = name;
        RawRelativePath = relativePath;
        IsDirectory = isDirectory;

        GetMetadata();

        if (IsDirectory)
        {
            Extension = ECustomImageKeys.OpenDirImageKey.ToString();
            if (relativePath.Equals("archive", StringComparison.CurrentCultureIgnoreCase))
            {
                Extension = Constants.ModDirectoryTop;
            }
            else if (relativePath.Equals("raw", StringComparison.CurrentCultureIgnoreCase))
            {
                Extension = Constants.RawDirectoryTop;
            }
            else if (relativePath.Equals("resources", StringComparison.CurrentCultureIgnoreCase))
            {
                Extension = Constants.ResourceDirectoryTop;
            }
            else if (Parent != null)
            {
                Extension = Parent.Extension;
            }
        }
        else
        {
            Extension = Path.GetExtension(Name).TrimStart('.');

            UpdateFileInfo();
        }
    }

    public void UpdateFileInfo()
    {
        FileSize = new FileInfo(FullName).Length;
        FileSizeStr = GetFileSizeStr(FileSize);
    }

    private void GetMetadata()
    {
        var hashParts = new List<string>();

        var root = this;
        var current = this;
        while (current != null)
        {
            if (current.Parent?.Name != ProjectDirName && current.Name != ProjectDirName)
            {
                hashParts.Add(current.Name);
            }

            root = current;
            current = current.Parent;
        }
        hashParts.Reverse();

        GameRelativePath = string.Join(ResourcePath.DirectorySeparatorChar, hashParts);
        FullName = Path.Combine(root.RawRelativePath, RawRelativePath);

        if (Parent?.Extension == Constants.ModDirectoryTop)
        {
            if (Parent.RawRelativePath == "archive" && ulong.TryParse(Path.GetFileNameWithoutExtension(Name), out var hash))
            {
                Hash = hash;
            }
            else
            {
                Hash = ResourcePath.CalculateHash(GameRelativePath);
            }

            HashStr = Hash.ToString();
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

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
        {
            return false;
        }

        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    #endregion
}