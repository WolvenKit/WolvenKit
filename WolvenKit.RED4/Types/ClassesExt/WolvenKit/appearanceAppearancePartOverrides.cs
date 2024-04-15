namespace WolvenKit.RED4.Types;

public partial class appearanceAppearancePartOverrides
{
    public override IEnumerable<string> GetHiddenFieldNames()
    {
        // .app file: appearance definition: parts override - ArchiveXL will handle this
        return base.GetHiddenFieldNames().Concat(["partResource"]);
    }
}

