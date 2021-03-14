using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class QuantityPopupData : SliderPopupData
	{
		[Ordinal(1)] [RED("itemId")] 		public SItemUniqueId ItemId { get; set;}

		[Ordinal(2)] [RED("itemCost")] 		public CFloat ItemCost { get; set;}

		[Ordinal(3)] [RED("showPrice")] 		public CBool ShowPrice { get; set;}

		[Ordinal(4)] [RED("actionType")] 		public CEnum<EQuantityTransferFunction> ActionType { get; set;}

		[Ordinal(5)] [RED("inventoryRef")] 		public CHandle<CR4InventoryMenu> InventoryRef { get; set;}

		[Ordinal(6)] [RED("blacksmithRef")] 		public CHandle<CR4BlacksmithMenu> BlacksmithRef { get; set;}

		[Ordinal(7)] [RED("craftingRef")] 		public CHandle<CR4CraftingMenu> CraftingRef { get; set;}

		public QuantityPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new QuantityPopupData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}