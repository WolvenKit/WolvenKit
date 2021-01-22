using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DoorSetup : CVariable
	{
		[Ordinal(0)]  [RED("authorizationSide")] public CEnum<EDoorSkillcheckSide> AuthorizationSide { get; set; }
		[Ordinal(1)]  [RED("automaticallyClosesItself")] public CBool AutomaticallyClosesItself { get; set; }
		[Ordinal(2)]  [RED("canPayToUnlock")] public CBool CanPayToUnlock { get; set; }
		[Ordinal(3)]  [RED("canPlayerToggleLockState")] public CBool CanPlayerToggleLockState { get; set; }
		[Ordinal(4)]  [RED("canPlayerToggleSealState")] public CBool CanPlayerToggleSealState { get; set; }
		[Ordinal(5)]  [RED("doorOpeningStimRange")] public CFloat DoorOpeningStimRange { get; set; }
		[Ordinal(6)]  [RED("doorOpeningTime")] public CFloat DoorOpeningTime { get; set; }
		[Ordinal(7)]  [RED("doorTriggerSide")] public CEnum<EDoorTriggerSide> DoorTriggerSide { get; set; }
		[Ordinal(8)]  [RED("doorType")] public CEnum<EDoorType> DoorType { get; set; }
		[Ordinal(9)]  [RED("doorTypeSideOne")] public CEnum<EDoorType> DoorTypeSideOne { get; set; }
		[Ordinal(10)]  [RED("doorTypeSideTwo")] public CEnum<EDoorType> DoorTypeSideTwo { get; set; }
		[Ordinal(11)]  [RED("exposeQuickHacksIfNotConnectedToAP")] public CBool ExposeQuickHacksIfNotConnectedToAP { get; set; }
		[Ordinal(12)]  [RED("initialDoorState")] public CEnum<EDoorStatus> InitialDoorState { get; set; }
		[Ordinal(13)]  [RED("isShutter")] public CBool IsShutter { get; set; }
		[Ordinal(14)]  [RED("openingSpeed")] public CFloat OpeningSpeed { get; set; }
		[Ordinal(15)]  [RED("paymentRecordID")] public TweakDBID PaymentRecordID { get; set; }
		[Ordinal(16)]  [RED("skillCheckSide")] public CEnum<EDoorSkillcheckSide> SkillCheckSide { get; set; }

		public DoorSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
