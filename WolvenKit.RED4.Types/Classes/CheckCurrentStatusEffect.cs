using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckCurrentStatusEffect : AIStatusEffectCondition
	{
		[Ordinal(0)] 
		[RED("statusEffectTypeToCompare")] 
		public CEnum<gamedataStatusEffectType> StatusEffectTypeToCompare
		{
			get => GetPropertyValue<CEnum<gamedataStatusEffectType>>();
			set => SetPropertyValue<CEnum<gamedataStatusEffectType>>(value);
		}

		[Ordinal(1)] 
		[RED("statusEffectTagToCompare")] 
		public CName StatusEffectTagToCompare
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CheckCurrentStatusEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
