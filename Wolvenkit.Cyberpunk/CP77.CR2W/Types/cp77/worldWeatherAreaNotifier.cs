using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldWeatherAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(0)]  [RED("horizontalFadeDistance")] public CFloat HorizontalFadeDistance { get; set; }
		[Ordinal(1)]  [RED("verticalFadeDistance")] public CFloat VerticalFadeDistance { get; set; }
		[Ordinal(2)]  [RED("weatherStateNames")] public CArray<CName> WeatherStateNames { get; set; }
		[Ordinal(3)]  [RED("weatherStateValues")] public CArray<CFloat> WeatherStateValues { get; set; }

		public worldWeatherAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
