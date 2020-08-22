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
		[RED("lastOpenedCommonMenuName")] 		public CName LastOpenedCommonMenuName { get; set;}

		[RED("isColorBlindMode")] 		public CBool IsColorBlindMode { get; set;}

		[RED("displayedObjectivesGUID", 2,0)] 		public CArray<CGUID> DisplayedObjectivesGUID { get; set;}

		[RED("UISavedData", 2,0)] 		public CArray<SUISavedData> UISavedData { get; set;}

		[RED("signoutOccurred")] 		public CBool SignoutOccurred { get; set;}

		[RED("signInChangeInProgress")] 		public CBool SignInChangeInProgress { get; set;}

		[RED("isDuringFirstStartup")] 		public CBool IsDuringFirstStartup { get; set;}

		[RED("ignoreControllerDisconnectionEvents")] 		public CBool IgnoreControllerDisconnectionEvents { get; set;}

		[RED("controllerDisconnected")] 		public CBool ControllerDisconnected { get; set;}

		[RED("waitingForGameLoaded")] 		public CBool WaitingForGameLoaded { get; set;}

		[RED("potalConfirmationPending")] 		public CBool PotalConfirmationPending { get; set;}

		[RED("pendingPortalConfirmationPauseParam")] 		public CBool PendingPortalConfirmationPauseParam { get; set;}

		[RED("mouseCursorRequestStack")] 		public CInt32 MouseCursorRequestStack { get; set;}

		[RED("tutHideCounter")] 		public CInt32 TutHideCounter { get; set;}

		[RED("tutForcedhideCounter")] 		public CInt32 TutForcedhideCounter { get; set;}

		[RED("guiSceneController")] 		public CHandle<CR4GuiSceneController> GuiSceneController { get; set;}

		[RED("hudEventController")] 		public CHandle<CR4HudEventController> HudEventController { get; set;}

		[RED("lastRequestedCreditsIndex")] 		public CInt32 LastRequestedCreditsIndex { get; set;}

		[RED("NewestItems", 2,0)] 		public CArray<SItemUniqueId> NewestItems { get; set;}

		[RED("GlossaryEntries", 2,0)] 		public CArray<SGlossaryEntry> GlossaryEntries { get; set;}

		[RED("AlchemyEntries", 2,0)] 		public CArray<SGlossaryEntry> AlchemyEntries { get; set;}

		[RED("CraftingEntries", 2,0)] 		public CArray<SGlossaryEntry> CraftingEntries { get; set;}

		[RED("SkillsEntries", 2,0)] 		public CArray<CEnum<ESkill>> SkillsEntries { get; set;}

		[RED("MappinEntries", 2,0)] 		public CArray<SMappinEntry> MappinEntries { get; set;}

		[RED("EnchantmentFilters")] 		public SEnchantmentFilters EnchantmentFilters { get; set;}

		[RED("PinnedCraftingRecipe")] 		public CName PinnedCraftingRecipe { get; set;}

		[RED("InventorySortingMode")] 		public CInt32 InventorySortingMode { get; set;}

		[RED("bUsePortal")] 		public CBool BUsePortal { get; set;}

		[RED("bUsePortalAnswered")] 		public CBool BUsePortalAnswered { get; set;}

		[RED("horseUnmountFeedbackActive")] 		public CBool HorseUnmountFeedbackActive { get; set;}

		[RED("hideMessageRequestId")] 		public CInt32 HideMessageRequestId { get; set;}

		[RED("bKinectMessageAlreadyShown")] 		public CBool BKinectMessageAlreadyShown { get; set;}

		[RED("m_cachedHold")] 		public CBool M_cachedHold { get; set;}

		[RED("m_cachedHold_gpadKeyCode")] 		public CInt32 M_cachedHold_gpadKeyCode { get; set;}

		[RED("m_cachedHold_kbKeyCode")] 		public CInt32 M_cachedHold_kbKeyCode { get; set;}

		[RED("m_cachedHold_label")] 		public CString M_cachedHold_label { get; set;}

		[RED("m_cachedHold_holdDuration")] 		public CFloat M_cachedHold_holdDuration { get; set;}

		[RED("m_cachedHold_intName")] 		public CName M_cachedHold_intName { get; set;}

		[RED("inGameConfigBufferedWrapper")] 		public CHandle<CInGameConfigBufferedWrapper> InGameConfigBufferedWrapper { get; set;}

		[RED("showItemNames")] 		public CBool ShowItemNames { get; set;}

		[RED("lastMessageData")] 		public CHandle<W3MessagePopupData> LastMessageData { get; set;}

		[RED("_ignoreNewItemNotifications")] 		public CBool _ignoreNewItemNotifications { get; set;}

		public CR4GuiManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4GuiManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}