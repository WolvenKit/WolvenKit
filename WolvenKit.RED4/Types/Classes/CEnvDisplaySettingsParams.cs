using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CEnvDisplaySettingsParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("enableInstantAdaptation")] 
		public CBool EnableInstantAdaptation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("enableGlobalLightingTrajectory")] 
		public CBool EnableGlobalLightingTrajectory
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("enableEnvProbeInstantUpdate")] 
		public CBool EnableEnvProbeInstantUpdate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("allowEnvProbeUpdate")] 
		public CBool AllowEnvProbeUpdate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("allowBloom")] 
		public CBool AllowBloom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("allowColorMod")] 
		public CBool AllowColorMod
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("allowAntialiasing")] 
		public CBool AllowAntialiasing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("allowGlobalFog")] 
		public CBool AllowGlobalFog
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("allowDOF")] 
		public CBool AllowDOF
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("allowSSAO")] 
		public CBool AllowSSAO
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("allowCloudsShadow")] 
		public CBool AllowCloudsShadow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("allowWaterShader")] 
		public CBool AllowWaterShader
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("gamma")] 
		public CFloat Gamma
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CEnvDisplaySettingsParams()
		{
			AllowEnvProbeUpdate = true;
			AllowBloom = true;
			AllowColorMod = true;
			AllowAntialiasing = true;
			AllowGlobalFog = true;
			AllowDOF = true;
			AllowSSAO = true;
			AllowCloudsShadow = true;
			AllowWaterShader = true;
			Gamma = 2.200000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
