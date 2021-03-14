using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DistantLightsAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("distantLightStartDistance")] public CFloat DistantLightStartDistance { get; set; }
		[Ordinal(3)] [RED("distantLightFadeDistance")] public CFloat DistantLightFadeDistance { get; set; }

		public DistantLightsAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
