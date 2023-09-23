using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldEnvironmentDefinition : CResource
	{
		[Ordinal(1)] 
		[RED("worldRenderSettings")] 
		public WorldRenderAreaSettings WorldRenderSettings
		{
			get => GetPropertyValue<WorldRenderAreaSettings>();
			set => SetPropertyValue<WorldRenderAreaSettings>(value);
		}

		[Ordinal(2)] 
		[RED("worldShadowConfig")] 
		public WorldShadowConfig WorldShadowConfig
		{
			get => GetPropertyValue<WorldShadowConfig>();
			set => SetPropertyValue<WorldShadowConfig>(value);
		}

		[Ordinal(3)] 
		[RED("worldLightingConfig")] 
		public WorldLightingConfig WorldLightingConfig
		{
			get => GetPropertyValue<WorldLightingConfig>();
			set => SetPropertyValue<WorldLightingConfig>(value);
		}

		[Ordinal(4)] 
		[RED("renderSettingFactors")] 
		public RenderSettingFactors RenderSettingFactors
		{
			get => GetPropertyValue<RenderSettingFactors>();
			set => SetPropertyValue<RenderSettingFactors>(value);
		}

		[Ordinal(5)] 
		[RED("weatherStates")] 
		public CArray<CHandle<worldWeatherState>> WeatherStates
		{
			get => GetPropertyValue<CArray<CHandle<worldWeatherState>>>();
			set => SetPropertyValue<CArray<CHandle<worldWeatherState>>>(value);
		}

		[Ordinal(6)] 
		[RED("weatherStateTransitions")] 
		public CArray<CHandle<worldWeatherStateTransition>> WeatherStateTransitions
		{
			get => GetPropertyValue<CArray<CHandle<worldWeatherStateTransition>>>();
			set => SetPropertyValue<CArray<CHandle<worldWeatherStateTransition>>>(value);
		}

		[Ordinal(7)] 
		[RED("areaEnvironmentParameterLayers")] 
		public CArray<CResourceReference<worldEnvironmentAreaParameters>> AreaEnvironmentParameterLayers
		{
			get => GetPropertyValue<CArray<CResourceReference<worldEnvironmentAreaParameters>>>();
			set => SetPropertyValue<CArray<CResourceReference<worldEnvironmentAreaParameters>>>(value);
		}

		[Ordinal(8)] 
		[RED("resourceVersion")] 
		public CUInt8 ResourceVersion
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public worldEnvironmentDefinition()
		{
			WorldRenderSettings = new WorldRenderAreaSettings { AreaParameters = new() { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null } };
			WorldShadowConfig = new WorldShadowConfig { ContactShadows = new ContactShadowsConfig { Range = 0.050000F, RangeLimit = 0.075000F, ScreenEdgeFadeRange = 0.150000F, DistanceFadeLimit = 3.000000F, DistanceFadeRange = 1.000000F }, DistantShadowsNumLevels = 3, DistantShadowsBaseLevelRadius = 250.000000F, FoliageShadowConfig = new FoliageShadowConfig { FoliageShadowCascadeGradient = 0.100000F, FoliageShadowCascadeFilterScale = 0.100000F, FoliageShadowCascadeGradientDistanceRange = 50.000000F } };
			WorldLightingConfig = new WorldLightingConfig { LightAttenuationClamp = 96.000000F };
			RenderSettingFactors = new RenderSettingFactors();
			WeatherStates = new();
			WeatherStateTransitions = new();
			AreaEnvironmentParameterLayers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
