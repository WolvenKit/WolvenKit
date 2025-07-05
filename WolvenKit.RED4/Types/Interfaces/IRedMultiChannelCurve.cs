namespace WolvenKit.RED4.Types;

public interface IRedMultiChannelCurve : IRedType
{
    public uint NumChannels { get; set; }
    public Enums.EInterpolationType InterpolationType { get; set; }
    public Enums.EChannelLinkType LinkType { get; set; }
    public uint Alignment { get; set; }
    public byte[] Data { get; set; }
}

public interface IRedMultiChannelCurve<T> : IRedMultiChannelCurve, IRedGenericType<T>
{

}