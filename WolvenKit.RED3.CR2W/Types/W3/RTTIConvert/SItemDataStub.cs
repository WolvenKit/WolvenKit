using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SItemDataStub : CVariable
	{
		[Ordinal(1)] [RED("id")] 		public SItemUniqueId Id { get; set;}

		[Ordinal(2)] [RED("quantity")] 		public CInt32 Quantity { get; set;}

		[Ordinal(3)] [RED("iconPath")] 		public CString IconPath { get; set;}

		[Ordinal(4)] [RED("gridPosition")] 		public CInt32 GridPosition { get; set;}

		[Ordinal(5)] [RED("gridSize")] 		public CInt32 GridSize { get; set;}

		[Ordinal(6)] [RED("slotType")] 		public CInt32 SlotType { get; set;}

		[Ordinal(7)] [RED("isNew")] 		public CBool IsNew { get; set;}

		[Ordinal(8)] [RED("actionType")] 		public CInt32 ActionType { get; set;}

		[Ordinal(9)] [RED("price")] 		public CInt32 Price { get; set;}

		[Ordinal(10)] [RED("userData")] 		public CString UserData { get; set;}

		[Ordinal(11)] [RED("category")] 		public CString Category { get; set;}

		[Ordinal(12)] [RED("equipped")] 		public CInt32 Equipped { get; set;}

		[Ordinal(13)] [RED("isReaded")] 		public CBool IsReaded { get; set;}

		public SItemDataStub(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SItemDataStub(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}