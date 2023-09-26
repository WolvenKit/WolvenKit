using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SadismEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("healingItemChargeRestorePercentage")] 
		public CFloat HealingItemChargeRestorePercentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SadismEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
