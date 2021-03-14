using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SkillTooltipData : BasePerksMenuTooltipData
	{
		private CEnum<gamedataProficiencyType> _proficiencyType;
		private CHandle<gamedataAttribute_Record> _attributeRecord;
		private CHandle<ProficiencyDisplayData> _skillData;

		[Ordinal(1)] 
		[RED("proficiencyType")] 
		public CEnum<gamedataProficiencyType> ProficiencyType
		{
			get
			{
				if (_proficiencyType == null)
				{
					_proficiencyType = (CEnum<gamedataProficiencyType>) CR2WTypeManager.Create("gamedataProficiencyType", "proficiencyType", cr2w, this);
				}
				return _proficiencyType;
			}
			set
			{
				if (_proficiencyType == value)
				{
					return;
				}
				_proficiencyType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("attributeRecord")] 
		public CHandle<gamedataAttribute_Record> AttributeRecord
		{
			get
			{
				if (_attributeRecord == null)
				{
					_attributeRecord = (CHandle<gamedataAttribute_Record>) CR2WTypeManager.Create("handle:gamedataAttribute_Record", "attributeRecord", cr2w, this);
				}
				return _attributeRecord;
			}
			set
			{
				if (_attributeRecord == value)
				{
					return;
				}
				_attributeRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("skillData")] 
		public CHandle<ProficiencyDisplayData> SkillData
		{
			get
			{
				if (_skillData == null)
				{
					_skillData = (CHandle<ProficiencyDisplayData>) CR2WTypeManager.Create("handle:ProficiencyDisplayData", "skillData", cr2w, this);
				}
				return _skillData;
			}
			set
			{
				if (_skillData == value)
				{
					return;
				}
				_skillData = value;
				PropertySet(this);
			}
		}

		public SkillTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
