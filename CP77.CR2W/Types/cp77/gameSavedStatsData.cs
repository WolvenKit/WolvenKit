using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSavedStatsData : CVariable
	{
		[Ordinal(0)]  [RED("inactiveStats")] public CArray<CEnum<gamedataStatType>> InactiveStats { get; set; }
		[Ordinal(1)]  [RED("recordID")] public TweakDBID RecordID { get; set; }
		[Ordinal(2)]  [RED("seed")] public CUInt32 Seed { get; set; }
		[Ordinal(3)]  [RED("statModifiers")] public CArray<CHandle<gameStatModifierData>> StatModifiers { get; set; }

		public gameSavedStatsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
