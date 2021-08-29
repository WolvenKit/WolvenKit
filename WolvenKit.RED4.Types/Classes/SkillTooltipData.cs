using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SkillTooltipData : BasePerksMenuTooltipData
	{
		private CEnum<gamedataProficiencyType> _proficiencyType;
		private CHandle<gamedataAttribute_Record> _attributeRecord;
		private CHandle<ProficiencyDisplayData> _skillData;

		[Ordinal(1)] 
		[RED("proficiencyType")] 
		public CEnum<gamedataProficiencyType> ProficiencyType
		{
			get => GetProperty(ref _proficiencyType);
			set => SetProperty(ref _proficiencyType, value);
		}

		[Ordinal(2)] 
		[RED("attributeRecord")] 
		public CHandle<gamedataAttribute_Record> AttributeRecord
		{
			get => GetProperty(ref _attributeRecord);
			set => SetProperty(ref _attributeRecord, value);
		}

		[Ordinal(3)] 
		[RED("skillData")] 
		public CHandle<ProficiencyDisplayData> SkillData
		{
			get => GetProperty(ref _skillData);
			set => SetProperty(ref _skillData, value);
		}
	}
}
