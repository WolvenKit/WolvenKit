using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerkTooltipData : BasePerksMenuTooltipData
	{
		[Ordinal(1)] 
		[RED("perkType")] 
		public CEnum<gamedataNewPerkType> PerkType
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkType>>(value);
		}

		[Ordinal(2)] 
		[RED("perkArea")] 
		public CEnum<gamedataNewPerkSlotType> PerkArea
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkSlotType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkSlotType>>(value);
		}

		[Ordinal(3)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("proficiency")] 
		public CEnum<gamedataProficiencyType> Proficiency
		{
			get => GetPropertyValue<CEnum<gamedataProficiencyType>>();
			set => SetPropertyValue<CEnum<gamedataProficiencyType>>(value);
		}

		[Ordinal(5)] 
		[RED("isRipperdoc")] 
		public CBool IsRipperdoc
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("perkData")] 
		public CHandle<NewPerkDisplayData> PerkData
		{
			get => GetPropertyValue<CHandle<NewPerkDisplayData>>();
			set => SetPropertyValue<CHandle<NewPerkDisplayData>>(value);
		}

		[Ordinal(7)] 
		[RED("attributeData")] 
		public CHandle<AttributeData> AttributeData
		{
			get => GetPropertyValue<CHandle<AttributeData>>();
			set => SetPropertyValue<CHandle<AttributeData>>(value);
		}

		public NewPerkTooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
