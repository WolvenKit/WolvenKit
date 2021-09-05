using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace WolvenKit.Common.Model
{
    public class RedFileSystemModel : ReactiveObject
    {
        public RedFileSystemModel(string fullname)
        {
            FullName = fullname;
        }

        public string Name => Path.GetFileName(FullName);

        public string FullName { get; set; }

        public List<RedFileSystemModel> Directories { get; } = new();

        public List<ulong> Files { get; } = new();

        public string Extension => IsExpanded
            ? nameof(ECustomImageKeys.OpenDirImageKey)
            : nameof(ECustomImageKeys.ClosedDirImageKey);

        private bool _isExpanded;
        public bool IsExpanded
        {
            get => _isExpanded;
            set => this.RaiseAndSetIfChanged(ref _isExpanded, value);
        }

    }
}
