using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurVolume : CVariable
	{
		[Ordinal(1)] [RED("density")] 		public CFloat Density { get; set;}

		[Ordinal(2)] [RED("densityTex")] 		public CHandle<CBitmapTexture> DensityTex { get; set;}

		[Ordinal(3)] [RED("densityTexChannel")] 		public CEnum<EHairTextureChannel> DensityTexChannel { get; set;}

		[Ordinal(4)] [RED("usePixelDensity")] 		public CBool UsePixelDensity { get; set;}

		[Ordinal(5)] [RED("lengthNoise")] 		public CFloat LengthNoise { get; set;}

		[Ordinal(6)] [RED("lengthScale")] 		public CFloat LengthScale { get; set;}

		[Ordinal(7)] [RED("lengthTex")] 		public CHandle<CBitmapTexture> LengthTex { get; set;}

		[Ordinal(8)] [RED("lengthTexChannel")] 		public CEnum<EHairTextureChannel> LengthTexChannel { get; set;}

		public SFurVolume(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurVolume(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}