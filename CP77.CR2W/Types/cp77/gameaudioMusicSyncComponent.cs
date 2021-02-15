using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameaudioMusicSyncComponent : entIComponent
	{
		[Ordinal(3)] [RED("notifyBeats")] public CBool NotifyBeats { get; set; }
		[Ordinal(4)] [RED("notifyBars")] public CBool NotifyBars { get; set; }
		[Ordinal(5)] [RED("notifyGrid")] public CBool NotifyGrid { get; set; }
		[Ordinal(6)] [RED("notifyBarProgression")] public CBool NotifyBarProgression { get; set; }
		[Ordinal(7)] [RED("notifyBeatProgression")] public CBool NotifyBeatProgression { get; set; }
		[Ordinal(8)] [RED("syncTrack")] public CName SyncTrack { get; set; }

		public gameaudioMusicSyncComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
