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
			get
			{
				if (_worldRenderSettings == null)
				{
					_worldRenderSettings = (WorldRenderAreaSettings) CR2WTypeManager.Create("WorldRenderAreaSettings", "worldRenderSettings", cr2w, this);
				}
				return _worldRenderSettings;
			}
			set
			{
				if (_worldRenderSettings == value)
				{
					return;
				}
				_worldRenderSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("worldShadowConfig")] 
		public WorldShadowConfig WorldShadowConfig
		{
			get
			{
				if (_worldShadowConfig == null)
				{
					_worldShadowConfig = (WorldShadowConfig) CR2WTypeManager.Create("WorldShadowConfig", "worldShadowConfig", cr2w, this);
				}
				return _worldShadowConfig;
			}
			set
			{
				if (_worldShadowConfig == value)
				{
					return;
				}
				_worldShadowConfig = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("worldLightingConfig")] 
		public WorldLightingConfig WorldLightingConfig
		{
			get
			{
				if (_worldLightingConfig == null)
				{
					_worldLightingConfig = (WorldLightingConfig) CR2WTypeManager.Create("WorldLightingConfig", "worldLightingConfig", cr2w, this);
				}
				return _worldLightingConfig;
			}
			set
			{
				if (_worldLightingConfig == value)
				{
					return;
				}
				_worldLightingConfig = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("weatherStates")] 
		public CArray<worldWeatherState> WeatherStates
		{
			get
			{
				if (_weatherStates == null)
				{
					_weatherStates = (CArray<worldWeatherState>) CR2WTypeManager.Create("array:worldWeatherState", "weatherStates", cr2w, this);
				}
				return _weatherStates;
			}
			set
			{
				if (_weatherStates == value)
				{
					return;
				}
				_weatherStates = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("areaEnvironmentParameterLayers")] 
		public CArray<rRef<worldEnvironmentAreaParameters>> AreaEnvironmentParameterLayers
		{
			get
			{
				if (_areaEnvironmentParameterLayers == null)
				{
					_areaEnvironmentParameterLayers = (CArray<rRef<worldEnvironmentAreaParameters>>) CR2WTypeManager.Create("array:rRef:worldEnvironmentAreaParameters", "areaEnvironmentParameterLayers", cr2w, this);
				}
				return _areaEnvironmentParameterLayers;
			}
			set
			{
				if (_areaEnvironmentParameterLayers == value)
				{
					return;
				}
				_areaEnvironmentParameterLayers = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("resaved")] 
		public CBool Resaved
		{
			get
			{
				if (_resaved == null)
				{
					_resaved = (CBool) CR2WTypeManager.Create("Bool", "resaved", cr2w, this);
				}
				return _resaved;
			}
			set
			{
				if (_resaved == value)
				{
					return;
				}
				_resaved = value;
				PropertySet(this);
			}
		}

		public worldEnvironmentDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
