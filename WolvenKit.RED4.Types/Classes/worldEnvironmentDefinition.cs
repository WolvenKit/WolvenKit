using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		[RED("weatherStates")] 
		public CArray<worldWeatherState> WeatherStates
		{
			get => GetPropertyValue<CArray<worldWeatherState>>();
			set => SetPropertyValue<CArray<worldWeatherState>>(value);
		}

		[Ordinal(5)] 
		[RED("areaEnvironmentParameterLayers")] 
		public CArray<CResourceReference<worldEnvironmentAreaParameters>> AreaEnvironmentParameterLayers
		{
			get => GetPropertyValue<CArray<CResourceReference<worldEnvironmentAreaParameters>>>();
			set => SetPropertyValue<CArray<CResourceReference<worldEnvironmentAreaParameters>>>(value);
		}

		[Ordinal(6)] 
		[RED("resaved")] 
		public CBool Resaved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldEnvironmentDefinition()
		{
			WorldRenderSettings = new() { AreaParameters = new() { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null } };
			WorldShadowConfig = new() { ContactShadows = new() { Range = 0.050000F, RangeLimit = 0.075000F, ScreenEdgeFadeRange = 0.150000F, DistanceFadeLimit = 3.000000F, DistanceFadeRange = 1.000000F }, DistantShadowsNumLevels = 3, DistantShadowsBaseLevelRadius = 250.000000F, FoliageShadowConfig = new() { FoliageShadowCascadeGradient = 0.100000F, FoliageShadowCascadeFilterScale = 0.100000F, FoliageShadowCascadeGradientDistanceRange = 50.000000F } };
			WorldLightingConfig = new() { LightAttenuationClamp = 96.000000F };
			WeatherStates = new();
			AreaEnvironmentParameterLayers = new();
		}
	}
}
