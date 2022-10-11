using System.IO;
using System.Threading.Tasks;
using WolvenKit.Common;

namespace CP77Tools.Tasks
{
    public interface IConsoleFunctions
    {
        public void ArchiveTask(string[] path, string pattern, string regex, bool diff, bool list);
        public void UnbundleTask(string[] path, DirectoryInfo outpath, string hash, string pattern, string regex,
            bool DEBUG_decompress = false);
        public Task Cr2wTask(string[] path, DirectoryInfo outpath, bool deserialize, bool serialize, string pattern,
            string regex, ETextConvertFormat format);
        public void ExportTask(string[] path, DirectoryInfo outDir, EUncookExtension? uncookext, bool? flip,
            ECookedFileFormat[] forcebuffers);
        public Task ImportTask(string[] path, DirectoryInfo outDir, bool keep);
        public void ConflictsTask(DirectoryInfo path, bool structured);
        public int OodleTask(FileInfo path, FileInfo outpath, bool decompress, bool compress);
        public void PackTask(string[] path, DirectoryInfo outpath);
        public void UncookTask(string[] path, UncookTaskOptions options);
    }
}
