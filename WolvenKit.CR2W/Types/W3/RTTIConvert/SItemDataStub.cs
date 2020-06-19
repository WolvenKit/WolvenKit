using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SItemDataStub : CVariable
	{
		[RED("id")] 		public SItemUniqueId Id { get; set;}

		[RED("quantity")] 		public CInt32 Quantity { get; set;}

		[RED("iconPath")] 		public CString IconPath { get; set;}

		[RED("gridPosition")] 		public CInt32 GridPosition { get; set;}

		[RED("gridSize")] 		public CInt32 GridSize { get; set;}

		[RED("slotType")] 		public CInt32 SlotType { get; set;}

		[RED("isNew")] 		public CBool IsNew { get; set;}

		[RED("actionType")] 		public CInt32 ActionType { get; set;}

		[RED("price")] 		public CInt32 Price { get; set;}

		[RED("userData")] 		public CString UserData { get; set;}

		[RED("category")] 		public CString Category { get; set;}

		[RED("equipped")] 		public CInt32 Equipped { get; set;}

		[RED("isReaded")] 		public CBool IsReaded { get; set;}

		public SItemDataStub(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SItemDataStub(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}