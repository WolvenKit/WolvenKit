namespace WolvenKit.Modkit.RED4.Tools.MeshHandler.Extras;

public interface IVector4
{
}

public struct Vector4<T> : IVector4 where T : struct
{
    public T X;
    public T Y;
    public T Z;
    public T W;
}
