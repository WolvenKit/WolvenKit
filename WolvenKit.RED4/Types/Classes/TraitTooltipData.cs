using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TraitTooltipData : BasePerksMenuTooltipData
	{
		[Ordinal(1)] 
		[RED("traitType")] 
		public CEnum<gamedataTraitType> TraitType
		{
			get => GetPropertyValue<CEnum<gamedataTraitType>>();
			set => SetPropertyValue<CEnum<gamedataTraitType>>(value);
		}

		[Ordinal(2)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("proficiency")] 
		public CEnum<gamedataProficiencyType> Proficiency
		{
			get => GetPropertyValue<CEnum<gamedataProficiencyType>>();
			set => SetPropertyValue<CEnum<gamedataProficiencyType>>(value);
		}

		[Ordinal(4)] 
		[RED("traitData")] 
		public CHandle<TraitDisplayData> TraitData
		{
			get => GetPropertyValue<CHandle<TraitDisplayData>>();
			set => SetPropertyValue<CHandle<TraitDisplayData>>(value);
		}

		[Ordinal(5)] 
		[RED("attributeData")] 
		public CHandle<AttributeData> AttributeData
		{
			get => GetPropertyValue<CHandle<AttributeData>>();
			set => SetPropertyValue<CHandle<AttributeData>>(value);
		}

		public TraitTooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
