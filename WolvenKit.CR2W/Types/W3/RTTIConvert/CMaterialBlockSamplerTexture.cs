using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockSamplerTexture : CMaterialBlockSampler
	{
		[RED("subUVWidth")] 		public CUInt32 SubUVWidth { get; set;}

		[RED("subUVHeight")] 		public CUInt32 SubUVHeight { get; set;}

		[RED("subUVInterpolate")] 		public CBool SubUVInterpolate { get; set;}

		[RED("projected")] 		public CBool Projected { get; set;}

		public CMaterialBlockSamplerTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMaterialBlockSamplerTexture(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}