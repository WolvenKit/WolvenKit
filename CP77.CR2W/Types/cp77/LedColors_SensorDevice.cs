using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LedColors_SensorDevice : CVariable
	{
		[Ordinal(0)]  [RED("off")] public ScriptLightSettings Off { get; set; }
		[Ordinal(1)]  [RED("red")] public ScriptLightSettings Red { get; set; }
		[Ordinal(2)]  [RED("green")] public ScriptLightSettings Green { get; set; }
		[Ordinal(3)]  [RED("blue")] public ScriptLightSettings Blue { get; set; }
		[Ordinal(4)]  [RED("yellow")] public ScriptLightSettings Yellow { get; set; }
		[Ordinal(5)]  [RED("white")] public ScriptLightSettings White { get; set; }

		public LedColors_SensorDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
