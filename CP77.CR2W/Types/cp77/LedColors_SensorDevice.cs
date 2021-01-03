using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LedColors_SensorDevice : CVariable
	{
		[Ordinal(0)]  [RED("blue")] public ScriptLightSettings Blue { get; set; }
		[Ordinal(1)]  [RED("green")] public ScriptLightSettings Green { get; set; }
		[Ordinal(2)]  [RED("off")] public ScriptLightSettings Off { get; set; }
		[Ordinal(3)]  [RED("red")] public ScriptLightSettings Red { get; set; }
		[Ordinal(4)]  [RED("white")] public ScriptLightSettings White { get; set; }
		[Ordinal(5)]  [RED("yellow")] public ScriptLightSettings Yellow { get; set; }

		public LedColors_SensorDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
