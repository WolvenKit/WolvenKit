using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGraphSocket : ISerializable
	{
		[Ordinal(1)] [RED("block")] 		public CPtr<CGraphBlock> Block { get; set;}

		[Ordinal(2)] [RED("name")] 		public CName Name { get; set;}

		[Ordinal(3)] [RED("connections", 2,0)] 		public CArray<CPtr<CGraphConnection>> Connections { get; set;}

		[Ordinal(4)] [RED("flags")] 		public CUInt32 Flags { get; set;}

		[Ordinal(5)] [RED("placement")] 		public CEnum<ELinkedSocketPlacement> Placement { get; set;}

		[Ordinal(6)] [RED("caption")] 		public CString Caption { get; set;}

		[Ordinal(7)] [RED("color")] 		public CColor Color { get; set;}

		[Ordinal(8)] [RED("direction")] 		public CEnum<ELinkedSocketDirection> Direction { get; set;}

		[Ordinal(9)] [RED("drawStyle")] 		public CEnum<ELinkedSocketDrawStyle> DrawStyle { get; set;}

		public CGraphSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGraphSocket(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}