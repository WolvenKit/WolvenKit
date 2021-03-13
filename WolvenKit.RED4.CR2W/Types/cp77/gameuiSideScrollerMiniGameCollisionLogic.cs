using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameCollisionLogic : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("colliderPositionOffset")] public Vector2 ColliderPositionOffset { get; set; }
		[Ordinal(2)] [RED("colliderSizeOffset")] public Vector2 ColliderSizeOffset { get; set; }

		public gameuiSideScrollerMiniGameCollisionLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
