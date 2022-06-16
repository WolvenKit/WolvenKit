using System.IO;
using WolvenKit.Core.Wwise;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        public int WwiseTask(string path, string outpath, bool wem)
        {
            if (string.IsNullOrEmpty(path))
            {
                return 0;
            }

            if (string.IsNullOrEmpty(outpath))
            {
                outpath = Path.ChangeExtension(path, ".ogg");
            }

            if (wem)
            {
                var file = File.ReadAllBytes(path);
                using var ms = new MemoryStream(file);
                using var br = new BinaryReader(ms);

                var inBuffer = br.ReadBytes(file.Length);
                var oggBuffer = Wem.Convert(inBuffer);

                if (oggBuffer.Length == 0)
                {
                    _loggerService.Error($"Failed to convert {path} to OGG");
                    return 0;
                }

                File.WriteAllBytes(outpath, oggBuffer);

                _loggerService.Success($"Finished converting {path} to OGG: {outpath}");
            }

            return 1;
        }
    }
}
