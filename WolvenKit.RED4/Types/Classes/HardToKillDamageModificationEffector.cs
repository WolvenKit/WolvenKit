using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HardToKillDamageModificationEffector : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("criticalHealthThreshold")] 
		public CFloat CriticalHealthThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public HardToKillDamageModificationEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
