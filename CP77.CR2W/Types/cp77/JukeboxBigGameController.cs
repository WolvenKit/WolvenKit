using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class JukeboxBigGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] [RED("onTogglePlayListener")] public CUInt32 OnTogglePlayListener { get; set; }

		public JukeboxBigGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
