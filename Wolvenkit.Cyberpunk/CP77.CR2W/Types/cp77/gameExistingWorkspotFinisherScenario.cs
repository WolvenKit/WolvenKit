using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameExistingWorkspotFinisherScenario : gameIFinisherScenario
	{
		[Ordinal(0)]  [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(1)]  [RED("playbackDelay")] public CFloat PlaybackDelay { get; set; }
		[Ordinal(2)]  [RED("playerWorkspot")] public raRef<workWorkspotResource> PlayerWorkspot { get; set; }
		[Ordinal(3)]  [RED("syncAnimSlotName")] public CName SyncAnimSlotName { get; set; }

		public gameExistingWorkspotFinisherScenario(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
