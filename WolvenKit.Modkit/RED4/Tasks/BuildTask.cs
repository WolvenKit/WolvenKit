using System.IO;
using System.Threading.Tasks;

namespace CP77Tools.Tasks;

public partial class ConsoleFunctions
{
    /// <summary>
    /// Builds a list of projects like WolvenKit application.
    /// </summary>
    /// <param name="paths">List of path per WolvenKit project to build.</param>
    public int BuildTask(DirectoryInfo[] paths)
    {
        if (paths.Length < 1)
        {
            _loggerService.Error("Please fill in at least one input path.");
            return ERROR_BAD_ARGUMENTS;
        }

        var result = 0;
        Parallel.ForEach(paths, file => result += BuildTaskInner(file));
        return result > 0 ? ERROR_COMPLETED_WITH_ERRORS : 0;
    }

    private int BuildTaskInner(DirectoryInfo path, int cp = 0)
    {
        if (!_modTools.Build(path))
        {
            _loggerService.Error($"Building failed for input path: \"{path.FullName}\".");
            return ERROR_GENERAL_ERROR;
        }

        return 0;
    }
}