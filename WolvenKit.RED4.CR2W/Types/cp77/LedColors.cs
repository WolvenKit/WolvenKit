using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LedColors : CVariable
	{
		[Ordinal(0)] [RED("off")] public ScriptLightSettings Off { get; set; }
		[Ordinal(1)] [RED("red")] public ScriptLightSettings Red { get; set; }
		[Ordinal(2)] [RED("green")] public ScriptLightSettings Green { get; set; }

		public LedColors(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
