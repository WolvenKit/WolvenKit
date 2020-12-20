using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CP77.Common.Tools.FNV1A;

namespace CP77Tools.Tasks
{

    public static partial class ConsoleFunctions
    {

        public static int HashTask(string input, bool missing)
        {
            #region checks

            if (!string.IsNullOrEmpty(input))
            {
                logger.LogString(FNV1A64HashAlgorithm.HashString(input).ToString(), WolvenKit.Common.Services.Logtype.Normal);
            }

            #endregion

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
                            Hashdict.Add(hash, line);
                    }
                    else
                    {
                        if (!bad.ContainsKey(hash))
                            bad.Add(hash, line);
                    }
                    
                }



            }
            

            return 1;
        }
    }
}