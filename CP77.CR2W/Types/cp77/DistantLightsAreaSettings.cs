using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DistantLightsAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("distantLightStartDistance")] public CFloat DistantLightStartDistance { get; set; }
		[Ordinal(1)]  [RED("distantLightFadeDistance")] public CFloat DistantLightFadeDistance { get; set; }

		public DistantLightsAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
