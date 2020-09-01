using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CLightComponent : CSpriteComponent
	{
		[Ordinal(0)] [RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(0)] [RED("shadowCastingMode")] 		public CEnum<ELightShadowCastingMode> ShadowCastingMode { get; set;}

		[Ordinal(0)] [RED("shadowFadeDistance")] 		public CFloat ShadowFadeDistance { get; set;}

		[Ordinal(0)] [RED("shadowFadeRange")] 		public CFloat ShadowFadeRange { get; set;}

		[Ordinal(0)] [RED("shadowBlendFactor")] 		public CFloat ShadowBlendFactor { get; set;}

		[Ordinal(0)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(0)] [RED("brightness")] 		public CFloat Brightness { get; set;}

		[Ordinal(0)] [RED("attenuation")] 		public CFloat Attenuation { get; set;}

		[Ordinal(0)] [RED("color")] 		public CColor Color { get; set;}

		[Ordinal(0)] [RED("envColorGroup")] 		public CEnum<EEnvColorGroup> EnvColorGroup { get; set;}

		[Ordinal(0)] [RED("autoHideDistance")] 		public CFloat AutoHideDistance { get; set;}

		[Ordinal(0)] [RED("autoHideRange")] 		public CFloat AutoHideRange { get; set;}

		[Ordinal(0)] [RED("lightFlickering")] 		public SLightFlickering LightFlickering { get; set;}

		[Ordinal(0)] [RED("allowDistantFade")] 		public CBool AllowDistantFade { get; set;}

		[Ordinal(0)] [RED("lightUsageMask")] 		public ELightUsageMask LightUsageMask { get; set;}

		public CLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CLightComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}