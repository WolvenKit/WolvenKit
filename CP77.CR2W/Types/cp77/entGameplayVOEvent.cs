using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entGameplayVOEvent : redEvent
	{
		[Ordinal(0)]  [RED("answeringEntityId")] public entEntityID AnsweringEntityId { get; set; }
		[Ordinal(1)]  [RED("debugInitialContext")] public CName DebugInitialContext { get; set; }
		[Ordinal(2)]  [RED("ignoreDistanceCheck")] public CBool IgnoreDistanceCheck { get; set; }
		[Ordinal(3)]  [RED("ignoreFrustumCheck")] public CBool IgnoreFrustumCheck { get; set; }
		[Ordinal(4)]  [RED("ignoreGlobalVoLimitCheck")] public CBool IgnoreGlobalVoLimitCheck { get; set; }
		[Ordinal(5)]  [RED("isQuest")] public CBool IsQuest { get; set; }
		[Ordinal(6)]  [RED("overrideVisualStyle")] public CBool OverrideVisualStyle { get; set; }
		[Ordinal(7)]  [RED("overrideVoiceoverExpression")] public CBool OverrideVoiceoverExpression { get; set; }
		[Ordinal(8)]  [RED("overridingVisualStyleValue")] public CUInt8 OverridingVisualStyleValue { get; set; }
		[Ordinal(9)]  [RED("overridingVoiceoverContext")] public CEnum<locVoiceoverContext> OverridingVoiceoverContext { get; set; }
		[Ordinal(10)]  [RED("overridingVoiceoverExpression")] public CEnum<locVoiceoverExpression> OverridingVoiceoverExpression { get; set; }
		[Ordinal(11)]  [RED("voContext")] public CName VoContext { get; set; }

		public entGameplayVOEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
