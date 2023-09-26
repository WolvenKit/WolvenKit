using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CycleRoundEvents : WeaponEventsTransition
	{
		[Ordinal(5)] 
		[RED("hasBlockedAiming")] 
		public CBool HasBlockedAiming
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("blockAimStart")] 
		public CFloat BlockAimStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("blockAimDuration")] 
		public CFloat BlockAimDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CycleRoundEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
