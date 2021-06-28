using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Common.FNV1A;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

        public int HashTask(string[] input, bool missing)
        {
            #region checks

            if (input is {Length: > 0})
            {
                foreach (var s in input)
                {
                    if (!string.IsNullOrEmpty(s))
                    {
                        _loggerService.Info(FNV1A64HashAlgorithm.HashString(s).ToString());
                    }
                }
            }

            #endregion checks

            if (missing)
            {
                var missingh = File.ReadAllLines(@"C:\Gog\Cyberpunk 2077\archive\pc\content\missinghashes.txt");
                var lines = File.ReadAllLines(@"X:\cp77\langs-work.txt");
                var Hashdict = new Dictionary<ulong, string>();
                var bad = new Dictionary<ulong, string>();

                foreach (var line in lines)
                {
                    var hash = FNV1A64HashAlgorithm.HashString(line);

                    if (missingh.Contains(hash.ToString()))
                    {
                        if (!Hashdict.ContainsKey(hash))
                        {
                            Hashdict.Add(hash, line);
                        }
                    }
                    else
                    {
                        if (!bad.ContainsKey(hash))
                        {
                            bad.Add(hash, line);
                        }
                    }
                }
            }

            return 1;
        }

        #endregion Methods
    }
}
