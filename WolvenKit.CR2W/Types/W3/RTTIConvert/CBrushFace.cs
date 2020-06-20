using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBrushFace : CObject
	{
		[RED("material")] 		public CHandle<IMaterial> Material { get; set;}

		[RED("mapping")] 		public CEnum<EBrushFaceMapping> Mapping { get; set;}

		[RED("scaleU")] 		public CFloat ScaleU { get; set;}

		[RED("scaleV")] 		public CFloat ScaleV { get; set;}

		[RED("offsetU")] 		public CFloat OffsetU { get; set;}

		[RED("offsetV")] 		public CFloat OffsetV { get; set;}

		[RED("rotation")] 		public CFloat Rotation { get; set;}

		[RED("renderFaceID")] 		public CInt32 RenderFaceID { get; set;}

		public CBrushFace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBrushFace(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}