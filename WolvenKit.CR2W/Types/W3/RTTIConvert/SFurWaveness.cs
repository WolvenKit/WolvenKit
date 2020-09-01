using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurWaveness : CVariable
	{
		[Ordinal(0)] [RED("("waveScale")] 		public CFloat WaveScale { get; set;}

		[Ordinal(0)] [RED("("waveScaleTex")] 		public CHandle<CBitmapTexture> WaveScaleTex { get; set;}

		[Ordinal(0)] [RED("("waveScaleTexChannel")] 		public CEnum<EHairTextureChannel> WaveScaleTexChannel { get; set;}

		[Ordinal(0)] [RED("("waveScaleNoise")] 		public CFloat WaveScaleNoise { get; set;}

		[Ordinal(0)] [RED("("waveFreq")] 		public CFloat WaveFreq { get; set;}

		[Ordinal(0)] [RED("("waveFreqTex")] 		public CHandle<CBitmapTexture> WaveFreqTex { get; set;}

		[Ordinal(0)] [RED("("waveFreqTexChannel")] 		public CEnum<EHairTextureChannel> WaveFreqTexChannel { get; set;}

		[Ordinal(0)] [RED("("waveFreqNoise")] 		public CFloat WaveFreqNoise { get; set;}

		[Ordinal(0)] [RED("("waveRootStraighten")] 		public CFloat WaveRootStraighten { get; set;}

		[Ordinal(0)] [RED("("waveStrand")] 		public CFloat WaveStrand { get; set;}

		[Ordinal(0)] [RED("("waveClump")] 		public CFloat WaveClump { get; set;}

		public SFurWaveness(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurWaveness(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}