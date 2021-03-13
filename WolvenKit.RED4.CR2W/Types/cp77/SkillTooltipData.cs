using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SkillTooltipData : BasePerksMenuTooltipData
	{
		[Ordinal(1)] [RED("proficiencyType")] public CEnum<gamedataProficiencyType> ProficiencyType { get; set; }
		[Ordinal(2)] [RED("attributeRecord")] public CHandle<gamedataAttribute_Record> AttributeRecord { get; set; }
		[Ordinal(3)] [RED("skillData")] public CHandle<ProficiencyDisplayData> SkillData { get; set; }

		public SkillTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
