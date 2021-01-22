using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsColliderBox : physicsICollider
	{
		[Ordinal(0)]  [RED("halfExtents")] public Vector3 HalfExtents { get; set; }
		[Ordinal(1)]  [RED("isObstacle")] public CBool IsObstacle { get; set; }

		public physicsColliderBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
