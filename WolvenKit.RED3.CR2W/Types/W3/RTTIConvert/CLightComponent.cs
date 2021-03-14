using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CLightComponent : CSpriteComponent
	{
		[Ordinal(1)] [RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(2)] [RED("shadowCastingMode")] 		public CEnum<ELightShadowCastingMode> ShadowCastingMode { get; set;}

		[Ordinal(3)] [RED("shadowFadeDistance")] 		public CFloat ShadowFadeDistance { get; set;}

		[Ordinal(4)] [RED("shadowFadeRange")] 		public CFloat ShadowFadeRange { get; set;}

		[Ordinal(5)] [RED("shadowBlendFactor")] 		public CFloat ShadowBlendFactor { get; set;}

		[Ordinal(6)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(7)] [RED("brightness")] 		public CFloat Brightness { get; set;}

		[Ordinal(8)] [RED("attenuation")] 		public CFloat Attenuation { get; set;}

		[Ordinal(9)] [RED("color")] 		public CColor Color { get; set;}

		[Ordinal(10)] [RED("envColorGroup")] 		public CEnum<EEnvColorGroup> EnvColorGroup { get; set;}

		[Ordinal(11)] [RED("autoHideDistance")] 		public CFloat AutoHideDistance { get; set;}

		[Ordinal(12)] [RED("autoHideRange")] 		public CFloat AutoHideRange { get; set;}

		[Ordinal(13)] [RED("lightFlickering")] 		public SLightFlickering LightFlickering { get; set;}

		[Ordinal(14)] [RED("allowDistantFade")] 		public CBool AllowDistantFade { get; set;}

		[Ordinal(15)] [RED("lightUsageMask")] 		public CEnum<ELightUsageMask> LightUsageMask { get; set;}

		public CLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CLightComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}