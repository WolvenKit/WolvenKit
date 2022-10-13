using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Common.FNV1A;

namespace CP77Tools.Tasks;

public partial class ConsoleFunctions
{
    public int HashTask(string[] input)
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

            return 0;
        }

        return ERROR_GENERAL_ERROR;
    }
}
