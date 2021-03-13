using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSavedStatsData : CVariable
	{
		[Ordinal(0)] [RED("statModifiers")] public CArray<CHandle<gameStatModifierData>> StatModifiers { get; set; }
		[Ordinal(1)] [RED("inactiveStats")] public CArray<CEnum<gamedataStatType>> InactiveStats { get; set; }
		[Ordinal(2)] [RED("recordID")] public TweakDBID RecordID { get; set; }
		[Ordinal(3)] [RED("seed")] public CUInt32 Seed { get; set; }

		public gameSavedStatsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
