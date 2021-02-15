using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entGameplayVOEvent : redEvent
	{
		[Ordinal(0)] [RED("voContext")] public CName VoContext { get; set; }
		[Ordinal(1)] [RED("isQuest")] public CBool IsQuest { get; set; }
		[Ordinal(2)] [RED("ignoreFrustumCheck")] public CBool IgnoreFrustumCheck { get; set; }
		[Ordinal(3)] [RED("ignoreDistanceCheck")] public CBool IgnoreDistanceCheck { get; set; }
		[Ordinal(4)] [RED("debugInitialContext")] public CName DebugInitialContext { get; set; }
		[Ordinal(5)] [RED("ignoreGlobalVoLimitCheck")] public CBool IgnoreGlobalVoLimitCheck { get; set; }
		[Ordinal(6)] [RED("answeringEntityId")] public entEntityID AnsweringEntityId { get; set; }
		[Ordinal(7)] [RED("overridingVoiceoverContext")] public CEnum<locVoiceoverContext> OverridingVoiceoverContext { get; set; }
		[Ordinal(8)] [RED("overridingVoiceoverExpression")] public CEnum<locVoiceoverExpression> OverridingVoiceoverExpression { get; set; }
		[Ordinal(9)] [RED("overrideVoiceoverExpression")] public CBool OverrideVoiceoverExpression { get; set; }
		[Ordinal(10)] [RED("overridingVisualStyleValue")] public CUInt8 OverridingVisualStyleValue { get; set; }
		[Ordinal(11)] [RED("overrideVisualStyle")] public CBool OverrideVisualStyle { get; set; }

		public entGameplayVOEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
