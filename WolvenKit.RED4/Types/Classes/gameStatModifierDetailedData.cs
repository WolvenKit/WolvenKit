using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatModifierDetailedData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("modifierType")] 
		public CEnum<gameStatModifierType> ModifierType
		{
			get => GetPropertyValue<CEnum<gameStatModifierType>>();
			set => SetPropertyValue<CEnum<gameStatModifierType>>(value);
		}

		public gameStatModifierDetailedData()
		{
			StatType = Enums.gamedataStatType.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
