namespace WolvenKit.RED4.Types;

[REDClass(ChildLevel = 1)]
public partial class entEntityTemplate
{
    [RED("entity")]
    [REDProperty(IsIgnored = true)]
    public CHandle<entEntity> Entity
    {
        get => GetPropertyValue<CHandle<entEntity>>();
        set => SetPropertyValue<CHandle<entEntity>>(value);
    }

    [RED("components")]
    [REDProperty(IsIgnored = true)]
    public CArray<entIComponent> Components
    {
        get => GetPropertyValue<CArray<entIComponent>>();
        set => SetPropertyValue<CArray<entIComponent>>(value);
    }
}