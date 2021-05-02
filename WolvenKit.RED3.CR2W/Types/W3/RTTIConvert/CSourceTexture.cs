using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSourceTexture : CResource
	{
		[Ordinal(1)] [RED("width")] 		public CUInt32 Width { get; set;}

		[Ordinal(2)] [RED("height")] 		public CUInt32 Height { get; set;}

		[Ordinal(3)] [RED("pitch")] 		public CUInt32 Pitch { get; set;}

		[Ordinal(4)] [RED("format")] 		public CEnum<ETextureRawFormat> Format { get; set;}

		public CSourceTexture(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}