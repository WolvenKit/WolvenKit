using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldEnvironmentDefinition : CResource
	{
		[Ordinal(1)] [RED("worldRenderSettings")] public WorldRenderAreaSettings WorldRenderSettings { get; set; }
		[Ordinal(2)] [RED("worldShadowConfig")] public WorldShadowConfig WorldShadowConfig { get; set; }
		[Ordinal(3)] [RED("worldLightingConfig")] public WorldLightingConfig WorldLightingConfig { get; set; }
		[Ordinal(4)] [RED("weatherStates")] public CArray<worldWeatherState> WeatherStates { get; set; }
		[Ordinal(5)] [RED("areaEnvironmentParameterLayers")] public CArray<rRef<worldEnvironmentAreaParameters>> AreaEnvironmentParameterLayers { get; set; }
		[Ordinal(6)] [RED("resaved")] public CBool Resaved { get; set; }

		public worldEnvironmentDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
