namespace WolvenKit.RED4.Types;

public partial class inkTextureSlot
{
    public override IEnumerable<string> GetHiddenFieldNames()
    {
        return base.GetHiddenFieldNames().Concat(["slices"]);
    }
}

