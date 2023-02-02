using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSItemStackRequirementData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("requiredValue")] 
		public CFloat RequiredValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameSItemStackRequirementData()
		{
			StatType = Enums.gamedataStatType.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
