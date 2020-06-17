using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurSpecular : CVariable
	{
		[RED("specularColor")] 		public CColor SpecularColor { get; set;}

		[RED("specularTex")] 		public CHandle<CBitmapTexture> SpecularTex { get; set;}

		[RED("specularPrimary")] 		public CFloat SpecularPrimary { get; set;}

		[RED("specularPowerPrimary")] 		public CFloat SpecularPowerPrimary { get; set;}

		[RED("specularPrimaryBreakup")] 		public CFloat SpecularPrimaryBreakup { get; set;}

		[RED("specularSecondary")] 		public CFloat SpecularSecondary { get; set;}

		[RED("specularPowerSecondary")] 		public CFloat SpecularPowerSecondary { get; set;}

		[RED("specularSecondaryOffset")] 		public CFloat SpecularSecondaryOffset { get; set;}

		[RED("specularNoiseScale")] 		public CFloat SpecularNoiseScale { get; set;}

		[RED("specularEnvScale")] 		public CFloat SpecularEnvScale { get; set;}

		public SFurSpecular(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SFurSpecular(cr2w);

	}
}