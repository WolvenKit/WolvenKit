using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyStatusEffectBasedOnStatEffector : ApplyStatusEffectEffector
	{
		[Ordinal(8)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		public ApplyStatusEffectBasedOnStatEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
