namespace WolvenKit.RED4.Types;

public partial class appearancePartComponentOverrides
{
    public override IEnumerable<string> GetHiddenFieldNames()
    {
        // .app file: appearance definition: parts override
        return base.GetHiddenFieldNames().Concat(["acceptDismemberment"]);
    }
}

