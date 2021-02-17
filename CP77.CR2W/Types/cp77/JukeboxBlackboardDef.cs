using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class JukeboxBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] [RED("IsPlaying")] public gamebbScriptID_Bool IsPlaying { get; set; }

		public JukeboxBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
