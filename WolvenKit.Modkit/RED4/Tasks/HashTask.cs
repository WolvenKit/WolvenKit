using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Common.FNV1A;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

        public int HashTask(string[] input, DirectoryInfo inputDir)
        {

            if (input is { Length: > 0 })
            {
                foreach (var s in input)
                {
                    if (!string.IsNullOrEmpty(s))
                    {
                        _loggerService.Info(FNV1A64HashAlgorithm.HashString(s).ToString());
                    }
                }
            }

            if (inputDir != null)
            {
                if (!inputDir.Exists)
                {
                    _loggerService.Error(new DirectoryNotFoundException(inputDir.FullName).Message);
                }

                _archiveManager.LoadFromFolder(inputDir);

                List<ulong> missing = new();

                var binfiles = _archiveManager.GetGroupedFiles()[".bin"];
                missing = binfiles.Select(_ => _.NameHash64).ToList();

                var missinghashtxt = Path.Combine(inputDir.FullName, "missinghashes.txt");
                using var missingWriter = File.CreateText(missinghashtxt);
                for (var i = 0; i < missing.Count; i++)
                {
                    var mh = missing[i];
                    missingWriter.WriteLine(mh);
                    _progressService.Report((i + 1) / (float)missing.Count);
                }



            }





            return 1;
        }

        #endregion Methods
    }
}
