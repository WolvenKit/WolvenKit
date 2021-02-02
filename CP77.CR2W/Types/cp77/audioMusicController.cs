using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioMusicController : CVariable
	{
		[Ordinal(0)]  [RED("muteEvent")] public CName MuteEvent { get; set; }
		[Ordinal(1)]  [RED("unmuteEvent")] public CName UnmuteEvent { get; set; }
		[Ordinal(2)]  [RED("playEvent")] public CName PlayEvent { get; set; }
		[Ordinal(3)]  [RED("stopEvent")] public CName StopEvent { get; set; }

		public audioMusicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
