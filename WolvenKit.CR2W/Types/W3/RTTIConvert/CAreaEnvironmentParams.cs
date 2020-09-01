using FastMember;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAreaEnvironmentParams : CVariable
	{
		[Ordinal(0)] [Ordinal(0)] [RED("m_finalColorBalance")] 		public CEnvFinalColorBalanceParameters M_finalColorBalance { get; set;}

		[Ordinal(1)] [Ordinal(0)] [RED("m_sharpen")] 		public CEnvSharpenParameters M_sharpen { get; set;}

		[Ordinal(2)] [Ordinal(0)] [RED("m_paintEffect")] 		public CEnvPaintEffectParameters M_paintEffect { get; set;}

		[Ordinal(3)] [Ordinal(0)] [RED("m_ssaoNV")] 		public CEnvNVSSAOParameters M_ssaoNV { get; set;}

		[Ordinal(4)] [Ordinal(0)] [RED("m_ssaoMS")] 		public CEnvMSSSAOParameters M_ssaoMS { get; set;}

		[Ordinal(5)] [Ordinal(0)] [RED("m_globalLight")] 		public CEnvGlobalLightParameters M_globalLight { get; set;}

		[Ordinal(6)] [Ordinal(0)] [RED("m_interiorFallback")] 		public CEnvInteriorFallbackParameters M_interiorFallback { get; set;}

		[Ordinal(7)] [Ordinal(0)] [RED("m_speedTree")] 		public CEnvSpeedTreeParameters M_speedTree { get; set;}

		[Ordinal(8)] [Ordinal(0)] [RED("m_toneMapping")] 		public CEnvToneMappingParameters M_toneMapping { get; set;}

		[Ordinal(9)] [Ordinal(0)] [RED("m_bloomNew")] 		public CEnvBloomNewParameters M_bloomNew { get; set;}

		[Ordinal(10)] [Ordinal(0)] [RED("m_globalFog")] 		public CEnvGlobalFogParameters M_globalFog { get; set;}

		[Ordinal(11)] [Ordinal(0)] [RED("m_sky")] 		public CEnvGlobalSkyParameters M_sky { get; set;}

		[Ordinal(12)] [Ordinal(0)] [RED("m_depthOfField")] 		public CEnvDepthOfFieldParameters M_depthOfField { get; set;}

		[Ordinal(13)] [Ordinal(0)] [RED("m_colorModTransparency")] 		public CEnvColorModTransparencyParameters M_colorModTransparency { get; set;}

		[Ordinal(14)] [Ordinal(0)] [RED("m_shadows")] 		public CEnvShadowsParameters M_shadows { get; set;}

		[Ordinal(15)] [Ordinal(0)] [RED("m_water")] 		public CEnvWaterParameters M_water { get; set;}

		[Ordinal(16)] [Ordinal(0)] [RED("m_colorGroups")] 		public CEnvColorGroupsParameters M_colorGroups { get; set;}

		[Ordinal(17)] [Ordinal(0)] [RED("m_flareColorGroups")] 		public CEnvFlareColorGroupsParameters M_flareColorGroups { get; set;}

		[Ordinal(18)] [Ordinal(0)] [RED("m_sunAndMoonParams")] 		public CEnvSunAndMoonParameters M_sunAndMoonParams { get; set;}

		[Ordinal(19)] [Ordinal(0)] [RED("m_windParams")] 		public CEnvWindParameters M_windParams { get; set;}

		[Ordinal(20)] [Ordinal(0)] [RED("m_gameplayEffects")] 		public CEnvGameplayEffectsParameters M_gameplayEffects { get; set;}

		[Ordinal(21)] [Ordinal(0)] [RED("m_motionBlur")] 		public CEnvMotionBlurParameters M_motionBlur { get; set;}

		[Ordinal(22)] [Ordinal(0)] [RED("m_cameraLightsSetup")] 		public CEnvCameraLightsSetupParameters M_cameraLightsSetup { get; set;}

		[Ordinal(23)] [Ordinal(0)] [RED("m_dialogLightParams")] 		public CEnvDialogLightParameters M_dialogLightParams { get; set;}

		public CAreaEnvironmentParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}