using System.IO;
using System.Threading.Tasks;

namespace CP77Tools.Tasks;

public partial class ConsoleFunctions
{
    /// <summary>
    /// Packs a folder or list of folders to .archive files.
    /// </summary>
    /// <param name="path"></param>
    /// <param name="outpath"></param>
    public int PackTask(DirectoryInfo[] path, DirectoryInfo outpath)
    {
        if (path == null || path.Length < 1)
        {
            _loggerService.Error("Please fill in an input path.");
            return ERROR_BAD_ARGUMENTS;
        }

        var result = 0;
        Parallel.ForEach(path, file => result += PackTaskInner(file, outpath));
        return result > 0 ? ERROR_COMPLETED_WITH_ERRORS : 0;
    }

    private int PackTaskInner(DirectoryInfo path, DirectoryInfo outpath, int cp = 0)
    {
        #region checks

        if (path is null)
        {
            _loggerService.Error("Please fill in an input path.");
            return ERROR_BAD_ARGUMENTS;
        }

        if (!path.Exists)
        {
            _loggerService.Error("Input path does not exist.");
            return ERROR_BAD_ARGUMENTS;
        }

        var basedir = path;
        if (basedir?.Parent == null)
        {
            return ERROR_BAD_ARGUMENTS;
        }

        DirectoryInfo outDir;
        if (outpath is null)
        {
            outDir = basedir.Parent;
        }
        else
        {
            outDir = outpath;
            if (!outDir.Exists)
            {
                outDir = Directory.CreateDirectory(outpath.FullName);
            }
        }

        #endregion checks

        if (!_modTools.Pack(basedir, outDir))
        {
            _loggerService.Error($"Packing failed.");
            return ERROR_GENERAL_ERROR;
        }

        return 0;
    }
}
