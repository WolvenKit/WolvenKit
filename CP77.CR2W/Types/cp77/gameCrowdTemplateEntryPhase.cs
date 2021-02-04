using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCrowdTemplateEntryPhase : CVariable
	{
		[Ordinal(0)]  [RED("phaseName")] public CName PhaseName { get; set; }
		[Ordinal(1)]  [RED("timePeriods")] public CArray<gameCrowdPhaseTimePeriod> TimePeriods { get; set; }
		[Ordinal(2)]  [RED("density")] public CFloat Density { get; set; }
		[Ordinal(3)]  [RED("charactersData")] public CArray<gameCrowdTemplateCharacterData> CharactersData { get; set; }
		[Ordinal(4)]  [RED("legacy")] public CBool Legacy { get; set; }
		[Ordinal(5)]  [RED("legacyDensityInTimePeriods")] public CBool LegacyDensityInTimePeriods { get; set; }
		[Ordinal(6)]  [RED("legacyCharactersData")] public CBool LegacyCharactersData { get; set; }

		public gameCrowdTemplateEntryPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
