using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProficiencyDisplayData : IDisplayData
	{
		[Ordinal(0)]  [RED("attributeId")] public TweakDBID AttributeId { get; set; }
		[Ordinal(1)]  [RED("proficiency")] public CEnum<gamedataProficiencyType> Proficiency { get; set; }
		[Ordinal(2)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(3)]  [RED("areas")] public CArray<CHandle<AreaDisplayData>> Areas { get; set; }
		[Ordinal(4)]  [RED("passiveBonusesData")] public CArray<CHandle<LevelRewardDisplayData>> PassiveBonusesData { get; set; }
		[Ordinal(5)]  [RED("traitData")] public CHandle<TraitDisplayData> TraitData { get; set; }
		[Ordinal(6)]  [RED("localizedName")] public CString LocalizedName { get; set; }
		[Ordinal(7)]  [RED("localizedDescription")] public CString LocalizedDescription { get; set; }
		[Ordinal(8)]  [RED("level")] public CInt32 Level { get; set; }
		[Ordinal(9)]  [RED("maxLevel")] public CInt32 MaxLevel { get; set; }
		[Ordinal(10)]  [RED("expPoints")] public CInt32 ExpPoints { get; set; }
		[Ordinal(11)]  [RED("maxExpPoints")] public CInt32 MaxExpPoints { get; set; }
		[Ordinal(12)]  [RED("unlockedLevel")] public CInt32 UnlockedLevel { get; set; }

		public ProficiencyDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
