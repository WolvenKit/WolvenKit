namespace WolvenKit.RED4.Types;

public interface ICompiledNodeInstanceSetupInfo : IRedType
{
    Transform Transform { get; set; }
    Vector3 Scale { get; set; }
}
