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
		[Ordinal(1)] [RED("("_playerInv")] 		public CHandle<W3GuiPlayerInventoryComponent> _playerInv { get; set;}

		[Ordinal(2)] [RED("("_paperdollInv")] 		public CHandle<W3GuiPaperdollInventoryComponent> _paperdollInv { get; set;}

		[Ordinal(3)] [RED("("_containerInv")] 		public CHandle<W3GuiContainerInventoryComponent> _containerInv { get; set;}

		[Ordinal(4)] [RED("("_shopInv")] 		public CHandle<W3GuiShopInventoryComponent> _shopInv { get; set;}

		[Ordinal(5)] [RED("("_horseInv")] 		public CHandle<W3GuiContainerInventoryComponent> _horseInv { get; set;}

		[Ordinal(6)] [RED("("_horsePaperdollInv")] 		public CHandle<W3GuiHorseInventoryComponent> _horsePaperdollInv { get; set;}

		[Ordinal(7)] [RED("("_currentInv")] 		public CHandle<W3GuiBaseInventoryComponent> _currentInv { get; set;}

		[Ordinal(8)] [RED("("_currentMouseInv")] 		public CHandle<W3GuiBaseInventoryComponent> _currentMouseInv { get; set;}

		[Ordinal(9)] [RED("("_quantityPopupData")] 		public CHandle<QuantityPopupData> _quantityPopupData { get; set;}

		[Ordinal(10)] [RED("("_statsContext")] 		public CHandle<W3PlayerStatsContext> _statsContext { get; set;}

		[Ordinal(11)] [RED("("_paperdollContext")] 		public CHandle<W3InventoryPaperdollContext> _paperdollContext { get; set;}

		[Ordinal(12)] [RED("("_invContext")] 		public CHandle<W3InventoryGridContext> _invContext { get; set;}

		[Ordinal(13)] [RED("("_externGridContext")] 		public CHandle<W3ExternalGridContext> _externGridContext { get; set;}

		[Ordinal(14)] [RED("("_bookPopupData")] 		public CHandle<BookPopupFeedback> _bookPopupData { get; set;}

		[Ordinal(15)] [RED("("_paintingPopupData")] 		public CHandle<PaintingPopup> _paintingPopupData { get; set;}

		[Ordinal(16)] [RED("("_charStatsPopupData")] 		public CHandle<CharacterStatsPopupData> _charStatsPopupData { get; set;}

		[Ordinal(17)] [RED("("_itemInfoPopupData")] 		public CHandle<ItemInfoPopupData> _itemInfoPopupData { get; set;}

		[Ordinal(18)] [RED("("_destroyConfPopData")] 		public CHandle<W3DestroyItemConfPopup> _destroyConfPopData { get; set;}

		[Ordinal(19)] [RED("("drawHorse")] 		public CBool DrawHorse { get; set;}

		[Ordinal(20)] [RED("("m_player")] 		public CHandle<CEntity> M_player { get; set;}

		[Ordinal(21)] [RED("("_inv")] 		public CHandle<CInventoryComponent> _inv { get; set;}

		[Ordinal(22)] [RED("("_container")] 		public CHandle<W3Container> _container { get; set;}

		[Ordinal(23)] [RED("("_shopNpc")] 		public CHandle<CNewNPC> _shopNpc { get; set;}

		[Ordinal(24)] [RED("("_tooltipDataProvider")] 		public CHandle<W3TooltipComponent> _tooltipDataProvider { get; set;}

		[Ordinal(25)] [RED("("currentlySelectedTab")] 		public CInt32 CurrentlySelectedTab { get; set;}

		[Ordinal(26)] [RED("("_defaultInventoryState")] 		public CEnum<EInventoryMenuState> _defaultInventoryState { get; set;}

		[Ordinal(27)] [RED("("_currentState")] 		public CEnum<EInventoryMenuState> _currentState { get; set;}

		[Ordinal(28)] [RED("("optionsItemActions", 2,0)] 		public CArray<CEnum<EInventoryActionType>> OptionsItemActions { get; set;}

		[Ordinal(29)] [RED("("_sentStats", 2,0)] 		public CArray<SentStatsData> _sentStats { get; set;}

		[Ordinal(30)] [RED("("_currentQuickSlot")] 		public CEnum<EEquipmentSlots> _currentQuickSlot { get; set;}

		[Ordinal(31)] [RED("("_currentEqippedQuickSlot")] 		public CEnum<EEquipmentSlots> _currentEqippedQuickSlot { get; set;}

		[Ordinal(32)] [RED("("MAX_ITEM_NR")] 		public CInt32 MAX_ITEM_NR { get; set;}

		[Ordinal(33)] [RED("("currentItemsNr")] 		public CInt32 CurrentItemsNr { get; set;}

		[Ordinal(34)] [RED("("m_menuInited")] 		public CBool M_menuInited { get; set;}

		[Ordinal(35)] [RED("("m_isPadConnected")] 		public CBool M_isPadConnected { get; set;}

		[Ordinal(36)] [RED("("m_isUsingPad")] 		public CBool M_isUsingPad { get; set;}

		[Ordinal(37)] [RED("("m_hidePaperdoll")] 		public CBool M_hidePaperdoll { get; set;}

		[Ordinal(38)] [RED("("m_tagsFilter", 2,0)] 		public CArray<CName> M_tagsFilter { get; set;}

		[Ordinal(39)] [RED("("m_ignoreSaveData")] 		public CBool M_ignoreSaveData { get; set;}

		[Ordinal(40)] [RED("("m_selectionModeActive")] 		public CBool M_selectionModeActive { get; set;}

		[Ordinal(41)] [RED("("m_selectionModeItem")] 		public SItemUniqueId M_selectionModeItem { get; set;}

		[Ordinal(42)] [RED("("m_dyePreviewMode")] 		public CBool M_dyePreviewMode { get; set;}

		[Ordinal(43)] [RED("("m_dyePreviewSlots", 2,0)] 		public CArray<SItemUniqueId> M_dyePreviewSlots { get; set;}

		[Ordinal(44)] [RED("("m_previewItems", 2,0)] 		public CArray<SItemUniqueId> M_previewItems { get; set;}

		[Ordinal(45)] [RED("("m_previewSlots", 2,0)] 		public CArray<CBool> M_previewSlots { get; set;}

		[Ordinal(46)] [RED("("m_lastSelectedModuleID")] 		public CInt32 M_lastSelectedModuleID { get; set;}

		[Ordinal(47)] [RED("("m_lastSelectedModuleBindingName")] 		public CString M_lastSelectedModuleBindingName { get; set;}

		[Ordinal(48)] [RED("("m_bookPopupItem")] 		public SItemUniqueId M_bookPopupItem { get; set;}

		[Ordinal(49)] [RED("("currentSelectedItem")] 		public SItemUniqueId CurrentSelectedItem { get; set;}

		[Ordinal(50)] [RED("("m_fxPaperdollRemoveItem")] 		public CHandle<CScriptedFlashFunction> M_fxPaperdollRemoveItem { get; set;}

		[Ordinal(51)] [RED("("m_fxInventoryRemoveItem")] 		public CHandle<CScriptedFlashFunction> M_fxInventoryRemoveItem { get; set;}

		[Ordinal(52)] [RED("("m_fxInventoryUpdateFilter")] 		public CHandle<CScriptedFlashFunction> M_fxInventoryUpdateFilter { get; set;}

		[Ordinal(53)] [RED("("m_fxForceSelectItem")] 		public CHandle<CScriptedFlashFunction> M_fxForceSelectItem { get; set;}

		[Ordinal(54)] [RED("("m_fxForceSelectPaperdollSlot")] 		public CHandle<CScriptedFlashFunction> M_fxForceSelectPaperdollSlot { get; set;}

		[Ordinal(55)] [RED("("m_fxSetFilteringMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetFilteringMode { get; set;}

		[Ordinal(56)] [RED("("m_fxRemoveContainerItem")] 		public CHandle<CScriptedFlashFunction> M_fxRemoveContainerItem { get; set;}

		[Ordinal(57)] [RED("("m_fxHideSelectionMode")] 		public CHandle<CScriptedFlashFunction> M_fxHideSelectionMode { get; set;}

		[Ordinal(58)] [RED("("m_fxSetInventoryMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetInventoryMode { get; set;}

		[Ordinal(59)] [RED("("m_fxSetNewFlagsForTabs")] 		public CHandle<CScriptedFlashFunction> M_fxSetNewFlagsForTabs { get; set;}

		[Ordinal(60)] [RED("("m_fxSetSortingMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetSortingMode { get; set;}

		[Ordinal(61)] [RED("("m_fxSetVitality")] 		public CHandle<CScriptedFlashFunction> M_fxSetVitality { get; set;}

		[Ordinal(62)] [RED("("m_fxSetToxicity")] 		public CHandle<CScriptedFlashFunction> M_fxSetToxicity { get; set;}

		[Ordinal(63)] [RED("("m_fxSetPreviewMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetPreviewMode { get; set;}

		[Ordinal(64)] [RED("("m_fxSetDefaultTab")] 		public CHandle<CScriptedFlashFunction> M_fxSetDefaultTab { get; set;}

		[Ordinal(65)] [RED("("hackHideStatTooltip")] 		public CBool HackHideStatTooltip { get; set;}

		[Ordinal(66)] [RED("("hackHideItemTooltip")] 		public CBool HackHideItemTooltip { get; set;}

		public CR4InventoryMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4InventoryMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}