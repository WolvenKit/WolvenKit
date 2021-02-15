using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalManagerSharedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)] [RED("entryData")] public CArray<gameJournalSharedStateData> EntryData { get; set; }
		[Ordinal(1)] [RED("trackedQuestPath")] public CUInt32 TrackedQuestPath { get; set; }

		public gameJournalManagerSharedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
