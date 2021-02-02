using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workReactionSequence : workIContainerEntry
	{
		[Ordinal(0)]  [RED("reactionTypes")] public CArray<TweakDBID> ReactionTypes { get; set; }
		[Ordinal(1)]  [RED("forcedBlendIn")] public CFloat ForcedBlendIn { get; set; }
		[Ordinal(2)]  [RED("facialKeyWeight")] public CFloat FacialKeyWeight { get; set; }
		[Ordinal(3)]  [RED("mainEmotionalState")] public CName MainEmotionalState { get; set; }
		[Ordinal(4)]  [RED("emotionalExpression")] public CName EmotionalExpression { get; set; }
		[Ordinal(5)]  [RED("facialIdleMaleAnimation")] public CName FacialIdleMaleAnimation { get; set; }
		[Ordinal(6)]  [RED("facialIdleKey_MaleAnimation")] public CName FacialIdleKey_MaleAnimation { get; set; }
		[Ordinal(7)]  [RED("facialIdleFemaleAnimation")] public CName FacialIdleFemaleAnimation { get; set; }
		[Ordinal(8)]  [RED("facialIdleKey_FemaleAnimation")] public CName FacialIdleKey_FemaleAnimation { get; set; }

		public workReactionSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
