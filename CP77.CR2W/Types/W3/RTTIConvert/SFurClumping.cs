using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurClumping : CVariable
	{
		[Ordinal(1)] [RED("clumpScale")] 		public CFloat ClumpScale { get; set;}

		[Ordinal(2)] [RED("clumpScaleTex")] 		public CHandle<CBitmapTexture> ClumpScaleTex { get; set;}

		[Ordinal(3)] [RED("clumpScaleTexChannel")] 		public CEnum<EHairTextureChannel> ClumpScaleTexChannel { get; set;}

		[Ordinal(4)] [RED("clumpRoundness")] 		public CFloat ClumpRoundness { get; set;}

		[Ordinal(5)] [RED("clumpRoundnessTex")] 		public CHandle<CBitmapTexture> ClumpRoundnessTex { get; set;}

		[Ordinal(6)] [RED("clumpRoundnessTexChannel")] 		public CEnum<EHairTextureChannel> ClumpRoundnessTexChannel { get; set;}

		[Ordinal(7)] [RED("clumpNoise")] 		public CFloat ClumpNoise { get; set;}

		[Ordinal(8)] [RED("clumpNoiseTex")] 		public CHandle<CBitmapTexture> ClumpNoiseTex { get; set;}

		[Ordinal(9)] [RED("clumpNoiseTexChannel")] 		public CEnum<EHairTextureChannel> ClumpNoiseTexChannel { get; set;}

		[Ordinal(10)] [RED("clumpNumSubclumps")] 		public CUInt32 ClumpNumSubclumps { get; set;}

		public SFurClumping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurClumping(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}