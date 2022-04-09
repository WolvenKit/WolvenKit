using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SkillTooltipData : BasePerksMenuTooltipData
	{
		[Ordinal(1)] 
		[RED("proficiencyType")] 
		public CEnum<gamedataProficiencyType> ProficiencyType
		{
			get => GetPropertyValue<CEnum<gamedataProficiencyType>>();
			set => SetPropertyValue<CEnum<gamedataProficiencyType>>(value);
		}

		[Ordinal(2)] 
		[RED("attributeRecord")] 
		public CHandle<gamedataAttribute_Record> AttributeRecord
		{
			get => GetPropertyValue<CHandle<gamedataAttribute_Record>>();
			set => SetPropertyValue<CHandle<gamedataAttribute_Record>>(value);
		}

		[Ordinal(3)] 
		[RED("skillData")] 
		public CHandle<ProficiencyDisplayData> SkillData
		{
			get => GetPropertyValue<CHandle<ProficiencyDisplayData>>();
			set => SetPropertyValue<CHandle<ProficiencyDisplayData>>(value);
		}

		public SkillTooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
