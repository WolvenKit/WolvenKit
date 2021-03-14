using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisassembleManager : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("listRef")] public inkCompoundWidgetReference ListRef { get; set; }
		[Ordinal(4)] [RED("initialPopupDelay")] public CFloat InitialPopupDelay { get; set; }
		[Ordinal(5)] [RED("popupList")] public CArray<CHandle<DisassemblePopupLogicController>> PopupList { get; set; }
		[Ordinal(6)] [RED("listOfAddedInventoryItems")] public CArray<InventoryItemData> ListOfAddedInventoryItems { get; set; }
		[Ordinal(7)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(8)] [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(9)] [RED("transactionSystem")] public CHandle<gameTransactionSystem> TransactionSystem { get; set; }
		[Ordinal(10)] [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(11)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(12)] [RED("alpha_fadein")] public CHandle<inkanimDefinition> Alpha_fadein { get; set; }
		[Ordinal(13)] [RED("AnimOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }
		[Ordinal(14)] [RED("DisassembleCallback")] public CHandle<UI_CraftingDef> DisassembleCallback { get; set; }
		[Ordinal(15)] [RED("DisassembleBlackboard")] public CHandle<gameIBlackboard> DisassembleBlackboard { get; set; }
		[Ordinal(16)] [RED("DisassembleBBID")] public CUInt32 DisassembleBBID { get; set; }
		[Ordinal(17)] [RED("CraftingBBID")] public CUInt32 CraftingBBID { get; set; }

		public DisassembleManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
