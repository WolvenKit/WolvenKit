using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioMusicController : CVariable
	{
		[Ordinal(0)]  [RED("muteEvent")] public CName MuteEvent { get; set; }
		[Ordinal(1)]  [RED("playEvent")] public CName PlayEvent { get; set; }
		[Ordinal(2)]  [RED("stopEvent")] public CName StopEvent { get; set; }
		[Ordinal(3)]  [RED("unmuteEvent")] public CName UnmuteEvent { get; set; }

		public audioMusicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
