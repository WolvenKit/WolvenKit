using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnAudioDurationEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("performer")] public scnPerformerId Performer { get; set; }
		[Ordinal(7)] [RED("audioEventName")] public CName AudioEventName { get; set; }
		[Ordinal(8)] [RED("playbackDirectionSupport")] public CEnum<scnAudioPlaybackDirectionSupportFlag> PlaybackDirectionSupport { get; set; }

		public scnAudioDurationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
