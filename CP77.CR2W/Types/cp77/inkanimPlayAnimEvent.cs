using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimPlayAnimEvent : inkanimEvent
	{
		[Ordinal(1)] [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(2)] [RED("playbackOptions")] public inkanimPlaybackOptions PlaybackOptions { get; set; }

		public inkanimPlayAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
