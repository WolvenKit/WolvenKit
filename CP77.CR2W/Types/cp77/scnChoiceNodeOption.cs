using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeOption : CVariable
	{
		[Ordinal(0)] [RED("screenplayOptionId")] public scnscreenplayItemId ScreenplayOptionId { get; set; }
		[Ordinal(1)] [RED("blueline")] public CBool Blueline { get; set; }
		[Ordinal(2)] [RED("isSingleChoice")] public CBool IsSingleChoice { get; set; }
		[Ordinal(3)] [RED("type")] public gameinteractionsChoiceTypeWrapper Type { get; set; }
		[Ordinal(4)] [RED("timedParams")] public CHandle<scnChoiceNodeNsTimedParams> TimedParams { get; set; }
		[Ordinal(5)] [RED("questCondition")] public CHandle<questIBaseCondition> QuestCondition { get; set; }
		[Ordinal(6)] [RED("triggerCondition")] public CHandle<questIBaseCondition> TriggerCondition { get; set; }
		[Ordinal(7)] [RED("bluelineCondition")] public CHandle<questIBaseCondition> BluelineCondition { get; set; }
		[Ordinal(8)] [RED("gameplayAction")] public TweakDBID GameplayAction { get; set; }
		[Ordinal(9)] [RED("iconTagIds")] public CArray<TweakDBID> IconTagIds { get; set; }
		[Ordinal(10)] [RED("exDataFlags")] public CUInt32 ExDataFlags { get; set; }
		[Ordinal(11)] [RED("mappinReferencePointId")] public scnReferencePointId MappinReferencePointId { get; set; }
		[Ordinal(12)] [RED("timedCondition")] public CHandle<scnTimedCondition> TimedCondition { get; set; }

		public scnChoiceNodeOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
