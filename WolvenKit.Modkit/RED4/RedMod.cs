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
                args += $" -output={output.Replace(".anims", "")}";
            }
            if (!string.IsNullOrEmpty(animationRename))
            {
                args += $" -animationRename={animationRename}";
            }

            return args;
        }

        public static string GetReImportArgs(this ReImportArgs a) => GetReImportArgs(a.Depot, a.Input, a.Animset, a.Output, a.AnimationToRename);

        /// <summary>
        /// Helper to assemble redmod export commandline args
        /// </summary>
        /// <param name="depot">Absolute path to depot</param>
        /// <param name="input">Relative path of the input file (relative to depot)</param>
        /// <param name="output">Absolute path of the output file</param>
        /// <returns></returns>
        public static string GetExportArgs(DirectoryInfo depot, string input, FileInfo output)
        {
            var args = $"resource-export -depot=\"{depot.FullName}\" -input=\"{input}\" -output=\"{output.FullName}\"";

            return args;
        }

        /// <summary>
        /// Helper to assemble redmod import commandline args
        /// </summary>
        /// <param name="depot">Absolute path to depot</param>
        /// <param name="input">Absolute path of the input file</param>
        /// <param name="output">Relative path of the output file (relative to depot)</param>
        /// <returns></returns>
        public static string GetImportArgs(DirectoryInfo depot, FileInfo input, string output)
        {
            var args = $"resource-import -depot=\"{depot.FullName}\" -input=\"{input.FullName}\"";
            if (!string.IsNullOrEmpty(output))
            {
                args += $" -output={output}";
            }

            return args;
        }
    }
}
