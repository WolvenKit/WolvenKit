using System.IO;
using WolvenKit.Core.Wwise;

namespace CP77Tools.Tasks;

public partial class ConsoleFunctions
{
    public int WwiseTask(FileInfo path, FileInfo outpath, bool wem)
    {
        if (path is null)
        {
            return ERROR_BAD_ARGUMENTS;
        }

        outpath ??= new FileInfo(Path.ChangeExtension(path.FullName, ".ogg"));

        if (wem)
        {
            var inBuffer = File.ReadAllBytes(path.FullName);
            var oggBuffer = Wem.Convert(inBuffer);

            if (oggBuffer.Length == 0)
            {
                _loggerService.Error($"Failed to convert {path} to OGG");
                return ERROR_GENERAL_ERROR;
            }

            File.WriteAllBytes(outpath.FullName, oggBuffer);

            _loggerService.Success($"Finished converting {path} to OGG: {outpath}");
            return 0;
        }

        return ERROR_GENERAL_ERROR;
    }
}
