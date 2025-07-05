using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSubStatModifierData_Deprecated : gameStatModifierData_Deprecated
	{
		[Ordinal(2)] 
		[RED("refStatType")] 
		public CEnum<gamedataStatType> RefStatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		public gameSubStatModifierData_Deprecated()
		{
			StatType = Enums.gamedataStatType.Invalid;
			ModifierType = Enums.gameStatModifierType.Invalid;
			RefStatType = Enums.gamedataStatType.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
