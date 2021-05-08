using System.Collections.Generic;
using System.IO;
using System.Linq;
using Catel.IoC;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

        public int HashTask(string[] input, bool missing, string prepare)
        {
            #region checks

            if (input is {Length: > 0})
            {
                foreach (var s in input)
                {
                    if (!string.IsNullOrEmpty(s))
                    {
                        _loggerService.LogString(FNV1A64HashAlgorithm.HashString(s).ToString(), Logtype.Normal);
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

            if (!string.IsNullOrEmpty(prepare))
            {
                _hashService.Serialize(prepare);
            }

            return 1;
        }

        #endregion Methods
    }
}
