using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurColor : CVariable
	{
		[RED("rootAlphaFalloff")] 		public CFloat RootAlphaFalloff { get; set;}

		[RED("rootColor")] 		public CColor RootColor { get; set;}

		[RED("rootColorTex")] 		public CHandle<CBitmapTexture> RootColorTex { get; set;}

		[RED("tipColor")] 		public CColor TipColor { get; set;}

		[RED("tipColorTex")] 		public CHandle<CBitmapTexture> TipColorTex { get; set;}

		[RED("rootTipColorWeight")] 		public CFloat RootTipColorWeight { get; set;}

		[RED("rootTipColorFalloff")] 		public CFloat RootTipColorFalloff { get; set;}

		[RED("strandTex")] 		public CHandle<CBitmapTexture> StrandTex { get; set;}

		[RED("strandBlendMode")] 		public CEnum<EHairStrandBlendModeType> StrandBlendMode { get; set;}

		[RED("strandBlendScale")] 		public CFloat StrandBlendScale { get; set;}

		[RED("textureBrightness")] 		public CFloat TextureBrightness { get; set;}

		[RED("ambientEnvScale")] 		public CFloat AmbientEnvScale { get; set;}

		public SFurColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurColor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}