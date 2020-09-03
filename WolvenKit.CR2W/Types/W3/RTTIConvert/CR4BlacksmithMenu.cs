using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4BlacksmithMenu : CR4MenuBase
	{
		[Ordinal(1)] [RED("_disassembleInv")] 		public CHandle<W3GuiDisassembleInventoryComponent> _disassembleInv { get; set;}

		[Ordinal(2)] [RED("_repairInv")] 		public CHandle<W3GuiRepairInventoryComponent> _repairInv { get; set;}

		[Ordinal(3)] [RED("_socketInv")] 		public CHandle<W3GuiSocketsInventoryComponent> _socketInv { get; set;}

		[Ordinal(4)] [RED("_curInv")] 		public CHandle<W3GuiBaseInventoryComponent> _curInv { get; set;}

		[Ordinal(5)] [RED("_addSocketInv")] 		public CHandle<W3GuiAddSocketsInventoryComponent> _addSocketInv { get; set;}

		[Ordinal(6)] [RED("_standaloneDismantleInv")] 		public CHandle<W3StandaloneDismantleComponent> _standaloneDismantleInv { get; set;}

		[Ordinal(7)] [RED("_tooltipDataProvider")] 		public CHandle<W3TooltipComponent> _tooltipDataProvider { get; set;}

		[Ordinal(8)] [RED("_inv")] 		public CHandle<CInventoryComponent> _inv { get; set;}

		[Ordinal(9)] [RED("_fixerNpc")] 		public CHandle<CNewNPC> _fixerNpc { get; set;}

		[Ordinal(10)] [RED("_fixerInventory")] 		public CHandle<CInventoryComponent> _fixerInventory { get; set;}

		[Ordinal(11)] [RED("m_standaloneMode")] 		public CBool M_standaloneMode { get; set;}

		[Ordinal(12)] [RED("m_menuInited")] 		public CBool M_menuInited { get; set;}

		[Ordinal(13)] [RED("m_lastConfirmedDisassembleQuantity")] 		public CInt32 M_lastConfirmedDisassembleQuantity { get; set;}

		[Ordinal(14)] [RED("MAX_ITEM_NR")] 		public CInt32 MAX_ITEM_NR { get; set;}

		[Ordinal(15)] [RED("currentItemsNr")] 		public CInt32 CurrentItemsNr { get; set;}

		[Ordinal(16)] [RED("InitDataConfirmation")] 		public CHandle<PriceConfirmationPopupData> InitDataConfirmation { get; set;}

		[Ordinal(17)] [RED("repairAllPopupData")] 		public CHandle<RepairAllPopupData> RepairAllPopupData { get; set;}

		[Ordinal(18)] [RED("quantityPopupData")] 		public CHandle<QuantityPopupData> QuantityPopupData { get; set;}

		[Ordinal(19)] [RED("m_fxRemoveItem")] 		public CHandle<CScriptedFlashFunction> M_fxRemoveItem { get; set;}

		[Ordinal(20)] [RED("m_fxConfirmAction")] 		public CHandle<CScriptedFlashFunction> M_fxConfirmAction { get; set;}

		[Ordinal(21)] [RED("m_fxSetPlayerMoney")] 		public CHandle<CScriptedFlashFunction> M_fxSetPlayerMoney { get; set;}

		[Ordinal(22)] [RED("m_fxSetXActionLabel")] 		public CHandle<CScriptedFlashFunction> M_fxSetXActionLabel { get; set;}

		[Ordinal(23)] [RED("m_sectionsList")] 		public CHandle<CScriptedFlashArray> M_sectionsList { get; set;}

		[Ordinal(24)] [RED("m_ingrForMissingDecoctions", 2,0)] 		public CArray<CName> M_ingrForMissingDecoctions { get; set;}

		public CR4BlacksmithMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4BlacksmithMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}