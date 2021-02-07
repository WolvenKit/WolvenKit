using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldDeviceNode : worldEntityNode
	{
		[Ordinal(0)]  [RED("deviceClassName")] public CName DeviceClassName { get; set; }
		[Ordinal(1)]  [RED("alphaHackStreamingDistanceOverride")] public CFloat AlphaHackStreamingDistanceOverride { get; set; }
		[Ordinal(2)]  [RED("deviceConnections")] public CArray<worldDeviceConnections> DeviceConnections { get; set; }

		public worldDeviceNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
