using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.Common.Interfaces
{
    public interface IModTools
    {
        public Archive Pack(DirectoryInfo infolder, DirectoryInfo outpath, string modname = null);

        public bool ConvertXbmToDdsStream(Stream redInFile, Stream outstream, out DXGI_FORMAT texformat);


        public bool Import(RedRelativePath rawRelative, GlobalImportArgs args, DirectoryInfo outDir = null);
        bool ImportFolder(DirectoryInfo inDir, GlobalImportArgs args, DirectoryInfo outDir = null);


        public bool Export(FileInfo cr2wfile, GlobalExportArgs args, DirectoryInfo basedir = null,
            DirectoryInfo rawoutdir = null, ECookedFileFormat[] forcebuffers = null);

        bool RebuildBuffer(RedRelativePath rawRelativePath, DirectoryInfo outDir = null);

        void ExtractAll(Archive ar, DirectoryInfo outDir, string pattern = "", string regex = "", bool decompressBuffers = false);
        Task ExtractAllAsync(Archive ar, DirectoryInfo outDir, string pattern = "", string regex = "", bool decompressBuffers = false);

        public bool UncookSingle(
            Archive archive,
            ulong hash,
            DirectoryInfo outDir,
            GlobalExportArgs args,
            DirectoryInfo rawOutDir = null,
            ECookedFileFormat[] forcebuffers = null);
        void UncookAll(Archive ar, DirectoryInfo outDir, GlobalExportArgs args, bool unbundle = false, string pattern = "", string regex = "", DirectoryInfo rawOutDir = null, ECookedFileFormat[] forcebuffers = null);
    }

}
