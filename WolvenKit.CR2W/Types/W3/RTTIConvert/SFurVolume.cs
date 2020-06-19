using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurVolume : CVariable
	{
		[RED("density")] 		public CFloat Density { get; set;}

		[RED("densityTex")] 		public CHandle<CBitmapTexture> DensityTex { get; set;}

		[RED("densityTexChannel")] 		public CEnum<EHairTextureChannel> DensityTexChannel { get; set;}

		[RED("usePixelDensity")] 		public CBool UsePixelDensity { get; set;}

		[RED("lengthNoise")] 		public CFloat LengthNoise { get; set;}

		[RED("lengthScale")] 		public CFloat LengthScale { get; set;}

		[RED("lengthTex")] 		public CHandle<CBitmapTexture> LengthTex { get; set;}

		[RED("lengthTexChannel")] 		public CEnum<EHairTextureChannel> LengthTexChannel { get; set;}

		public SFurVolume(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurVolume(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}