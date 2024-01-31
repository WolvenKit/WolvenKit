using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameRagdollHitEvent : gameeventsHitEvent
	{
		[Ordinal(11)] 
		[RED("impactForce")] 
		public CFloat ImpactForce
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("speedDelta")] 
		public CFloat SpeedDelta
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
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
