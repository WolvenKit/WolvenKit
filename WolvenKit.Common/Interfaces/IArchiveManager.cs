using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using DynamicData;
using DynamicData.Kernel;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common
{
    /// <summary>
    /// Top-level game bundle/archive manager
    /// </summary>
    public interface IArchiveManager : INotifyPropertyChanged
    {
        #region Properties

        SourceCache<IGameArchive, string> Archives { get; set; }

        IGameArchive? ProjectArchive { get; set; }

        public bool IsManagerLoading { get; }

        public bool IsManagerLoaded { get; }

        #endregion Properties

        public void LoadGameArchives(FileInfo executable);
        public void LoadArchive(string path, EArchiveSource source = EArchiveSource.Unknown);
        public void LoadModArchive(string filename, bool analyzeFiles = true);
        public void LoadModsArchives(FileInfo executable, bool analyzeFiles = true);
        public void LoadAdditionalModArchives(string archiveBasePath, bool analyzeFiles = true);

        public Dictionary<string, IEnumerable<IGameFile>> GetGroupedFiles();
        public Dictionary<string, IEnumerable<IGameFile>> GetGroupedFiles(ArchiveManagerScope searchScope);

        /// <summary>
        /// Checks if a file with the given hash exists in the ArchiveManager's current scope.
        /// </summary>
        /// <param name="hash">Unique hash of the file</param>
        /// <returns>An optional with the matching file</returns>
        public Optional<IGameFile> Lookup(ulong hash);

        /// <summary>
        /// Checks if a file with the given hash exists in the specified search scope.
        /// </summary>
        /// <param name="hash">Unique hash of the file</param>
        /// <param name="searchScope">BaseGame, Mod or Everywhere</param>
        /// <returns>An optional with the matching file</returns>
        public Optional<IGameFile> Lookup(ulong hash, ArchiveManagerScope searchScope);
        public IGameFile? GetGameFile(ResourcePath path, bool includeMods = true, bool includeProject = true);
        public CR2WFile? GetCR2WFile(ResourcePath path, bool includeMods = true, bool includeProject = true);

        IEnumerable<IGameArchive> GetModArchives();
    }
}
