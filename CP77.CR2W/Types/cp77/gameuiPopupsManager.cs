using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPopupsManager : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("bracketsContainer")] public inkCompoundWidgetReference BracketsContainer { get; set; }
		[Ordinal(3)] [RED("tutorialOverlayContainer")] public inkCompoundWidgetReference TutorialOverlayContainer { get; set; }
		[Ordinal(4)] [RED("bracketLibraryID")] public CName BracketLibraryID { get; set; }
		[Ordinal(5)] [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(6)] [RED("bbDefinition")] public CHandle<UIGameDataDef> BbDefinition { get; set; }
		[Ordinal(7)] [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(8)] [RED("uiSystemBB")] public CHandle<gameIBlackboard> UiSystemBB { get; set; }
		[Ordinal(9)] [RED("uiSystemBBDef")] public CHandle<UI_SystemDef> UiSystemBBDef { get; set; }
		[Ordinal(10)] [RED("uiSystemId")] public CUInt32 UiSystemId { get; set; }
		[Ordinal(11)] [RED("isShownBbId")] public CUInt32 IsShownBbId { get; set; }
		[Ordinal(12)] [RED("dataBbId")] public CUInt32 DataBbId { get; set; }
		[Ordinal(13)] [RED("tutorialOnHold")] public CBool TutorialOnHold { get; set; }
		[Ordinal(14)] [RED("tutorialData")] public gamePopupData TutorialData { get; set; }
		[Ordinal(15)] [RED("tutorialSettings")] public gamePopupSettings TutorialSettings { get; set; }
		[Ordinal(16)] [RED("tutorialToken")] public CHandle<inkGameNotificationToken> TutorialToken { get; set; }
		[Ordinal(17)] [RED("phoneMessageToken")] public CHandle<inkGameNotificationToken> PhoneMessageToken { get; set; }
		[Ordinal(18)] [RED("shardToken")] public CHandle<inkGameNotificationToken> ShardToken { get; set; }
		[Ordinal(19)] [RED("vehiclesManagerToken")] public CHandle<inkGameNotificationToken> VehiclesManagerToken { get; set; }
		[Ordinal(20)] [RED("vehicleRadioToken")] public CHandle<inkGameNotificationToken> VehicleRadioToken { get; set; }
		[Ordinal(21)] [RED("codexToken")] public CHandle<inkGameNotificationToken> CodexToken { get; set; }

		public gameuiPopupsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
