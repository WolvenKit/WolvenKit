using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.Modkit.RED4
{
    public static class RedMod
    {
        public static string GetReImportArgs(string gameRoot, string input, string animset, string output = "", string animationRename = "")
        {
            var args = $"import -gameRoot=\"{gameRoot}\" -input=\"{input}\" -animset={animset}";
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

    }
}