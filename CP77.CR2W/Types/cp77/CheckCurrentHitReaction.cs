using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CheckCurrentHitReaction : HitConditions
	{
		[Ordinal(0)] [RED("HitReactionTypeToCompare")] public CEnum<animHitReactionType> HitReactionTypeToCompare { get; set; }
		[Ordinal(1)] [RED("CustomStimNameToCompare")] public CName CustomStimNameToCompare { get; set; }
		[Ordinal(2)] [RED("shouldCheckDeathStimName")] public CBool ShouldCheckDeathStimName { get; set; }

		public CheckCurrentHitReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
