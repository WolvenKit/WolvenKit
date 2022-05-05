using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatModifierData_Deprecated : IScriptable
	{
		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("modifierType")] 
		public CEnum<gameStatModifierType> ModifierType
		{
			get => GetPropertyValue<CEnum<gameStatModifierType>>();
			set => SetPropertyValue<CEnum<gameStatModifierType>>(value);
		}

		public gameStatModifierData_Deprecated()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
