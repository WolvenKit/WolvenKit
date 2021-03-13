using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDeviceNode : worldEntityNode
	{
		[Ordinal(9)] [RED("deviceClassName")] public CName DeviceClassName { get; set; }
		[Ordinal(10)] [RED("alphaHackStreamingDistanceOverride")] public CFloat AlphaHackStreamingDistanceOverride { get; set; }
		[Ordinal(11)] [RED("deviceConnections")] public CArray<worldDeviceConnections> DeviceConnections { get; set; }

		public worldDeviceNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
