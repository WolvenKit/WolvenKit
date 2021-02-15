using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GlobalLightOverrideAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("color")] public curveData<HDRColor> Color { get; set; }
		[Ordinal(3)] [RED("lightAzimuth")] public CFloat LightAzimuth { get; set; }
		[Ordinal(4)] [RED("lightElevation")] public CFloat LightElevation { get; set; }

		public GlobalLightOverrideAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
