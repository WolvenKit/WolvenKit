using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameRagdollHitEvent : gameeventsHitEvent
	{
		[Ordinal(12)] 
		[RED("impactForce")] 
		public CFloat ImpactForce
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("speedDelta")] 
		public CFloat SpeedDelta
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("heightDelta")] 
		public CFloat HeightDelta
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameRagdollHitEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
