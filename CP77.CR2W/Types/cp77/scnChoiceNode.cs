using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNode : scnSceneGraphNode
	{
		[Ordinal(3)] [RED("displayNameOverride")] public CString DisplayNameOverride { get; set; }
		[Ordinal(4)] [RED("localizedDisplayNameOverride")] public LocalizationString LocalizedDisplayNameOverride { get; set; }
		[Ordinal(5)] [RED("options")] public CArray<scnChoiceNodeOption> Options { get; set; }
		[Ordinal(6)] [RED("mode")] public CEnum<scnChoiceNodeNsOperationMode> Mode { get; set; }
		[Ordinal(7)] [RED("persistentLineEvents")] public CArray<scnSceneEventId> PersistentLineEvents { get; set; }
		[Ordinal(8)] [RED("customPersistentLine")] public scnscreenplayItemId CustomPersistentLine { get; set; }
		[Ordinal(9)] [RED("timedParams")] public CHandle<scnChoiceNodeNsTimedParams> TimedParams { get; set; }
		[Ordinal(10)] [RED("reminderParams")] public CHandle<scnChoiceNodeNsActorReminderParams> ReminderParams { get; set; }
		[Ordinal(11)] [RED("shapeParams")] public CHandle<scnInteractionShapeParams> ShapeParams { get; set; }
		[Ordinal(12)] [RED("lookAtParams")] public CHandle<scnChoiceNodeNsLookAtParams> LookAtParams { get; set; }
		[Ordinal(13)] [RED("forceAttachToScreenCondition")] public CHandle<questIBaseCondition> ForceAttachToScreenCondition { get; set; }
		[Ordinal(14)] [RED("choiceGroup")] public CName ChoiceGroup { get; set; }
		[Ordinal(15)] [RED("cpoHoldInputActionSection")] public CBool CpoHoldInputActionSection { get; set; }
		[Ordinal(16)] [RED("ataParams")] public scnChoiceNodeNsAttachToActorParams AtaParams { get; set; }
		[Ordinal(17)] [RED("atpParams")] public scnChoiceNodeNsAttachToPropParams AtpParams { get; set; }
		[Ordinal(18)] [RED("atgoParams")] public scnChoiceNodeNsAttachToGameObjectParams AtgoParams { get; set; }
		[Ordinal(19)] [RED("atsParams")] public scnChoiceNodeNsAttachToScreenParams AtsParams { get; set; }
		[Ordinal(20)] [RED("atwParams")] public scnChoiceNodeNsAttachToWorldParams AtwParams { get; set; }
		[Ordinal(21)] [RED("choicePriority")] public CUInt8 ChoicePriority { get; set; }
		[Ordinal(22)] [RED("hubPriority")] public CUInt8 HubPriority { get; set; }
		[Ordinal(23)] [RED("mappinParams")] public CHandle<scnChoiceNodeNsMappinParams> MappinParams { get; set; }
		[Ordinal(24)] [RED("interruptCapability")] public CEnum<scnInterruptCapability> InterruptCapability { get; set; }
		[Ordinal(25)] [RED("interruptionSpeakerOverride")] public scnActorId InterruptionSpeakerOverride { get; set; }
		[Ordinal(26)] [RED("choiceFlags")] public CEnum<scnChoiceNodeNsChoiceNodeBitFlags> ChoiceFlags { get; set; }
		[Ordinal(27)] [RED("alwaysUseBrainGender")] public CBool AlwaysUseBrainGender { get; set; }
		[Ordinal(28)] [RED("timedSectionCondition")] public CHandle<scnTimedCondition> TimedSectionCondition { get; set; }
		[Ordinal(29)] [RED("reminderCondition")] public CHandle<scnReminderCondition> ReminderCondition { get; set; }

		public scnChoiceNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
