using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LastHitDataEvent : redEvent
	{
		[Ordinal(0)] [RED("hitReactionBehaviorData")] public CHandle<HitReactionBehaviorData> HitReactionBehaviorData { get; set; }

		public LastHitDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
