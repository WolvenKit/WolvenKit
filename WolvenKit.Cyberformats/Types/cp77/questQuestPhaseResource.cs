using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questQuestPhaseResource : graphGraphResource
	{
		[Ordinal(2)] [RED("phasePrefabs")] public CArray<questQuestPrefabEntry> PhasePrefabs { get; set; }

		public questQuestPhaseResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
