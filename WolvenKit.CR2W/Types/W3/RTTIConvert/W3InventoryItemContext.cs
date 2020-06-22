using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3InventoryItemContext : W3UIContext
	{
		[RED("currentItemId")] 		public SItemUniqueId CurrentItemId { get; set;}

		[RED("currentSlot")] 		public CEnum<EEquipmentSlots> CurrentSlot { get; set;}

		[RED("invMenuRef")] 		public CHandle<CR4InventoryMenu> InvMenuRef { get; set;}

		[RED("invComponentRef")] 		public CHandle<CInventoryComponent> InvComponentRef { get; set;}

		[RED("invSecondComponentRef")] 		public CHandle<CInventoryComponent> InvSecondComponentRef { get; set;}

		[RED("contextMenuPosition_x")] 		public CFloat ContextMenuPosition_x { get; set;}

		[RED("contextMenuPosition_y")] 		public CFloat ContextMenuPosition_y { get; set;}

		public W3InventoryItemContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3InventoryItemContext(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}