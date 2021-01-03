using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DisassembleManager : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("AnimOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }
		[Ordinal(1)]  [RED("CraftingBBID")] public CUInt32 CraftingBBID { get; set; }
		[Ordinal(2)]  [RED("DisassembleBBID")] public CUInt32 DisassembleBBID { get; set; }
		[Ordinal(3)]  [RED("DisassembleBlackboard")] public CHandle<gameIBlackboard> DisassembleBlackboard { get; set; }
		[Ordinal(4)]  [RED("DisassembleCallback")] public CHandle<UI_CraftingDef> DisassembleCallback { get; set; }
		[Ordinal(5)]  [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(6)]  [RED("alpha_fadein")] public CHandle<inkanimDefinition> Alpha_fadein { get; set; }
		[Ordinal(7)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(8)]  [RED("initialPopupDelay")] public CFloat InitialPopupDelay { get; set; }
		[Ordinal(9)]  [RED("listOfAddedInventoryItems")] public CArray<InventoryItemData> ListOfAddedInventoryItems { get; set; }
		[Ordinal(10)]  [RED("listRef")] public inkCompoundWidgetReference ListRef { get; set; }
		[Ordinal(11)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(12)]  [RED("popupList")] public CArray<CHandle<DisassemblePopupLogicController>> PopupList { get; set; }
		[Ordinal(13)]  [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(14)]  [RED("transactionSystem")] public CHandle<gameTransactionSystem> TransactionSystem { get; set; }

		public DisassembleManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
