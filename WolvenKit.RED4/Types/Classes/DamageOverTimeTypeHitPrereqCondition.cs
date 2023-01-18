using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DamageOverTimeTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("dotType")] 
		public CEnum<gamedataStatusEffectType> DotType
		{
			get => GetPropertyValue<CEnum<gamedataStatusEffectType>>();
			set => SetPropertyValue<CEnum<gamedataStatusEffectType>>(value);
		}

		public DamageOverTimeTypeHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
