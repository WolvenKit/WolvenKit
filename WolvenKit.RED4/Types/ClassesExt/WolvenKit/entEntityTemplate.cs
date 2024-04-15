namespace WolvenKit.RED4.Types;

public partial class entEntityTemplate
{
    public override IEnumerable<string> GetHiddenFieldNames()
    {
        return base.GetHiddenFieldNames().Concat([
            "backendDataOverrides", 
            "bindingOverrides", 
            "compiledEntityLODFlags", 
            "componentResolveSettings", 
            "includes", 
            "entity"
        ]);
    }
}