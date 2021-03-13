using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIApproachingAreaEvent : AIAIEvent
	{
		[Ordinal(2)] [RED("isApproachCancellation")] public CBool IsApproachCancellation { get; set; }
		[Ordinal(3)] [RED("areaComponent")] public wCHandle<gameStaticAreaShapeComponent> AreaComponent { get; set; }
		[Ordinal(4)] [RED("responseTarget")] public wCHandle<entEntity> ResponseTarget { get; set; }

		public AIApproachingAreaEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
