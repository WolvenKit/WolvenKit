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
			WorldRenderSettings = new WorldRenderAreaSettings { AreaParameters = new() { new AmbientOverrideAreaSettings(), new AtmosphereAreaSettings(), new BloomAreaSettings(), new BlurAreaSettings(), new CameraAreaSettings(), new CharacterBrighteningAreaSettings(), new ChromaticAberrationAreaSettings(), new CloudAreaSettings(), new ColorGradingAreaSettings(), new ContactShadowsSettings(), new CustomLightAreaSettings(), new DistantFogAreaSettings(), new DistantIrradianceeSettings(), new DistantLightsAreaSettings(), new DistantProxiesSettings(), new EmissiveColorSettings(), new EmitterGroupAreaSettings(), new EnvironmentColorGroupsSettings(), new ExposureAreaSettings(), new FilmGrainAreaSettings(), new GlobalIlluminationSettings(), new GlobalLightOverrideAreaSettings(), new HACK_AREA_Settings(), new HeatHazeAreaSettings(), new ImageBasedFlareAreaSettings(), new LightAreaSettings(), new LightColorSettings(), new LightDirectionSettings(), new LightGroupsAreaSettings(), new MotionBlurAreaSettings(), new PathTracingSettings(), new RTAOAreaSettings(), new RTXDIAreaSettings(), new RainAreaSettings(), new RenderFeaturesAreaSettings(), new SSAOAreaSettings(), new SSSRAreaSettings(), new SharpeningAreaSettings(), new TonemappingAreaSettings { Mode = new TonemappingModeACES(), HdrMode = new TonemappingModeACES() }, new VignetteAreaSettings(), new VolumetricFogAreaSettings(), new WaterAreaSettings(), new WindAreaSettings() } };
			WorldShadowConfig = new WorldShadowConfig();
			WorldLightingConfig = new WorldLightingConfig();
			RenderSettingFactors = new RenderSettingFactors();
			WeatherStates = new();
			WeatherStateTransitions = new();
			AreaEnvironmentParameterLayers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
