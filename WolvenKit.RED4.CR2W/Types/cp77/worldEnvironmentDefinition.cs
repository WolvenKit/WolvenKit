using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEnvironmentDefinition : CResource
	{
		private WorldRenderAreaSettings _worldRenderSettings;
		private WorldShadowConfig _worldShadowConfig;
		private WorldLightingConfig _worldLightingConfig;
		private CArray<worldWeatherState> _weatherStates;
		private CArray<rRef<worldEnvironmentAreaParameters>> _areaEnvironmentParameterLayers;
		private CBool _resaved;

		[Ordinal(1)] 
		[RED("worldRenderSettings")] 
		public WorldRenderAreaSettings WorldRenderSettings
		{
			get => GetProperty(ref _worldRenderSettings);
			set => SetProperty(ref _worldRenderSettings, value);
		}

		[Ordinal(2)] 
		[RED("worldShadowConfig")] 
		public WorldShadowConfig WorldShadowConfig
		{
			get => GetProperty(ref _worldShadowConfig);
			set => SetProperty(ref _worldShadowConfig, value);
		}

		[Ordinal(3)] 
		[RED("worldLightingConfig")] 
		public WorldLightingConfig WorldLightingConfig
		{
			get => GetProperty(ref _worldLightingConfig);
			set => SetProperty(ref _worldLightingConfig, value);
		}

		[Ordinal(4)] 
		[RED("weatherStates")] 
		public CArray<worldWeatherState> WeatherStates
		{
			get => GetProperty(ref _weatherStates);
			set => SetProperty(ref _weatherStates, value);
		}

		[Ordinal(5)] 
		[RED("areaEnvironmentParameterLayers")] 
		public CArray<rRef<worldEnvironmentAreaParameters>> AreaEnvironmentParameterLayers
		{
			get => GetProperty(ref _areaEnvironmentParameterLayers);
			set => SetProperty(ref _areaEnvironmentParameterLayers, value);
		}

		[Ordinal(6)] 
		[RED("resaved")] 
		public CBool Resaved
		{
			get => GetProperty(ref _resaved);
			set => SetProperty(ref _resaved, value);
		}

		public worldEnvironmentDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
