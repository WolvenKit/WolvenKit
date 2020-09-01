using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class QuantityPopupData : SliderPopupData
	{
		[Ordinal(0)] [RED("itemId")] 		public SItemUniqueId ItemId { get; set;}

		[Ordinal(0)] [RED("itemCost")] 		public CFloat ItemCost { get; set;}

		[Ordinal(0)] [RED("showPrice")] 		public CBool ShowPrice { get; set;}

		[Ordinal(0)] [RED("actionType")] 		public CEnum<EQuantityTransferFunction> ActionType { get; set;}

		[Ordinal(0)] [RED("inventoryRef")] 		public CHandle<CR4InventoryMenu> InventoryRef { get; set;}

		[Ordinal(0)] [RED("blacksmithRef")] 		public CHandle<CR4BlacksmithMenu> BlacksmithRef { get; set;}

		[Ordinal(0)] [RED("craftingRef")] 		public CHandle<CR4CraftingMenu> CraftingRef { get; set;}

		public QuantityPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new QuantityPopupData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}