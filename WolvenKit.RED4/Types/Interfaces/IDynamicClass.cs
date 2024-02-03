namespace WolvenKit.RED4.Types;

public interface IDynamicClass
{
    public CName ClassName { get; set; }
}

public interface IDynamicResource : IDynamicClass
{
}