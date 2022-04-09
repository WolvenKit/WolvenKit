using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("modifiers")] 
		public CArray<gameStatModifierHandle> Modifiers
		{
			get => GetPropertyValue<CArray<gameStatModifierHandle>>();
			set => SetPropertyValue<CArray<gameStatModifierHandle>>(value);
		}

		[Ordinal(1)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		public gameStatData()
		{
			Modifiers = new();
			StatType = Enums.gamedataStatType.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
