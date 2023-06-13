using System.IO;
using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.Modkit.RED4
{
    // TODO:  I have a feeling this could be somewhere else, but I don't know where to move these funcs for now. -wopss

    public static class RedMod
    {
        public static string GetReImportArgs(string depot, string input, string animset, string output = "", string animationRename = "")
        {
            var args = $"animation-import -depot=\"{depot}\" -input=\"{input}\" -animset={animset}";
            if (!string.IsNullOrEmpty(output))
            {
                args += $" -output={output}";
            }
            if (!string.IsNullOrEmpty(animationRename))
            {
                args += $" -animationRename={animationRename}";
            }

            return args;
        }

        public static string GetReImportArgs(this ReImportArgs a) => GetReImportArgs(a.Depot, a.Input, a.Animset, a.Output, a.AnimationToRename);

        public static string GetExportArgs(string depot, string input, string output = "")
        {
            var args = $"resource-export -depot=\"{depot}\" -input=\"{input}\"";
            if (!string.IsNullOrEmpty(output))
            {
                args += $" -output={output}";
            }

            return args;
        }
    }
}
