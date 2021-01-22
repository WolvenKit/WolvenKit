using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;

namespace CP77Tools.Tasks
{

    public static partial class ConsoleFunctions
    {

        public static int HashTask(string[] input, bool missing)
        {
            #region checks

            foreach (var s in input)
            {
                if (!string.IsNullOrEmpty(s))
                    logger.LogString(FNV1A64HashAlgorithm.HashString(s).ToString(), Logtype.Normal);
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
                /*await*/ hashService.ReloadLocally();
            }

            return 1;
        }
    }
}