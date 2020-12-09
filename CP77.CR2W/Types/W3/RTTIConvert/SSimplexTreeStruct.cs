using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSimplexTreeStruct : CVariable
	{
		[Ordinal(1)] [RED("parent")] 		public CInt32 Parent { get; set;}

		[Ordinal(2)] [RED("positiveStruct")] 		public CInt32 PositiveStruct { get; set;}

		[Ordinal(3)] [RED("negativeStruct")] 		public CInt32 NegativeStruct { get; set;}

		[Ordinal(4)] [RED("positiveID")] 		public CInt32 PositiveID { get; set;}

		[Ordinal(5)] [RED("negativeID")] 		public CInt32 NegativeID { get; set;}

		[Ordinal(6)] [RED("normalX")] 		public CFloat NormalX { get; set;}

		[Ordinal(7)] [RED("normalY")] 		public CFloat NormalY { get; set;}

		[Ordinal(8)] [RED("offset")] 		public CFloat Offset { get; set;}

		public SSimplexTreeStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSimplexTreeStruct(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}