using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurWaveness : CVariable
	{
		[RED("waveScale")] 		public CFloat WaveScale { get; set;}

		[RED("waveScaleTex")] 		public CHandle<CBitmapTexture> WaveScaleTex { get; set;}

		[RED("waveScaleTexChannel")] 		public CEnum<EHairTextureChannel> WaveScaleTexChannel { get; set;}

		[RED("waveScaleNoise")] 		public CFloat WaveScaleNoise { get; set;}

		[RED("waveFreq")] 		public CFloat WaveFreq { get; set;}

		[RED("waveFreqTex")] 		public CHandle<CBitmapTexture> WaveFreqTex { get; set;}

		[RED("waveFreqTexChannel")] 		public CEnum<EHairTextureChannel> WaveFreqTexChannel { get; set;}

		[RED("waveFreqNoise")] 		public CFloat WaveFreqNoise { get; set;}

		[RED("waveRootStraighten")] 		public CFloat WaveRootStraighten { get; set;}

		[RED("waveStrand")] 		public CFloat WaveStrand { get; set;}

		[RED("waveClump")] 		public CFloat WaveClump { get; set;}

		public SFurWaveness(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurWaveness(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}