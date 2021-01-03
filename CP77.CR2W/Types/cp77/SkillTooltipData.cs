using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SkillTooltipData : BasePerksMenuTooltipData
	{
		[Ordinal(0)]  [RED("attributeRecord")] public CHandle<gamedataAttribute_Record> AttributeRecord { get; set; }
		[Ordinal(1)]  [RED("proficiencyType")] public CEnum<gamedataProficiencyType> ProficiencyType { get; set; }
		[Ordinal(2)]  [RED("skillData")] public CHandle<ProficiencyDisplayData> SkillData { get; set; }

		public SkillTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
