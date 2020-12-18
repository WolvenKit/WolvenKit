using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Catel.Collections;
using CP77Tools.Model;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.CR2W;

namespace CP77Tools
{

    public static partial class ConsoleFunctions
    {

        public static int HashTask(string input, bool missing)
        {
            #region checks

            if (!string.IsNullOrEmpty(input))
            {
                Console.WriteLine(FNV1A64HashAlgorithm.HashString(input));
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