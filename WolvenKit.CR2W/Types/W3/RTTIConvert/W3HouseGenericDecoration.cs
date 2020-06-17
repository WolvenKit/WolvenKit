using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3HouseGenericDecoration : W3HouseDecorationBase
	{
		[RED("m_itemFilterTag")] 		public CName M_itemFilterTag { get; set;}

		[RED("m_decorationItems", 2,0)] 		public CArray<SHouseDecorationItemData> M_decorationItems { get; set;}

		public W3HouseGenericDecoration(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3HouseGenericDecoration(cr2w);

	}
}