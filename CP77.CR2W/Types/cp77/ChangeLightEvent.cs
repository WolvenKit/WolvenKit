using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChangeLightEvent : redEvent
	{
		[Ordinal(0)]  [RED("settings")] public ScriptLightSettings Settings { get; set; }
		[Ordinal(1)]  [RED("time")] public CFloat Time { get; set; }
		[Ordinal(2)]  [RED("curve")] public CName Curve { get; set; }
		[Ordinal(3)]  [RED("loop")] public CBool Loop { get; set; }

		public ChangeLightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
