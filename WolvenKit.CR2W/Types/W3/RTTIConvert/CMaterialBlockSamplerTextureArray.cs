using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockSamplerTextureArray : CMaterialBlockSampler
	{
		[Ordinal(0)] [RED("subUVWidth")] 		public CUInt32 SubUVWidth { get; set;}

		[Ordinal(0)] [RED("subUVHeight")] 		public CUInt32 SubUVHeight { get; set;}

		[Ordinal(0)] [RED("subUVInterpolate")] 		public CBool SubUVInterpolate { get; set;}

		[Ordinal(0)] [RED("projected")] 		public CBool Projected { get; set;}

		public CMaterialBlockSamplerTextureArray(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMaterialBlockSamplerTextureArray(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}