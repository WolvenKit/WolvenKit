using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CLightComponent : CSpriteComponent
	{
		[RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[RED("shadowCastingMode")] 		public ELightShadowCastingMode ShadowCastingMode { get; set;}

		[RED("shadowFadeDistance")] 		public CFloat ShadowFadeDistance { get; set;}

		[RED("shadowFadeRange")] 		public CFloat ShadowFadeRange { get; set;}

		[RED("shadowBlendFactor")] 		public CFloat ShadowBlendFactor { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("brightness")] 		public CFloat Brightness { get; set;}

		[RED("attenuation")] 		public CFloat Attenuation { get; set;}

		[RED("color")] 		public CColor Color { get; set;}

		[RED("envColorGroup")] 		public EEnvColorGroup EnvColorGroup { get; set;}

		[RED("autoHideDistance")] 		public CFloat AutoHideDistance { get; set;}

		[RED("autoHideRange")] 		public CFloat AutoHideRange { get; set;}

		[RED("lightFlickering")] 		public SLightFlickering LightFlickering { get; set;}

		[RED("allowDistantFade")] 		public CBool AllowDistantFade { get; set;}

		[RED("lightUsageMask")] 		public ELightUsageMask LightUsageMask { get; set;}

		public CLightComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CLightComponent(cr2w);

	}
}