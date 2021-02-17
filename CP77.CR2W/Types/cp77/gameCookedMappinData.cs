using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCookedMappinData : CVariable
	{
		[Ordinal(0)] [RED("journalPathHash")] public CUInt32 JournalPathHash { get; set; }
		[Ordinal(1)] [RED("position")] public Vector3 Position { get; set; }
		[Ordinal(2)] [RED("volume")] public CHandle<gamemappinsIMappinVolume> Volume { get; set; }

		public gameCookedMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
