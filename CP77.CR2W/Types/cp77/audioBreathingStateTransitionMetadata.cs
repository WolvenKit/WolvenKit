using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioBreathingStateTransitionMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("fromNames")] public CArray<CName> FromNames { get; set; }
		[Ordinal(2)] [RED("toName")] public CName ToName { get; set; }
		[Ordinal(3)] [RED("transitionStateName")] public CName TransitionStateName { get; set; }
		[Ordinal(4)] [RED("conditionType")] public CEnum<audioBreathingTransitionType> ConditionType { get; set; }
		[Ordinal(5)] [RED("conditionComparator")] public CEnum<audioBreathingTransitionComparator> ConditionComparator { get; set; }
		[Ordinal(6)] [RED("value")] public CName Value { get; set; }
		[Ordinal(7)] [RED("eventTags")] public CArray<CEnum<audiobreathingEventTag>> EventTags { get; set; }
		[Ordinal(8)] [RED("isImmediate")] public CBool IsImmediate { get; set; }

		public audioBreathingStateTransitionMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
