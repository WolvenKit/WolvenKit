using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SwimmingSurfaceEvents : LocomotionSwimmingEvents
	{
		[Ordinal(6)] 
		[RED("lapsedTime")] 
		public CFloat LapsedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("timeSinceLastImpulse")] 
		public CFloat TimeSinceLastImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("minSpeedForMovementImpulses")] 
		public CFloat MinSpeedForMovementImpulses
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("timeBetweenIdleImpulses")] 
		public CFloat TimeBetweenIdleImpulses
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("timeBetweenMovementImpulses")] 
		public CFloat TimeBetweenMovementImpulses
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("idleImpulseRadius")] 
		public CFloat IdleImpulseRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("idleImpulseStrength")] 
		public CFloat IdleImpulseStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("movementImpulseRadius")] 
		public CFloat MovementImpulseRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("movementImpulseStrength")] 
		public CFloat MovementImpulseStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("movementImpulseOffset")] 
		public CFloat MovementImpulseOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SwimmingSurfaceEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
