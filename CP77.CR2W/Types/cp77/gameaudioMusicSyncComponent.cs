using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameaudioMusicSyncComponent : entIComponent
	{
		[Ordinal(0)]  [RED("notifyBarProgression")] public CBool NotifyBarProgression { get; set; }
		[Ordinal(1)]  [RED("notifyBars")] public CBool NotifyBars { get; set; }
		[Ordinal(2)]  [RED("notifyBeatProgression")] public CBool NotifyBeatProgression { get; set; }
		[Ordinal(3)]  [RED("notifyBeats")] public CBool NotifyBeats { get; set; }
		[Ordinal(4)]  [RED("notifyGrid")] public CBool NotifyGrid { get; set; }
		[Ordinal(5)]  [RED("syncTrack")] public CName SyncTrack { get; set; }

		public gameaudioMusicSyncComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
