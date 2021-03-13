using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsColliderBox : physicsICollider
	{
		[Ordinal(8)] [RED("halfExtents")] public Vector3 HalfExtents { get; set; }
		[Ordinal(9)] [RED("isObstacle")] public CBool IsObstacle { get; set; }

		public physicsColliderBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
