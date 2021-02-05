using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCrowdPhaseTimePeriod : communityTimePeriod
	{
		[Ordinal(0)]  [RED("mergeMode")] public CEnum<gameCrowdCreationDataMergeMode> MergeMode { get; set; }
		[Ordinal(1)]  [RED("density")] public CFloat Density { get; set; }
		[Ordinal(2)]  [RED("Density")] public CName Density_ { get; set; }
		[Ordinal(3)]  [RED("workspotsUsage")] public CFloat WorkspotsUsage { get; set; }
		[Ordinal(4)]  [RED("charactersData")] public CArray<gameCrowdTemplateCharacterData> CharactersData { get; set; }
		[Ordinal(5)]  [RED("reducedCharactersData")] public CArray<gameCrowdTemplateCharacterData> ReducedCharactersData { get; set; }
		[Ordinal(6)]  [RED("crowdType")] public CEnum<gameCrowdEntryType> CrowdType { get; set; }
		[Ordinal(7)]  [RED("useDensityPreset")] public CBool UseDensityPreset { get; set; }

		public gameCrowdPhaseTimePeriod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
