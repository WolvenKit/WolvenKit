namespace WolvenKit.RED4.Types;

public class RenderProxyTransform : RedBaseClass
{
    [RED("transform")]
    [REDProperty(IsIgnored = true)]
    public WorldTransform Transform
    {
        get => GetPropertyValue<WorldTransform>();
        set => SetPropertyValue<WorldTransform>(value);
    }

    [RED("scale")]
    [REDProperty(IsIgnored = true)]
    public Vector3 Scale
    {
        get => GetPropertyValue<Vector3>();
        set => SetPropertyValue<Vector3>(value);
    }

    public RenderProxyTransform()
    {
        Transform = new WorldTransform();
        Scale = new Vector3();
    }
}
