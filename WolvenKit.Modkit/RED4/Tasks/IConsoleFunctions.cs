using System.IO;
using System.Threading.Tasks;
using WolvenKit.Common;

namespace CP77Tools.Tasks
{
    public interface IConsoleFunctions
    {
        public int ArchiveTask(FileSystemInfo[] path, string pattern, string regex, bool diff, bool list);
        public int UnbundleTask(FileSystemInfo[] path, UnbundleTaskOptions options);
        public Task<int> Cr2wTask(FileSystemInfo[] path, DirectoryInfo outpath, bool deserialize, bool serialize, string pattern,
            string regex, ETextConvertFormat format, bool print);
        public int ExportTask(FileSystemInfo[] path, ExportTaskOptions options);
        public Task<int> ImportTask(FileSystemInfo[] path, DirectoryInfo outDir, bool keep);
        public int ConflictsTask(DirectoryInfo path, bool structured);
        public int OodleTask(FileInfo path, FileInfo outpath, bool decompress, bool compress);
        public int PackTask(DirectoryInfo[] path, DirectoryInfo outpath);
        public int UncookTask(FileSystemInfo[] path, UncookTaskOptions options);
    }
}
