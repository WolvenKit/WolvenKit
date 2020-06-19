using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurClumping : CVariable
	{
		[RED("clumpScale")] 		public CFloat ClumpScale { get; set;}

		[RED("clumpScaleTex")] 		public CHandle<CBitmapTexture> ClumpScaleTex { get; set;}

		[RED("clumpScaleTexChannel")] 		public CEnum<EHairTextureChannel> ClumpScaleTexChannel { get; set;}

		[RED("clumpRoundness")] 		public CFloat ClumpRoundness { get; set;}

		[RED("clumpRoundnessTex")] 		public CHandle<CBitmapTexture> ClumpRoundnessTex { get; set;}

		[RED("clumpRoundnessTexChannel")] 		public CEnum<EHairTextureChannel> ClumpRoundnessTexChannel { get; set;}

		[RED("clumpNoise")] 		public CFloat ClumpNoise { get; set;}

		[RED("clumpNoiseTex")] 		public CHandle<CBitmapTexture> ClumpNoiseTex { get; set;}

		[RED("clumpNoiseTexChannel")] 		public CEnum<EHairTextureChannel> ClumpNoiseTexChannel { get; set;}

		[RED("clumpNumSubclumps")] 		public CUInt32 ClumpNumSubclumps { get; set;}

		public SFurClumping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurClumping(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}