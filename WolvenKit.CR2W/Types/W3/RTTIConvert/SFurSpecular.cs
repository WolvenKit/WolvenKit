using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurSpecular : CVariable
	{
		[Ordinal(0)] [RED("("specularColor")] 		public CColor SpecularColor { get; set;}

		[Ordinal(0)] [RED("("specularTex")] 		public CHandle<CBitmapTexture> SpecularTex { get; set;}

		[Ordinal(0)] [RED("("specularPrimary")] 		public CFloat SpecularPrimary { get; set;}

		[Ordinal(0)] [RED("("specularPowerPrimary")] 		public CFloat SpecularPowerPrimary { get; set;}

		[Ordinal(0)] [RED("("specularPrimaryBreakup")] 		public CFloat SpecularPrimaryBreakup { get; set;}

		[Ordinal(0)] [RED("("specularSecondary")] 		public CFloat SpecularSecondary { get; set;}

		[Ordinal(0)] [RED("("specularPowerSecondary")] 		public CFloat SpecularPowerSecondary { get; set;}

		[Ordinal(0)] [RED("("specularSecondaryOffset")] 		public CFloat SpecularSecondaryOffset { get; set;}

		[Ordinal(0)] [RED("("specularNoiseScale")] 		public CFloat SpecularNoiseScale { get; set;}

		[Ordinal(0)] [RED("("specularEnvScale")] 		public CFloat SpecularEnvScale { get; set;}

		public SFurSpecular(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurSpecular(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}