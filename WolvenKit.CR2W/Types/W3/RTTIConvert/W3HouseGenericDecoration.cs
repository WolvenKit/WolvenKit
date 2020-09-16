using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3HouseGenericDecoration : W3HouseDecorationBase
	{
		[Ordinal(1)] [RED("m_itemFilterTag")] 		public CName M_itemFilterTag { get; set;}

		[Ordinal(2)] [RED("m_decorationItems", 2,0)] 		public CArray<SHouseDecorationItemData> M_decorationItems { get; set;}

		[Ordinal(3)] [RED("m_currentApperance")] 		public CName M_currentApperance { get; set;}

		public W3HouseGenericDecoration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3HouseGenericDecoration(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}