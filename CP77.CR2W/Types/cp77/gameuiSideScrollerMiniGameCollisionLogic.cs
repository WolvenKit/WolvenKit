using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameCollisionLogic : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("colliderPositionOffset")] public Vector2 ColliderPositionOffset { get; set; }
		[Ordinal(1)]  [RED("colliderSizeOffset")] public Vector2 ColliderSizeOffset { get; set; }

		public gameuiSideScrollerMiniGameCollisionLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
