using FastMember;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;


namespace WolvenKit.RED3.CR2W.Types
{
    [DataContract(Namespace = "")]
	[REDMeta]
	public class CAreaEnvironmentParams : CVariable
	{
		[Ordinal(1)] [RED("m_finalColorBalance")] 		public CEnvFinalColorBalanceParameters M_finalColorBalance { get; set;}

		[Ordinal(2)] [RED("m_sharpen")] 		public CEnvSharpenParameters M_sharpen { get; set;}

		[Ordinal(3)] [RED("m_paintEffect")] 		public CEnvPaintEffectParameters M_paintEffect { get; set;}

		[Ordinal(4)] [RED("m_ssaoNV")] 		public CEnvNVSSAOParameters M_ssaoNV { get; set;}

		[Ordinal(5)] [RED("m_ssaoMS")] 		public CEnvMSSSAOParameters M_ssaoMS { get; set;}

		[Ordinal(6)] [RED("m_globalLight")] 		public CEnvGlobalLightParameters M_globalLight { get; set;}

		[Ordinal(7)] [RED("m_interiorFallback")] 		public CEnvInteriorFallbackParameters M_interiorFallback { get; set;}

		[Ordinal(8)] [RED("m_speedTree")] 		public CEnvSpeedTreeParameters M_speedTree { get; set;}

		[Ordinal(9)] [RED("m_toneMapping")] 		public CEnvToneMappingParameters M_toneMapping { get; set;}

		[Ordinal(10)] [RED("m_bloomNew")] 		public CEnvBloomNewParameters M_bloomNew { get; set;}

		[Ordinal(11)] [RED("m_globalFog")] 		public CEnvGlobalFogParameters M_globalFog { get; set;}

		[Ordinal(12)] [RED("m_sky")] 		public CEnvGlobalSkyParameters M_sky { get; set;}

		[Ordinal(13)] [RED("m_depthOfField")] 		public CEnvDepthOfFieldParameters M_depthOfField { get; set;}

		[Ordinal(14)] [RED("m_colorModTransparency")] 		public CEnvColorModTransparencyParameters M_colorModTransparency { get; set;}

		[Ordinal(15)] [RED("m_shadows")] 		public CEnvShadowsParameters M_shadows { get; set;}

		[Ordinal(16)] [RED("m_water")] 		public CEnvWaterParameters M_water { get; set;}

		[Ordinal(17)] [RED("m_colorGroups")] 		public CEnvColorGroupsParameters M_colorGroups { get; set;}

		[Ordinal(18)] [RED("m_flareColorGroups")] 		public CEnvFlareColorGroupsParameters M_flareColorGroups { get; set;}

		[Ordinal(19)] [RED("m_sunAndMoonParams")] 		public CEnvSunAndMoonParameters M_sunAndMoonParams { get; set;}

		[Ordinal(20)] [RED("m_windParams")] 		public CEnvWindParameters M_windParams { get; set;}

		[Ordinal(21)] [RED("m_gameplayEffects")] 		public CEnvGameplayEffectsParameters M_gameplayEffects { get; set;}

		[Ordinal(22)] [RED("m_motionBlur")] 		public CEnvMotionBlurParameters M_motionBlur { get; set;}

		[Ordinal(23)] [RED("m_cameraLightsSetup")] 		public CEnvCameraLightsSetupParameters M_cameraLightsSetup { get; set;}

		[Ordinal(24)] [RED("m_dialogLightParams")] 		public CEnvDialogLightParameters M_dialogLightParams { get; set;}

		public CAreaEnvironmentParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}