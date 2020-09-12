using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SWorldEnvironmentParameters : CVariable
	{
		[Ordinal(1)] [RED("vignetteTexture")] 		public CHandle<CBitmapTexture> VignetteTexture { get; set;}

		[Ordinal(2)] [RED("cameraDirtTexture")] 		public CHandle<CBitmapTexture> CameraDirtTexture { get; set;}

		[Ordinal(3)] [RED("interiorFallbackAmbientTexture")] 		public CHandle<CCubeTexture> InteriorFallbackAmbientTexture { get; set;}

		[Ordinal(4)] [RED("interiorFallbackReflectionTexture")] 		public CHandle<CCubeTexture> InteriorFallbackReflectionTexture { get; set;}

		[Ordinal(5)] [RED("cameraDirtNumVerticalTiles")] 		public CFloat CameraDirtNumVerticalTiles { get; set;}

		[Ordinal(6)] [RED("globalLightingTrajectory")] 		public CGlobalLightingTrajectory GlobalLightingTrajectory { get; set;}

		[Ordinal(7)] [RED("toneMappingAdaptationSpeedUp")] 		public CFloat ToneMappingAdaptationSpeedUp { get; set;}

		[Ordinal(8)] [RED("toneMappingAdaptationSpeedDown")] 		public CFloat ToneMappingAdaptationSpeedDown { get; set;}

		[Ordinal(9)] [RED("environmentDefinition")] 		public CHandle<CEnvironmentDefinition> EnvironmentDefinition { get; set;}

		[Ordinal(10)] [RED("scenesEnvironmentDefinition")] 		public CHandle<CEnvironmentDefinition> ScenesEnvironmentDefinition { get; set;}

		[Ordinal(11)] [RED("speedTreeParameters")] 		public SGlobalSpeedTreeParameters SpeedTreeParameters { get; set;}

		[Ordinal(12)] [RED("weatherTemplate")] 		public CHandle<C2dArray> WeatherTemplate { get; set;}

		[Ordinal(13)] [RED("disableWaterShaders")] 		public CBool DisableWaterShaders { get; set;}

		[Ordinal(14)] [RED("skybox")] 		public SWorldSkyboxParameters Skybox { get; set;}

		[Ordinal(15)] [RED("lensFlare")] 		public SLensFlareGroupsParameters LensFlare { get; set;}

		[Ordinal(16)] [RED("renderSettings")] 		public SWorldRenderSettings RenderSettings { get; set;}

		[Ordinal(17)] [RED("localWindDampers")] 		public CHandle<CResourceSimplexTree> LocalWindDampers { get; set;}

		[Ordinal(18)] [RED("localWaterVisibility")] 		public CHandle<CResourceSimplexTree> LocalWaterVisibility { get; set;}

		public SWorldEnvironmentParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SWorldEnvironmentParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}