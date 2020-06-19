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

		public W3HouseGenericDecoration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3HouseGenericDecoration(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}