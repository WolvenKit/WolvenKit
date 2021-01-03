using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamemappinsMappinSystemReplicatedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)]  [RED("mappinState")] public CArray<gameNewMappinID> MappinState { get; set; }
		[Ordinal(1)]  [RED("mappinWithJournalState")] public CArray<CUInt32> MappinWithJournalState { get; set; }

		public gamemappinsMappinSystemReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
