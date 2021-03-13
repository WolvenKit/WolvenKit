using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LightColorSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("light")] public worldWorldGlobalLightParameters Light { get; set; }

		public LightColorSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
