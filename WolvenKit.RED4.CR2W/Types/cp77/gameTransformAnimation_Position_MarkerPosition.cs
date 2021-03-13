using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Position_MarkerPosition : gameTransformAnimation_Position
	{
		[Ordinal(0)] [RED("markerNode")] public NodeRef MarkerNode { get; set; }
		[Ordinal(1)] [RED("offset")] public Vector3 Offset { get; set; }

		public gameTransformAnimation_Position_MarkerPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
