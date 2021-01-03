using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DistantLightsAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("distantLightFadeDistance")] public CFloat DistantLightFadeDistance { get; set; }
		[Ordinal(1)]  [RED("distantLightStartDistance")] public CFloat DistantLightStartDistance { get; set; }

		public DistantLightsAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
