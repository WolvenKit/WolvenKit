using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBrushFace : CObject
	{
		[Ordinal(1)] [RED("material")] 		public CHandle<IMaterial> Material { get; set;}

		[Ordinal(2)] [RED("mapping")] 		public CEnum<EBrushFaceMapping> Mapping { get; set;}

		[Ordinal(3)] [RED("scaleU")] 		public CFloat ScaleU { get; set;}

		[Ordinal(4)] [RED("scaleV")] 		public CFloat ScaleV { get; set;}

		[Ordinal(5)] [RED("offsetU")] 		public CFloat OffsetU { get; set;}

		[Ordinal(6)] [RED("offsetV")] 		public CFloat OffsetV { get; set;}

		[Ordinal(7)] [RED("rotation")] 		public CFloat Rotation { get; set;}

		[Ordinal(8)] [RED("renderFaceID")] 		public CInt32 RenderFaceID { get; set;}

		public CBrushFace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBrushFace(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}