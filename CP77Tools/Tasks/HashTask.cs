using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.Common.Tools.FNV1A;
using CP77Tools.Common.Services;

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
        
        public static async Task<int> UpdateHashesAsync()
        {
            var hashService = ServiceLocator.Default.ResolveType<IHashService>();
            if (await hashService.RefreshAsync())
            {
                // TODO: Would this be better managed entirely by IHashService
                await Program.Loadhashes();
            }

            return 1;
        }
    }
}