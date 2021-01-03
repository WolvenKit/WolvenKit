using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questQuestsSystemReplicatedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)]  [RED("replicatedQuestPrefabs")] public CArray<questQuestPrefabsEntry> ReplicatedQuestPrefabs { get; set; }

		public questQuestsSystemReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
