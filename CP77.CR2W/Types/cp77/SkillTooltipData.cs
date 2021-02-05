using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SkillTooltipData : BasePerksMenuTooltipData
	{
		[Ordinal(0)]  [RED("manager")] public CHandle<PlayerDevelopmentDataManager> Manager { get; set; }
		[Ordinal(1)]  [RED("proficiencyType")] public CEnum<gamedataProficiencyType> ProficiencyType { get; set; }
		[Ordinal(2)]  [RED("attributeRecord")] public CHandle<gamedataAttribute_Record> AttributeRecord { get; set; }
		[Ordinal(3)]  [RED("skillData")] public CHandle<ProficiencyDisplayData> SkillData { get; set; }

		public SkillTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
