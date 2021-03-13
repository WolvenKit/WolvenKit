using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4CraftingMenu : CR4ListBaseMenu
	{
		[Ordinal(1)] [RED("m_definitionsManager")] 		public CHandle<CDefinitionsManagerAccessor> M_definitionsManager { get; set;}

		[Ordinal(2)] [RED("bCouldCraft")] 		public CBool BCouldCraft { get; set;}

		[Ordinal(3)] [RED("_inv")] 		public CHandle<CInventoryComponent> _inv { get; set;}

		[Ordinal(4)] [RED("_playerInv")] 		public CHandle<W3GuiPlayerInventoryComponent> _playerInv { get; set;}

		[Ordinal(5)] [RED("m_craftingManager")] 		public CHandle<W3CraftingManager> M_craftingManager { get; set;}

		[Ordinal(6)] [RED("m_schematicList", 2,0)] 		public CArray<CName> M_schematicList { get; set;}

		[Ordinal(7)] [RED("m_npc")] 		public CHandle<CNewNPC> M_npc { get; set;}

		[Ordinal(8)] [RED("m_npcInventory")] 		public CHandle<CInventoryComponent> M_npcInventory { get; set;}

		[Ordinal(9)] [RED("m_shopInvComponent")] 		public CHandle<W3GuiShopInventoryComponent> M_shopInvComponent { get; set;}

		[Ordinal(10)] [RED("m_lastSelectedTag")] 		public CName M_lastSelectedTag { get; set;}

		[Ordinal(11)] [RED("_craftsmanComponent")] 		public CHandle<W3CraftsmanComponent> _craftsmanComponent { get; set;}

		[Ordinal(12)] [RED("_quantityPopupData")] 		public CHandle<QuantityPopupData> _quantityPopupData { get; set;}

		[Ordinal(13)] [RED("m_fxSetCraftingEnabled")] 		public CHandle<CScriptedFlashFunction> M_fxSetCraftingEnabled { get; set;}

		[Ordinal(14)] [RED("m_fxSetCraftedItem")] 		public CHandle<CScriptedFlashFunction> M_fxSetCraftedItem { get; set;}

		[Ordinal(15)] [RED("m_fxHideContent")] 		public CHandle<CScriptedFlashFunction> M_fxHideContent { get; set;}

		[Ordinal(16)] [RED("m_fxSetFilters")] 		public CHandle<CScriptedFlashFunction> M_fxSetFilters { get; set;}

		[Ordinal(17)] [RED("m_fxSetPinnedRecipe")] 		public CHandle<CScriptedFlashFunction> M_fxSetPinnedRecipe { get; set;}

		[Ordinal(18)] [RED("m_fxSetMerchantCheck")] 		public CHandle<CScriptedFlashFunction> M_fxSetMerchantCheck { get; set;}

		[Ordinal(19)] [RED("itemsQuantity", 2,0)] 		public CArray<CInt32> ItemsQuantity { get; set;}

		public CR4CraftingMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4CraftingMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}