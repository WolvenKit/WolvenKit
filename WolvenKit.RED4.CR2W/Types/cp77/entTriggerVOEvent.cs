using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTriggerVOEvent : redEvent
	{
		[Ordinal(0)] [RED("triggerBaseName")] public CName TriggerBaseName { get; set; }
		[Ordinal(1)] [RED("triggerVariationIndex")] public CUInt32 TriggerVariationIndex { get; set; }
		[Ordinal(2)] [RED("triggerVariationNumber")] public CUInt32 TriggerVariationNumber { get; set; }
		[Ordinal(3)] [RED("debugInitialContext")] public CName DebugInitialContext { get; set; }
		[Ordinal(4)] [RED("answeringEntityIDHash")] public CUInt64 AnsweringEntityIDHash { get; set; }
		[Ordinal(5)] [RED("ignoreGlobalVoLimitCheck")] public CBool IgnoreGlobalVoLimitCheck { get; set; }
		[Ordinal(6)] [RED("overridingVoContext")] public CEnum<locVoiceoverContext> OverridingVoContext { get; set; }
		[Ordinal(7)] [RED("overridingVoiceoverExpression")] public CEnum<locVoiceoverExpression> OverridingVoiceoverExpression { get; set; }
		[Ordinal(8)] [RED("overrideVoiceoverExpression")] public CBool OverrideVoiceoverExpression { get; set; }
		[Ordinal(9)] [RED("overridingVisualStyleValue")] public CUInt8 OverridingVisualStyleValue { get; set; }
		[Ordinal(10)] [RED("overrideVisualStyle")] public CBool OverrideVisualStyle { get; set; }

		public entTriggerVOEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
