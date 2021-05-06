using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;
using WolvenKit.Common.Wcc;

namespace WolvenKit.Common.Interfaces
{
    public interface IWccService
    {
        public void CreateFallBackSeedFile(string seedfile);


        public void CleanupDirectories();
        public void CreateVirtualLinks();

        public Task<int> GenerateCache(EArchiveType cachetype, bool packmod, bool packdlc);



        public Task<int> Pack(bool packmod, bool packdlc);


        /// <summary>
        /// Adds all file dependencies (cr2w imports) to a specified folder
        /// retaining relative paths
        /// </summary>
        /// <param name="importfilepath"></param>
        /// <param name="recursive"></param>
        /// <param name="silent"></param>
        /// <param name="alternateOutDirectory"></param>
        /// <returns></returns>
        Task AddAllImportsAsync(string importfilepath,
            bool recursive = false, bool silent = false, string alternateOutDirectory = "", bool logonly = false);

        /// <summary>
        ///
        /// </summary>
        /// <param name="folder"></param>
        /// <param name="outfolder"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        Task DumpFile(string folder, string outfolder, string file = "");

        /// <summary>
        /// Exports an existing file in the ModProject (w2mesh, redcloth) to the modProject
        /// </summary>
        /// <param name="fullpath"></param>
        /// <returns></returns>
        Task ExportFileToMod(string fullpath);

        /// <summary>
        /// Cooks Files in the ModProject's folders (Bunde, TextureCache etc...)
        /// </summary>
        /// <returns></returns>
        Task<int> Cook();

        /// <summary>
        /// Create metadata.store file
        /// </summary>
        /// <param name="packmod"></param>
        /// <param name="dlcmod"></param>
        /// <returns></returns>
        Task<int> CreateMetaData(bool packmod, bool dlcmod);

        /// <summary>
        /// Deprecated, Use the Modkit instead
        /// Kept for a neat hack tricking wcc_lite into dumping individual files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void RequestWccliteFileDumpfile(object sender, RequestFileOpenArgs e);

        /// <summary>
        /// Unbundles a file with the given relativepath from either the Game or the Mod BundleManager
        /// and adds it to the depot, optionally copying to the project
        /// </summary>
        /// <param name="relativePath"></param>
        /// <param name="projectFolder"></param>
        /// <param name="bundleType"></param>
        /// <param name="alternateOutDirectory"></param>
        /// <param name="loadmods"></param>
        /// <param name="silent"></param>
        /// <returns></returns>
        string UnbundleFile(string relativePath, bool isDlc, EProjectFolders projectFolder, EArchiveType bundleType = EArchiveType.Bundle, string alternateOutDirectory = "", bool loadmods = false, bool silent = false);

        /// <summary>
        /// Uncooks a single file to a temp directory
        /// </summary>
        /// <param name="relativePath"></param>
        /// <param name="newpath"></param>
        /// <param name="indir"></param>
        /// <returns></returns>
        Task<int> UncookFileToPath(string basedir, string relativePath, bool isDLC, string alternateOutDirectory = "");

        /// <summary>
        /// runs wcc_lite with specified command
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        Task<int> RunCommand(WCC_Command cmd);
    }
}
