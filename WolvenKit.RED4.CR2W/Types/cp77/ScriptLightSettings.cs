using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptLightSettings : CVariable
	{
		[Ordinal(0)] [RED("strength")] public CFloat Strength { get; set; }
		[Ordinal(1)] [RED("color")] public CColor Color { get; set; }

		public ScriptLightSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
