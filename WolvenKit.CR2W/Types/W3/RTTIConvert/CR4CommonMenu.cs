using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4CommonMenu : CR4MenuBase
	{
		[RED("m_menuData", 2,0)] 		public CArray<SMenuTab> M_menuData { get; set;}

		[RED("m_subMenuData", 2,0)] 		public CArray<SMenuTab> M_subMenuData { get; set;}

		[RED("m_lastMenuName")] 		public CName M_lastMenuName { get; set;}

		[RED("m_hubEnabled")] 		public CBool M_hubEnabled { get; set;}

		[RED("m_lockedInHub")] 		public CBool M_lockedInHub { get; set;}

		[RED("m_lockedInMenu")] 		public CBool M_lockedInMenu { get; set;}

		[RED("m_contextInputBlocked")] 		public CBool M_contextInputBlocked { get; set;}

		[RED("m_fxSubMenuClosed")] 		public CHandle<CScriptedFlashFunction> M_fxSubMenuClosed { get; set;}

		[RED("m_fxUpdateLevel")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateLevel { get; set;}

		[RED("m_fxUpdateMoney")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateMoney { get; set;}

		[RED("m_fxUpdateWeight")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateWeight { get; set;}

		[RED("m_fxNavigateNext")] 		public CHandle<CScriptedFlashFunction> M_fxNavigateNext { get; set;}

		[RED("m_fxNavigatePrior")] 		public CHandle<CScriptedFlashFunction> M_fxNavigatePrior { get; set;}

		[RED("m_fxSelectSubMenuTab")] 		public CHandle<CScriptedFlashFunction> M_fxSelectSubMenuTab { get; set;}

		[RED("m_fxSetShopInventory")] 		public CHandle<CScriptedFlashFunction> M_fxSetShopInventory { get; set;}

		[RED("m_fxUpdateTabEnabled")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateTabEnabled { get; set;}

		[RED("m_fxLockOpenTabNavigation")] 		public CHandle<CScriptedFlashFunction> M_fxLockOpenTabNavigation { get; set;}

		[RED("m_fxBlockMenuClosing")] 		public CHandle<CScriptedFlashFunction> M_fxBlockMenuClosing { get; set;}

		[RED("m_fxBlockHubClosing")] 		public CHandle<CScriptedFlashFunction> M_fxBlockHubClosing { get; set;}

		[RED("m_fxSetInputFeedbackVisibility")] 		public CHandle<CScriptedFlashFunction> M_fxSetInputFeedbackVisibility { get; set;}

		[RED("m_fxSetPlayerDefailsVis")] 		public CHandle<CScriptedFlashFunction> M_fxSetPlayerDefailsVis { get; set;}

		[RED("m_fxSetMeditationBackgroundMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetMeditationBackgroundMode { get; set;}

		[RED("m_fxOnChildMenuConfigured")] 		public CHandle<CScriptedFlashFunction> M_fxOnChildMenuConfigured { get; set;}

		[RED("m_fxUpdateMenuBackgroundImage")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateMenuBackgroundImage { get; set;}

		[RED("m_fxBlockBackNavigation")] 		public CHandle<CScriptedFlashFunction> M_fxBlockBackNavigation { get; set;}

		[RED("m_fxSelectTab")] 		public CHandle<CScriptedFlashFunction> M_fxSelectTab { get; set;}

		[RED("m_fxEnterCurrentTab")] 		public CHandle<CScriptedFlashFunction> M_fxEnterCurrentTab { get; set;}

		[RED("m_defaultBindings", 2,0)] 		public CArray<SKeyBinding> M_defaultBindings { get; set;}

		[RED("m_contextBindings", 2,0)] 		public CArray<SKeyBinding> M_contextBindings { get; set;}

		[RED("m_GFxBindings", 2,0)] 		public CArray<SKeyBinding> M_GFxBindings { get; set;}

		[RED("m_contextManager")] 		public CHandle<W3ContextManager> M_contextManager { get; set;}

		[RED("m_mode_meditation")] 		public CBool M_mode_meditation { get; set;}

		[RED("m_had_meditation")] 		public CBool M_had_meditation { get; set;}

		[RED("noSaveLock")] 		public CInt32 NoSaveLock { get; set;}

		[RED("isCiri")] 		public CBool IsCiri { get; set;}

		[RED("inventoryHotkey")] 		public CEnum<EInputKey> InventoryHotkey { get; set;}

		[RED("characterHotkey")] 		public CEnum<EInputKey> CharacterHotkey { get; set;}

		[RED("mapHotkey")] 		public CEnum<EInputKey> MapHotkey { get; set;}

		[RED("journalHotkey")] 		public CEnum<EInputKey> JournalHotkey { get; set;}

		[RED("alchemyHotkey")] 		public CEnum<EInputKey> AlchemyHotkey { get; set;}

		[RED("bestiaryHotkey")] 		public CEnum<EInputKey> BestiaryHotkey { get; set;}

		[RED("glossaryHotkey")] 		public CEnum<EInputKey> GlossaryHotkey { get; set;}

		[RED("meditationHotkey")] 		public CEnum<EInputKey> MeditationHotkey { get; set;}

		[RED("craftingHotkey")] 		public CEnum<EInputKey> CraftingHotkey { get; set;}

		[RED("isInNpcContext")] 		public CBool IsInNpcContext { get; set;}

		[RED("isEnchantingAvailable")] 		public CBool IsEnchantingAvailable { get; set;}

		[RED("isShopAvailable")] 		public CBool IsShopAvailable { get; set;}

		[RED("isRepairAvailable")] 		public CBool IsRepairAvailable { get; set;}

		[RED("isCraftingAvailable")] 		public CBool IsCraftingAvailable { get; set;}

		[RED("isAlchemyAvailable")] 		public CBool IsAlchemyAvailable { get; set;}

		[RED("isPlayerMeditatingInBed")] 		public CBool IsPlayerMeditatingInBed { get; set;}

		public CR4CommonMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4CommonMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}