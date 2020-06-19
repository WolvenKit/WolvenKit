using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAreaEnvironmentParams : CVariable
	{
		[RED("m_finalColorBalance")] 		public CEnvFinalColorBalanceParameters M_finalColorBalance { get; set;}

		[RED("m_sharpen")] 		public CEnvSharpenParameters M_sharpen { get; set;}

		[RED("m_paintEffect")] 		public CEnvPaintEffectParameters M_paintEffect { get; set;}

		[RED("m_ssaoNV")] 		public CEnvNVSSAOParameters M_ssaoNV { get; set;}

		[RED("m_ssaoMS")] 		public CEnvMSSSAOParameters M_ssaoMS { get; set;}

		[RED("m_globalLight")] 		public CEnvGlobalLightParameters M_globalLight { get; set;}

		[RED("m_interiorFallback")] 		public CEnvInteriorFallbackParameters M_interiorFallback { get; set;}

		[RED("m_speedTree")] 		public CEnvSpeedTreeParameters M_speedTree { get; set;}

		[RED("m_toneMapping")] 		public CEnvToneMappingParameters M_toneMapping { get; set;}

		[RED("m_bloomNew")] 		public CEnvBloomNewParameters M_bloomNew { get; set;}

		[RED("m_globalFog")] 		public CEnvGlobalFogParameters M_globalFog { get; set;}

		[RED("m_sky")] 		public CEnvGlobalSkyParameters M_sky { get; set;}

		[RED("m_depthOfField")] 		public CEnvDepthOfFieldParameters M_depthOfField { get; set;}

		[RED("m_colorModTransparency")] 		public CEnvColorModTransparencyParameters M_colorModTransparency { get; set;}

		[RED("m_shadows")] 		public CEnvShadowsParameters M_shadows { get; set;}

		[RED("m_water")] 		public CEnvWaterParameters M_water { get; set;}

		[RED("m_colorGroups")] 		public CEnvColorGroupsParameters M_colorGroups { get; set;}

		[RED("m_flareColorGroups")] 		public CEnvFlareColorGroupsParameters M_flareColorGroups { get; set;}

		[RED("m_sunAndMoonParams")] 		public CEnvSunAndMoonParameters M_sunAndMoonParams { get; set;}

		[RED("m_windParams")] 		public CEnvWindParameters M_windParams { get; set;}

		[RED("m_gameplayEffects")] 		public CEnvGameplayEffectsParameters M_gameplayEffects { get; set;}

		[RED("m_motionBlur")] 		public CEnvMotionBlurParameters M_motionBlur { get; set;}

		[RED("m_cameraLightsSetup")] 		public CEnvCameraLightsSetupParameters M_cameraLightsSetup { get; set;}

		[RED("m_dialogLightParams")] 		public CEnvDialogLightParameters M_dialogLightParams { get; set;}

		public CAreaEnvironmentParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAreaEnvironmentParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}