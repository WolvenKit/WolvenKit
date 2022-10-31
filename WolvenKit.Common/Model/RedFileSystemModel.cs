using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ReactiveUI;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Common.Model
{
    public class RedFileSystemModel : ReactiveObject
    {
        public RedFileSystemModel(string fullname)
        {
            FullName = fullname;
        }

        public string Name => _name ??= new DirectoryInfo(FullName).Name;

        public string FullName { get; }

        public ConcurrentDictionary<string, RedFileSystemModel> Directories { get; } = new();

        public IEnumerable<RedFileSystemModel> RedFileSystemModels => Directories.Values.OrderBy(x => x.Name);

        public ConcurrentQueue<IGameFile> Files { get; } = new();

        public string Extension => IsExpanded
            ? nameof(ECustomImageKeys.OpenDirImageKey)
            : nameof(ECustomImageKeys.ClosedDirImageKey);

        private bool _isExpanded;
        private string _name;

        public bool IsExpanded
        {
            get => _isExpanded;
            set => this.RaiseAndSetIfChanged(ref _isExpanded, value);
        }
    }
}
