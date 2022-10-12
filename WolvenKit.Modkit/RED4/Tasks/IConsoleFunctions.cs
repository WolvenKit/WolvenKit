using System.IO;
using System.Threading.Tasks;
using WolvenKit.Common;

namespace CP77Tools.Tasks
{
    public interface IConsoleFunctions
    {
        public void ArchiveTask(FileSystemInfo[] path, string pattern, string regex, bool diff, bool list);
        public void UnbundleTask(FileSystemInfo[] path, DirectoryInfo outpath, string hash, string pattern, string regex,
            bool DEBUG_decompress = false);
        public Task Cr2wTask(FileSystemInfo[] path, DirectoryInfo outpath, bool deserialize, bool serialize, string pattern,
            string regex, ETextConvertFormat format);
        public void ExportTask(FileSystemInfo[] path, DirectoryInfo outDir, EUncookExtension? uncookext, bool? flip,
            ECookedFileFormat[] forcebuffers);
        public Task ImportTask(FileSystemInfo[] path, DirectoryInfo outDir, bool keep);
        public void ConflictsTask(DirectoryInfo path, bool structured);
        public int OodleTask(FileInfo path, FileInfo outpath, bool decompress, bool compress);
        public void PackTask(DirectoryInfo[] path, DirectoryInfo outpath);
        public void UncookTask(FileSystemInfo[] path, UncookTaskOptions options);
    }
}
