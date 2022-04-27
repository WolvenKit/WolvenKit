using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameRandomStatModifierData_Deprecated : gameStatModifierData_Deprecated
	{
		[Ordinal(2)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameRandomStatModifierData_Deprecated()
		{
			StatType = Enums.gamedataStatType.Invalid;
			ModifierType = Enums.gameStatModifierType.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
