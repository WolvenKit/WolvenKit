using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviortweakTargetLocation : CVariable
	{
		[Ordinal(0)]  [RED("coverId")] public AIObjectId CoverId { get; set; }
		[Ordinal(1)]  [RED("hasPosition")] public CBool HasPosition { get; set; }
		[Ordinal(2)]  [RED("hasSpeed")] public CBool HasSpeed { get; set; }
		[Ordinal(3)]  [RED("object")] public wCHandle<gameObject> Object { get; set; }
		[Ordinal(4)]  [RED("position")] public Vector3 Position { get; set; }
		[Ordinal(5)]  [RED("speed")] public Vector3 Speed { get; set; }

		public AIbehaviortweakTargetLocation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
