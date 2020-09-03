using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4GuiManager : CGuiManager
	{
		[Ordinal(1)] [RED("lastOpenedCommonMenuName")] 		public CName LastOpenedCommonMenuName { get; set;}

		[Ordinal(2)] [RED("isColorBlindMode")] 		public CBool IsColorBlindMode { get; set;}

		[Ordinal(3)] [RED("displayedObjectivesGUID", 2,0)] 		public CArray<CGUID> DisplayedObjectivesGUID { get; set;}

		[Ordinal(4)] [RED("UISavedData", 2,0)] 		public CArray<SUISavedData> UISavedData { get; set;}

		[Ordinal(5)] [RED("signoutOccurred")] 		public CBool SignoutOccurred { get; set;}

		[Ordinal(6)] [RED("signInChangeInProgress")] 		public CBool SignInChangeInProgress { get; set;}

		[Ordinal(7)] [RED("isDuringFirstStartup")] 		public CBool IsDuringFirstStartup { get; set;}

		[Ordinal(8)] [RED("ignoreControllerDisconnectionEvents")] 		public CBool IgnoreControllerDisconnectionEvents { get; set;}

		[Ordinal(9)] [RED("controllerDisconnected")] 		public CBool ControllerDisconnected { get; set;}

		[Ordinal(10)] [RED("waitingForGameLoaded")] 		public CBool WaitingForGameLoaded { get; set;}

		[Ordinal(11)] [RED("potalConfirmationPending")] 		public CBool PotalConfirmationPending { get; set;}

		[Ordinal(12)] [RED("pendingPortalConfirmationPauseParam")] 		public CBool PendingPortalConfirmationPauseParam { get; set;}

		[Ordinal(13)] [RED("mouseCursorRequestStack")] 		public CInt32 MouseCursorRequestStack { get; set;}

		[Ordinal(14)] [RED("tutHideCounter")] 		public CInt32 TutHideCounter { get; set;}

		[Ordinal(15)] [RED("tutForcedhideCounter")] 		public CInt32 TutForcedhideCounter { get; set;}

		[Ordinal(16)] [RED("guiSceneController")] 		public CHandle<CR4GuiSceneController> GuiSceneController { get; set;}

		[Ordinal(17)] [RED("hudEventController")] 		public CHandle<CR4HudEventController> HudEventController { get; set;}

		[Ordinal(18)] [RED("lastRequestedCreditsIndex")] 		public CInt32 LastRequestedCreditsIndex { get; set;}

		[Ordinal(19)] [RED("NewestItems", 2,0)] 		public CArray<SItemUniqueId> NewestItems { get; set;}

		[Ordinal(20)] [RED("GlossaryEntries", 2,0)] 		public CArray<SGlossaryEntry> GlossaryEntries { get; set;}

		[Ordinal(21)] [RED("AlchemyEntries", 2,0)] 		public CArray<SGlossaryEntry> AlchemyEntries { get; set;}

		[Ordinal(22)] [RED("CraftingEntries", 2,0)] 		public CArray<SGlossaryEntry> CraftingEntries { get; set;}

		[Ordinal(23)] [RED("SkillsEntries", 2,0)] 		public CArray<CEnum<ESkill>> SkillsEntries { get; set;}

		[Ordinal(24)] [RED("MappinEntries", 2,0)] 		public CArray<SMappinEntry> MappinEntries { get; set;}

		[Ordinal(25)] [RED("EnchantmentFilters")] 		public SEnchantmentFilters EnchantmentFilters { get; set;}

		[Ordinal(26)] [RED("PinnedCraftingRecipe")] 		public CName PinnedCraftingRecipe { get; set;}

		[Ordinal(27)] [RED("InventorySortingMode")] 		public CInt32 InventorySortingMode { get; set;}

		[Ordinal(28)] [RED("bUsePortal")] 		public CBool BUsePortal { get; set;}

		[Ordinal(29)] [RED("bUsePortalAnswered")] 		public CBool BUsePortalAnswered { get; set;}

		[Ordinal(30)] [RED("horseUnmountFeedbackActive")] 		public CBool HorseUnmountFeedbackActive { get; set;}

		[Ordinal(31)] [RED("hideMessageRequestId")] 		public CInt32 HideMessageRequestId { get; set;}

		[Ordinal(32)] [RED("bKinectMessageAlreadyShown")] 		public CBool BKinectMessageAlreadyShown { get; set;}

		[Ordinal(33)] [RED("m_cachedHold")] 		public CBool M_cachedHold { get; set;}

		[Ordinal(34)] [RED("m_cachedHold_gpadKeyCode")] 		public CInt32 M_cachedHold_gpadKeyCode { get; set;}

		[Ordinal(35)] [RED("m_cachedHold_kbKeyCode")] 		public CInt32 M_cachedHold_kbKeyCode { get; set;}

		[Ordinal(36)] [RED("m_cachedHold_label")] 		public CString M_cachedHold_label { get; set;}

		[Ordinal(37)] [RED("m_cachedHold_holdDuration")] 		public CFloat M_cachedHold_holdDuration { get; set;}

		[Ordinal(38)] [RED("m_cachedHold_intName")] 		public CName M_cachedHold_intName { get; set;}

		[Ordinal(39)] [RED("inGameConfigBufferedWrapper")] 		public CHandle<CInGameConfigBufferedWrapper> InGameConfigBufferedWrapper { get; set;}

		[Ordinal(40)] [RED("showItemNames")] 		public CBool ShowItemNames { get; set;}

		[Ordinal(41)] [RED("lastMessageData")] 		public CHandle<W3MessagePopupData> LastMessageData { get; set;}

		[Ordinal(42)] [RED("_ignoreNewItemNotifications")] 		public CBool _ignoreNewItemNotifications { get; set;}

		public CR4GuiManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4GuiManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}