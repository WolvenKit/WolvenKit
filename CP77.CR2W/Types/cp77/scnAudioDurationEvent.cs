using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnAudioDurationEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("audioEventName")] public CName AudioEventName { get; set; }
		[Ordinal(1)]  [RED("performer")] public scnPerformerId Performer { get; set; }
		[Ordinal(2)]  [RED("playbackDirectionSupport")] public CEnum<scnAudioPlaybackDirectionSupportFlag> PlaybackDirectionSupport { get; set; }

		public scnAudioDurationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
