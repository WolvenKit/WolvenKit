using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerDelayedReactionEvent : DelayedCrowdReactionEvent
	{
		[Ordinal(2)] [RED("initAnim")] public CBool InitAnim { get; set; }
		[Ordinal(3)] [RED("behavior")] public CEnum<gamedataOutput> Behavior { get; set; }

		public TriggerDelayedReactionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
