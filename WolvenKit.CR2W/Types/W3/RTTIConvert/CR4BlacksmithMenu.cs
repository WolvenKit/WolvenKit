using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4BlacksmithMenu : CR4MenuBase
	{
		[RED("_disassembleInv")] 		public CHandle<W3GuiDisassembleInventoryComponent> _disassembleInv { get; set;}

		[RED("_repairInv")] 		public CHandle<W3GuiRepairInventoryComponent> _repairInv { get; set;}

		[RED("_socketInv")] 		public CHandle<W3GuiSocketsInventoryComponent> _socketInv { get; set;}

		[RED("_curInv")] 		public CHandle<W3GuiBaseInventoryComponent> _curInv { get; set;}

		[RED("_addSocketInv")] 		public CHandle<W3GuiAddSocketsInventoryComponent> _addSocketInv { get; set;}

		[RED("_standaloneDismantleInv")] 		public CHandle<W3StandaloneDismantleComponent> _standaloneDismantleInv { get; set;}

		[RED("_tooltipDataProvider")] 		public CHandle<W3TooltipComponent> _tooltipDataProvider { get; set;}

		[RED("_inv")] 		public CHandle<CInventoryComponent> _inv { get; set;}

		[RED("_fixerNpc")] 		public CHandle<CNewNPC> _fixerNpc { get; set;}

		[RED("_fixerInventory")] 		public CHandle<CInventoryComponent> _fixerInventory { get; set;}

		[RED("m_standaloneMode")] 		public CBool M_standaloneMode { get; set;}

		[RED("m_menuInited")] 		public CBool M_menuInited { get; set;}

		[RED("m_lastConfirmedDisassembleQuantity")] 		public CInt32 M_lastConfirmedDisassembleQuantity { get; set;}

		[RED("MAX_ITEM_NR")] 		public CInt32 MAX_ITEM_NR { get; set;}

		[RED("currentItemsNr")] 		public CInt32 CurrentItemsNr { get; set;}

		[RED("InitDataConfirmation")] 		public CHandle<PriceConfirmationPopupData> InitDataConfirmation { get; set;}

		[RED("repairAllPopupData")] 		public CHandle<RepairAllPopupData> RepairAllPopupData { get; set;}

		[RED("quantityPopupData")] 		public CHandle<QuantityPopupData> QuantityPopupData { get; set;}

		[RED("m_fxRemoveItem")] 		public CHandle<CScriptedFlashFunction> M_fxRemoveItem { get; set;}

		[RED("m_fxConfirmAction")] 		public CHandle<CScriptedFlashFunction> M_fxConfirmAction { get; set;}

		[RED("m_fxSetPlayerMoney")] 		public CHandle<CScriptedFlashFunction> M_fxSetPlayerMoney { get; set;}

		[RED("m_fxSetXActionLabel")] 		public CHandle<CScriptedFlashFunction> M_fxSetXActionLabel { get; set;}

		[RED("m_sectionsList")] 		public CHandle<CScriptedFlashArray> M_sectionsList { get; set;}

		[RED("m_ingrForMissingDecoctions", 2,0)] 		public CArray<CName> M_ingrForMissingDecoctions { get; set;}

		public CR4BlacksmithMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4BlacksmithMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}