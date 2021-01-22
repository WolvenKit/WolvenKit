using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Rotation_MarkerRotation : gameTransformAnimation_Rotation
	{
		[Ordinal(0)]  [RED("markerNode")] public NodeRef MarkerNode { get; set; }
		[Ordinal(1)]  [RED("offset")] public Vector3 Offset { get; set; }

		public gameTransformAnimation_Rotation_MarkerRotation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
