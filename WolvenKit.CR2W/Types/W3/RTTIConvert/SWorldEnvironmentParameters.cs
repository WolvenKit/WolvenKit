using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SWorldEnvironmentParameters : CVariable
	{
		[RED("vignetteTexture")] 		public CHandle<CBitmapTexture> VignetteTexture { get; set;}

		[RED("cameraDirtTexture")] 		public CHandle<CBitmapTexture> CameraDirtTexture { get; set;}

		[RED("interiorFallbackAmbientTexture")] 		public CHandle<CCubeTexture> InteriorFallbackAmbientTexture { get; set;}

		[RED("interiorFallbackReflectionTexture")] 		public CHandle<CCubeTexture> InteriorFallbackReflectionTexture { get; set;}

		[RED("cameraDirtNumVerticalTiles")] 		public CFloat CameraDirtNumVerticalTiles { get; set;}

		[RED("globalLightingTrajectory")] 		public CGlobalLightingTrajectory GlobalLightingTrajectory { get; set;}

		[RED("toneMappingAdaptationSpeedUp")] 		public CFloat ToneMappingAdaptationSpeedUp { get; set;}

		[RED("toneMappingAdaptationSpeedDown")] 		public CFloat ToneMappingAdaptationSpeedDown { get; set;}

		[RED("environmentDefinition")] 		public CHandle<CEnvironmentDefinition> EnvironmentDefinition { get; set;}

		[RED("scenesEnvironmentDefinition")] 		public CHandle<CEnvironmentDefinition> ScenesEnvironmentDefinition { get; set;}

		[RED("speedTreeParameters")] 		public SGlobalSpeedTreeParameters SpeedTreeParameters { get; set;}

		[RED("weatherTemplate")] 		public CHandle<C2dArray> WeatherTemplate { get; set;}

		[RED("disableWaterShaders")] 		public CBool DisableWaterShaders { get; set;}

		[RED("skybox")] 		public SWorldSkyboxParameters Skybox { get; set;}

		[RED("lensFlare")] 		public SLensFlareGroupsParameters LensFlare { get; set;}

		[RED("renderSettings")] 		public SWorldRenderSettings RenderSettings { get; set;}

		[RED("localWindDampers")] 		public CHandle<CResourceSimplexTree> LocalWindDampers { get; set;}

		[RED("localWaterVisibility")] 		public CHandle<CResourceSimplexTree> LocalWaterVisibility { get; set;}

		public SWorldEnvironmentParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SWorldEnvironmentParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}