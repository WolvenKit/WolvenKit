namespace WolvenKit.RED4.Types;

public partial class appearanceAppearanceDefinition
{
    public override IEnumerable<string> GetHiddenIfDefaultFieldNames()
    {
        return base.GetHiddenIfDefaultFieldNames().Concat(["looseDependencies"]);
    }

    public override IEnumerable<string> GetHiddenFieldNames()
    {
        return base.GetHiddenFieldNames().Concat(
        [
            "censorFlags",
            "cookedDataPathOverride",
            "forcedLodDistance",
            "hitRepresentationOverrides",
            "parametersBuffer",
            "parentAppearance",
        ]);
    }
}