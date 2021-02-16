using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCookedMultiMappinData : CVariable
	{
		[Ordinal(0)] [RED("journalPathHash")] public CUInt32 JournalPathHash { get; set; }
		[Ordinal(1)] [RED("positions")] public CArray<Vector3> Positions { get; set; }

		public gameCookedMultiMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
