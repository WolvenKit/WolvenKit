using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePingSystemReplicatedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)]  [RED("replicatedPingEntries")] public CArray<gamePingEntry> ReplicatedPingEntries { get; set; }

		public gamePingSystemReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
