namespace WolvenKit.RED4.Types;

public interface IDynamicClass
{
    public string ClassName { get; set; }
}

public interface IDynamicResource : IDynamicClass
{
}