using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4AlchemyMenu : CR4ListBaseMenu
	{
		[Ordinal(1)] [RED("m_alchemyManager")] 		public CHandle<W3AlchemyManager> M_alchemyManager { get; set;}

		[Ordinal(2)] [RED("m_recipeList", 2,0)] 		public CArray<SAlchemyRecipe> M_recipeList { get; set;}

		[Ordinal(3)] [RED("m_definitionsManager")] 		public CHandle<CDefinitionsManagerAccessor> M_definitionsManager { get; set;}

		[Ordinal(4)] [RED("bCouldCraft")] 		public CBool BCouldCraft { get; set;}

		[Ordinal(5)] [RED("_inv")] 		public CHandle<CInventoryComponent> _inv { get; set;}

		[Ordinal(6)] [RED("_playerInv")] 		public CHandle<W3GuiPlayerInventoryComponent> _playerInv { get; set;}

		[Ordinal(7)] [RED("m_fxSetCraftingEnabled")] 		public CHandle<CScriptedFlashFunction> M_fxSetCraftingEnabled { get; set;}

		[Ordinal(8)] [RED("m_fxSetCraftedItem")] 		public CHandle<CScriptedFlashFunction> M_fxSetCraftedItem { get; set;}

		[Ordinal(9)] [RED("m_fxHideContent")] 		public CHandle<CScriptedFlashFunction> M_fxHideContent { get; set;}

		[Ordinal(10)] [RED("m_fxSetFilters")] 		public CHandle<CScriptedFlashFunction> M_fxSetFilters { get; set;}

		[Ordinal(11)] [RED("m_fxSetPinnedRecipe")] 		public CHandle<CScriptedFlashFunction> M_fxSetPinnedRecipe { get; set;}

		[Ordinal(12)] [RED("itemsQuantity", 2,0)] 		public CArray<CInt32> ItemsQuantity { get; set;}

		public CR4AlchemyMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4AlchemyMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}