using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPlayEnv_SetWeather : questIEnvironmentManagerNodeType
	{
		[Ordinal(0)]  [RED("weatherID")] public TweakDBID WeatherID { get; set; }
		[Ordinal(1)]  [RED("source")] public CName Source { get; set; }
		[Ordinal(2)]  [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(3)]  [RED("priority")] public CUInt32 Priority { get; set; }
		[Ordinal(4)]  [RED("reset")] public CBool Reset { get; set; }

		public questPlayEnv_SetWeather(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
