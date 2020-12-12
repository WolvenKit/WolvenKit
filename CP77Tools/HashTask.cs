using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Catel.Collections;
using ConsoleProgressBar;
using CP77Tools.Model;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.CR2W;

namespace CP77Tools
{

    public static partial class ConsoleFunctions
    {

        public static int HashTask(string input)
        {
            #region checks

            if (!string.IsNullOrEmpty(input))
            {
                Console.WriteLine(FNV1A64HashAlgorithm.HashString(input));
            }

            #endregion

            
            

            return 1;
        }
    }
}