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
		[Ordinal(1)] [RED("("waveScale")] 		public CFloat WaveScale { get; set;}

		[Ordinal(2)] [RED("("waveScaleTex")] 		public CHandle<CBitmapTexture> WaveScaleTex { get; set;}

		[Ordinal(3)] [RED("("waveScaleTexChannel")] 		public CEnum<EHairTextureChannel> WaveScaleTexChannel { get; set;}

		[Ordinal(4)] [RED("("waveScaleNoise")] 		public CFloat WaveScaleNoise { get; set;}

		[Ordinal(5)] [RED("("waveFreq")] 		public CFloat WaveFreq { get; set;}

		[Ordinal(6)] [RED("("waveFreqTex")] 		public CHandle<CBitmapTexture> WaveFreqTex { get; set;}

		[Ordinal(7)] [RED("("waveFreqTexChannel")] 		public CEnum<EHairTextureChannel> WaveFreqTexChannel { get; set;}

		[Ordinal(8)] [RED("("waveFreqNoise")] 		public CFloat WaveFreqNoise { get; set;}

		[Ordinal(9)] [RED("("waveRootStraighten")] 		public CFloat WaveRootStraighten { get; set;}

		[Ordinal(10)] [RED("("waveStrand")] 		public CFloat WaveStrand { get; set;}

		[Ordinal(11)] [RED("("waveClump")] 		public CFloat WaveClump { get; set;}

		public SFurWaveness(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurWaveness(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}