using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4GuiManager : CGuiManager
	{
		[Ordinal(0)] [RED("("lastOpenedCommonMenuName")] 		public CName LastOpenedCommonMenuName { get; set;}

		[Ordinal(0)] [RED("("isColorBlindMode")] 		public CBool IsColorBlindMode { get; set;}

		[Ordinal(0)] [RED("("displayedObjectivesGUID", 2,0)] 		public CArray<CGUID> DisplayedObjectivesGUID { get; set;}

		[Ordinal(0)] [RED("("UISavedData", 2,0)] 		public CArray<SUISavedData> UISavedData { get; set;}

		[Ordinal(0)] [RED("("signoutOccurred")] 		public CBool SignoutOccurred { get; set;}

		[Ordinal(0)] [RED("("signInChangeInProgress")] 		public CBool SignInChangeInProgress { get; set;}

		[Ordinal(0)] [RED("("isDuringFirstStartup")] 		public CBool IsDuringFirstStartup { get; set;}

		[Ordinal(0)] [RED("("ignoreControllerDisconnectionEvents")] 		public CBool IgnoreControllerDisconnectionEvents { get; set;}

		[Ordinal(0)] [RED("("controllerDisconnected")] 		public CBool ControllerDisconnected { get; set;}

		[Ordinal(0)] [RED("("waitingForGameLoaded")] 		public CBool WaitingForGameLoaded { get; set;}

		[Ordinal(0)] [RED("("potalConfirmationPending")] 		public CBool PotalConfirmationPending { get; set;}

		[Ordinal(0)] [RED("("pendingPortalConfirmationPauseParam")] 		public CBool PendingPortalConfirmationPauseParam { get; set;}

		[Ordinal(0)] [RED("("mouseCursorRequestStack")] 		public CInt32 MouseCursorRequestStack { get; set;}

		[Ordinal(0)] [RED("("tutHideCounter")] 		public CInt32 TutHideCounter { get; set;}

		[Ordinal(0)] [RED("("tutForcedhideCounter")] 		public CInt32 TutForcedhideCounter { get; set;}

		[Ordinal(0)] [RED("("guiSceneController")] 		public CHandle<CR4GuiSceneController> GuiSceneController { get; set;}

		[Ordinal(0)] [RED("("hudEventController")] 		public CHandle<CR4HudEventController> HudEventController { get; set;}

		[Ordinal(0)] [RED("("lastRequestedCreditsIndex")] 		public CInt32 LastRequestedCreditsIndex { get; set;}

		[Ordinal(0)] [RED("("NewestItems", 2,0)] 		public CArray<SItemUniqueId> NewestItems { get; set;}

		[Ordinal(0)] [RED("("GlossaryEntries", 2,0)] 		public CArray<SGlossaryEntry> GlossaryEntries { get; set;}

		[Ordinal(0)] [RED("("AlchemyEntries", 2,0)] 		public CArray<SGlossaryEntry> AlchemyEntries { get; set;}

		[Ordinal(0)] [RED("("CraftingEntries", 2,0)] 		public CArray<SGlossaryEntry> CraftingEntries { get; set;}

		[Ordinal(0)] [RED("("SkillsEntries", 2,0)] 		public CArray<CEnum<ESkill>> SkillsEntries { get; set;}

		[Ordinal(0)] [RED("("MappinEntries", 2,0)] 		public CArray<SMappinEntry> MappinEntries { get; set;}

		[Ordinal(0)] [RED("("EnchantmentFilters")] 		public SEnchantmentFilters EnchantmentFilters { get; set;}

		[Ordinal(0)] [RED("("PinnedCraftingRecipe")] 		public CName PinnedCraftingRecipe { get; set;}

		[Ordinal(0)] [RED("("InventorySortingMode")] 		public CInt32 InventorySortingMode { get; set;}

		[Ordinal(0)] [RED("("bUsePortal")] 		public CBool BUsePortal { get; set;}

		[Ordinal(0)] [RED("("bUsePortalAnswered")] 		public CBool BUsePortalAnswered { get; set;}

		[Ordinal(0)] [RED("("horseUnmountFeedbackActive")] 		public CBool HorseUnmountFeedbackActive { get; set;}

		[Ordinal(0)] [RED("("hideMessageRequestId")] 		public CInt32 HideMessageRequestId { get; set;}

		[Ordinal(0)] [RED("("bKinectMessageAlreadyShown")] 		public CBool BKinectMessageAlreadyShown { get; set;}

		[Ordinal(0)] [RED("("m_cachedHold")] 		public CBool M_cachedHold { get; set;}

		[Ordinal(0)] [RED("("m_cachedHold_gpadKeyCode")] 		public CInt32 M_cachedHold_gpadKeyCode { get; set;}

		[Ordinal(0)] [RED("("m_cachedHold_kbKeyCode")] 		public CInt32 M_cachedHold_kbKeyCode { get; set;}

		[Ordinal(0)] [RED("("m_cachedHold_label")] 		public CString M_cachedHold_label { get; set;}

		[Ordinal(0)] [RED("("m_cachedHold_holdDuration")] 		public CFloat M_cachedHold_holdDuration { get; set;}

		[Ordinal(0)] [RED("("m_cachedHold_intName")] 		public CName M_cachedHold_intName { get; set;}

		[Ordinal(0)] [RED("("inGameConfigBufferedWrapper")] 		public CHandle<CInGameConfigBufferedWrapper> InGameConfigBufferedWrapper { get; set;}

		[Ordinal(0)] [RED("("showItemNames")] 		public CBool ShowItemNames { get; set;}

		[Ordinal(0)] [RED("("lastMessageData")] 		public CHandle<W3MessagePopupData> LastMessageData { get; set;}

		[Ordinal(0)] [RED("("_ignoreNewItemNotifications")] 		public CBool _ignoreNewItemNotifications { get; set;}

		public CR4GuiManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4GuiManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}