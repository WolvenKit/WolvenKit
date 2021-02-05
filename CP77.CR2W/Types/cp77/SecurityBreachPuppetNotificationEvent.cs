using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityBreachPuppetNotificationEvent : SecuritySystemInput
	{
		[Ordinal(0)]  [RED("debugReporterCharRecord")] public CHandle<gamedataCharacter_Record> DebugReporterCharRecord { get; set; }
		[Ordinal(1)]  [RED("requesterID")] public entEntityID RequesterID { get; set; }
		[Ordinal(2)]  [RED("executor")] public wCHandle<gameObject> Executor { get; set; }
		[Ordinal(3)]  [RED("objectActionID")] public TweakDBID ObjectActionID { get; set; }
		[Ordinal(4)]  [RED("objectActionRecord")] public wCHandle<gamedataObjectAction_Record> ObjectActionRecord { get; set; }
		[Ordinal(5)]  [RED("inkWidgetID")] public TweakDBID InkWidgetID { get; set; }
		[Ordinal(6)]  [RED("interactionChoice")] public gameinteractionsChoice InteractionChoice { get; set; }
		[Ordinal(7)]  [RED("interactionLayer")] public CName InteractionLayer { get; set; }
		[Ordinal(8)]  [RED("isActionRPGCheckDissabled")] public CBool IsActionRPGCheckDissabled { get; set; }
		[Ordinal(9)]  [RED("prop")] public CHandle<gamedeviceActionProperty> Prop { get; set; }
		[Ordinal(10)]  [RED("actionWidgetPackage")] public SActionWidgetPackage ActionWidgetPackage { get; set; }
		[Ordinal(11)]  [RED("spiderbotActionLocationOverride")] public NodeRef SpiderbotActionLocationOverride { get; set; }
		[Ordinal(12)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(13)]  [RED("canTriggerStim")] public CBool CanTriggerStim { get; set; }
		[Ordinal(14)]  [RED("wasPerformedOnOwner")] public CBool WasPerformedOnOwner { get; set; }
		[Ordinal(15)]  [RED("shouldActivateDevice")] public CBool ShouldActivateDevice { get; set; }
		[Ordinal(16)]  [RED("isQuickHack")] public CBool IsQuickHack { get; set; }
		[Ordinal(17)]  [RED("isSpiderbotAction")] public CBool IsSpiderbotAction { get; set; }
		[Ordinal(18)]  [RED("attachedProgram")] public TweakDBID AttachedProgram { get; set; }
		[Ordinal(19)]  [RED("activeStatusEffect")] public TweakDBID ActiveStatusEffect { get; set; }
		[Ordinal(20)]  [RED("interactionIconType")] public TweakDBID InteractionIconType { get; set; }
		[Ordinal(21)]  [RED("hasInteraction")] public CBool HasInteraction { get; set; }
		[Ordinal(22)]  [RED("inactiveReason")] public CString InactiveReason { get; set; }
		[Ordinal(23)]  [RED("securityAreaData")] public SecurityAreaData SecurityAreaData { get; set; }
		[Ordinal(24)]  [RED("whoBreached")] public wCHandle<gameObject> WhoBreached { get; set; }
		[Ordinal(25)]  [RED("lastKnownPosition")] public Vector4 LastKnownPosition { get; set; }
		[Ordinal(26)]  [RED("notifier")] public CHandle<SharedGameplayPS> Notifier { get; set; }
		[Ordinal(27)]  [RED("type")] public CEnum<ESecurityNotificationType> Type { get; set; }
		[Ordinal(28)]  [RED("objectOfInterest")] public wCHandle<gameObject> ObjectOfInterest { get; set; }
		[Ordinal(29)]  [RED("canPerformReprimand")] public CBool CanPerformReprimand { get; set; }
		[Ordinal(30)]  [RED("shouldLeadReprimend")] public CBool ShouldLeadReprimend { get; set; }
		[Ordinal(31)]  [RED("id")] public CInt32 Id { get; set; }
		[Ordinal(32)]  [RED("customRecipientsList")] public CArray<entEntityID> CustomRecipientsList { get; set; }
		[Ordinal(33)]  [RED("isSharingRestricted")] public CBool IsSharingRestricted { get; set; }
		[Ordinal(34)]  [RED("stimTypeTriggeredAlarm")] public CEnum<gamedataStimType> StimTypeTriggeredAlarm { get; set; }

		public SecurityBreachPuppetNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
