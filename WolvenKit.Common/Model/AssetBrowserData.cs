using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using ReactiveUI;
using WolvenKit.RED4.CR2W.Archive;
using System;

namespace WolvenKit.Common.Model
{
    public enum EntryType
    {
        Directory,
        File,
        MoveUP
    }

    public class FileEntryViewModel
    {
        private readonly IGameFile _fileEntry;

        public FileEntryViewModel(IGameFile fileEntry)
        {
            _fileEntry = fileEntry;
        }

        public string Extension => _fileEntry.Extension.TrimStart('.');

        public string Name => Path.GetFileName(_fileEntry.Name);
        public string FullName => _fileEntry.Name;
        public string Archive => _fileEntry.Archive.Name;
        [Display(Name = "Hash")] public string HashStr => Key.ToString();

        [Browsable(false)] public ulong Key => _fileEntry.Key;


        public string Size => FormatSize(_fileEntry.Size);
        string FormatSize(uint size)
        {
            string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };

            var counter = 0;
            var number = (decimal)size;
            while (Math.Round(number / 1024) >= 1)
            {
                number = number / 1024;
                counter++;
            }
            return $"{number:n1} {suffixes[counter]}";
        }

        public IGameFile GetGameFile() => _fileEntry;

    }
}
