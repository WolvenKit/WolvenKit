using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TriggerDelayedReactionEvent : DelayedCrowdReactionEvent
	{
		[Ordinal(0)]  [RED("behavior")] public CEnum<gamedataOutput> Behavior { get; set; }
		[Ordinal(1)]  [RED("initAnim")] public CBool InitAnim { get; set; }

		public TriggerDelayedReactionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
