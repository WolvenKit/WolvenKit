using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockSamplerTexture : CMaterialBlockSampler
	{
		[Ordinal(1)] [RED("subUVWidth")] 		public CUInt32 SubUVWidth { get; set;}

		[Ordinal(2)] [RED("subUVHeight")] 		public CUInt32 SubUVHeight { get; set;}

		[Ordinal(3)] [RED("subUVInterpolate")] 		public CBool SubUVInterpolate { get; set;}

		[Ordinal(4)] [RED("projected")] 		public CBool Projected { get; set;}

		public CMaterialBlockSamplerTexture(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}