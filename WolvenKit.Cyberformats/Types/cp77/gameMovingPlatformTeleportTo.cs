using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformTeleportTo : redEvent
	{
		[Ordinal(0)] [RED("destinationNode")] public NodeRef DestinationNode { get; set; }
		[Ordinal(1)] [RED("rootEntityPosition")] public Vector4 RootEntityPosition { get; set; }

		public gameMovingPlatformTeleportTo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
