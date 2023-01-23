namespace WolvenKit.RED4.Types;

public class DynamicBaseClass : RedBaseClass, IDynamicResource
{
    [REDProperty(IsIgnored = true)]
    public string ClassName { get; set; }
}

public class DynamicResource : CResource, IDynamicResource
{
    [REDProperty(IsIgnored = true)]
    public string ClassName { get; set; }
}
