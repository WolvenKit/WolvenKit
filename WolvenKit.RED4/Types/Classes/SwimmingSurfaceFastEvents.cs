using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SwimmingSurfaceFastEvents : LocomotionSwimmingEvents
	{
		[Ordinal(6)] 
		[RED("lapsedTime")] 
		public CFloat LapsedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("timeSinceLastImpulse")] 
		public CFloat TimeSinceLastImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("timeBetweenMovementImpulses")] 
		public CFloat TimeBetweenMovementImpulses
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("movementImpulseRadius")] 
		public CFloat MovementImpulseRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("movementImpulseStrength")] 
		public CFloat MovementImpulseStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("movementImpulseOffset")] 
		public CFloat MovementImpulseOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SwimmingSurfaceFastEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
