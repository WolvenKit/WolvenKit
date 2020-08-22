using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4InventoryMenu : CR4MenuBase
	{
		[RED("_playerInv")] 		public CHandle<W3GuiPlayerInventoryComponent> _playerInv { get; set;}

		[RED("_paperdollInv")] 		public CHandle<W3GuiPaperdollInventoryComponent> _paperdollInv { get; set;}

		[RED("_containerInv")] 		public CHandle<W3GuiContainerInventoryComponent> _containerInv { get; set;}

		[RED("_shopInv")] 		public CHandle<W3GuiShopInventoryComponent> _shopInv { get; set;}

		[RED("_horseInv")] 		public CHandle<W3GuiContainerInventoryComponent> _horseInv { get; set;}

		[RED("_horsePaperdollInv")] 		public CHandle<W3GuiHorseInventoryComponent> _horsePaperdollInv { get; set;}

		[RED("_currentInv")] 		public CHandle<W3GuiBaseInventoryComponent> _currentInv { get; set;}

		[RED("_currentMouseInv")] 		public CHandle<W3GuiBaseInventoryComponent> _currentMouseInv { get; set;}

		[RED("_quantityPopupData")] 		public CHandle<QuantityPopupData> _quantityPopupData { get; set;}

		[RED("_statsContext")] 		public CHandle<W3PlayerStatsContext> _statsContext { get; set;}

		[RED("_paperdollContext")] 		public CHandle<W3InventoryPaperdollContext> _paperdollContext { get; set;}

		[RED("_invContext")] 		public CHandle<W3InventoryGridContext> _invContext { get; set;}

		[RED("_externGridContext")] 		public CHandle<W3ExternalGridContext> _externGridContext { get; set;}

		[RED("_bookPopupData")] 		public CHandle<BookPopupFeedback> _bookPopupData { get; set;}

		[RED("_paintingPopupData")] 		public CHandle<PaintingPopup> _paintingPopupData { get; set;}

		[RED("_charStatsPopupData")] 		public CHandle<CharacterStatsPopupData> _charStatsPopupData { get; set;}

		[RED("_itemInfoPopupData")] 		public CHandle<ItemInfoPopupData> _itemInfoPopupData { get; set;}

		[RED("_destroyConfPopData")] 		public CHandle<W3DestroyItemConfPopup> _destroyConfPopData { get; set;}

		[RED("drawHorse")] 		public CBool DrawHorse { get; set;}

		[RED("m_player")] 		public CHandle<CEntity> M_player { get; set;}

		[RED("_inv")] 		public CHandle<CInventoryComponent> _inv { get; set;}

		[RED("_container")] 		public CHandle<W3Container> _container { get; set;}

		[RED("_shopNpc")] 		public CHandle<CNewNPC> _shopNpc { get; set;}

		[RED("_tooltipDataProvider")] 		public CHandle<W3TooltipComponent> _tooltipDataProvider { get; set;}

		[RED("currentlySelectedTab")] 		public CInt32 CurrentlySelectedTab { get; set;}

		[RED("_defaultInventoryState")] 		public CEnum<EInventoryMenuState> _defaultInventoryState { get; set;}

		[RED("_currentState")] 		public CEnum<EInventoryMenuState> _currentState { get; set;}

		[RED("optionsItemActions", 2,0)] 		public CArray<CEnum<EInventoryActionType>> OptionsItemActions { get; set;}

		[RED("_sentStats", 2,0)] 		public CArray<SentStatsData> _sentStats { get; set;}

		[RED("_currentQuickSlot")] 		public CEnum<EEquipmentSlots> _currentQuickSlot { get; set;}

		[RED("_currentEqippedQuickSlot")] 		public CEnum<EEquipmentSlots> _currentEqippedQuickSlot { get; set;}

		[RED("MAX_ITEM_NR")] 		public CInt32 MAX_ITEM_NR { get; set;}

		[RED("currentItemsNr")] 		public CInt32 CurrentItemsNr { get; set;}

		[RED("m_menuInited")] 		public CBool M_menuInited { get; set;}

		[RED("m_isPadConnected")] 		public CBool M_isPadConnected { get; set;}

		[RED("m_isUsingPad")] 		public CBool M_isUsingPad { get; set;}

		[RED("m_hidePaperdoll")] 		public CBool M_hidePaperdoll { get; set;}

		[RED("m_tagsFilter", 2,0)] 		public CArray<CName> M_tagsFilter { get; set;}

		[RED("m_ignoreSaveData")] 		public CBool M_ignoreSaveData { get; set;}

		[RED("m_selectionModeActive")] 		public CBool M_selectionModeActive { get; set;}

		[RED("m_selectionModeItem")] 		public SItemUniqueId M_selectionModeItem { get; set;}

		[RED("m_dyePreviewMode")] 		public CBool M_dyePreviewMode { get; set;}

		[RED("m_dyePreviewSlots", 2,0)] 		public CArray<SItemUniqueId> M_dyePreviewSlots { get; set;}

		[RED("m_previewItems", 2,0)] 		public CArray<SItemUniqueId> M_previewItems { get; set;}

		[RED("m_previewSlots", 2,0)] 		public CArray<CBool> M_previewSlots { get; set;}

		[RED("m_lastSelectedModuleID")] 		public CInt32 M_lastSelectedModuleID { get; set;}

		[RED("m_lastSelectedModuleBindingName")] 		public CString M_lastSelectedModuleBindingName { get; set;}

		[RED("m_bookPopupItem")] 		public SItemUniqueId M_bookPopupItem { get; set;}

		[RED("currentSelectedItem")] 		public SItemUniqueId CurrentSelectedItem { get; set;}

		[RED("m_fxPaperdollRemoveItem")] 		public CHandle<CScriptedFlashFunction> M_fxPaperdollRemoveItem { get; set;}

		[RED("m_fxInventoryRemoveItem")] 		public CHandle<CScriptedFlashFunction> M_fxInventoryRemoveItem { get; set;}

		[RED("m_fxInventoryUpdateFilter")] 		public CHandle<CScriptedFlashFunction> M_fxInventoryUpdateFilter { get; set;}

		[RED("m_fxForceSelectItem")] 		public CHandle<CScriptedFlashFunction> M_fxForceSelectItem { get; set;}

		[RED("m_fxForceSelectPaperdollSlot")] 		public CHandle<CScriptedFlashFunction> M_fxForceSelectPaperdollSlot { get; set;}

		[RED("m_fxSetFilteringMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetFilteringMode { get; set;}

		[RED("m_fxRemoveContainerItem")] 		public CHandle<CScriptedFlashFunction> M_fxRemoveContainerItem { get; set;}

		[RED("m_fxHideSelectionMode")] 		public CHandle<CScriptedFlashFunction> M_fxHideSelectionMode { get; set;}

		[RED("m_fxSetInventoryMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetInventoryMode { get; set;}

		[RED("m_fxSetNewFlagsForTabs")] 		public CHandle<CScriptedFlashFunction> M_fxSetNewFlagsForTabs { get; set;}

		[RED("m_fxSetSortingMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetSortingMode { get; set;}

		[RED("m_fxSetVitality")] 		public CHandle<CScriptedFlashFunction> M_fxSetVitality { get; set;}

		[RED("m_fxSetToxicity")] 		public CHandle<CScriptedFlashFunction> M_fxSetToxicity { get; set;}

		[RED("m_fxSetPreviewMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetPreviewMode { get; set;}

		[RED("m_fxSetDefaultTab")] 		public CHandle<CScriptedFlashFunction> M_fxSetDefaultTab { get; set;}

		[RED("hackHideStatTooltip")] 		public CBool HackHideStatTooltip { get; set;}

		[RED("hackHideItemTooltip")] 		public CBool HackHideItemTooltip { get; set;}

		public CR4InventoryMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4InventoryMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}