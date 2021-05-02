using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BookPopupFeedback : TextPopupData
	{
		[Ordinal(1)] [RED("bookItemId")] 		public SItemUniqueId BookItemId { get; set;}

		[Ordinal(2)] [RED("inventoryRef")] 		public CHandle<CR4InventoryMenu> InventoryRef { get; set;}

		[Ordinal(3)] [RED("singleBookMode")] 		public CBool SingleBookMode { get; set;}

		[Ordinal(4)] [RED("curInventory")] 		public CHandle<CInventoryComponent> CurInventory { get; set;}

		public BookPopupFeedback(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BookPopupFeedback(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}