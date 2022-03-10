
namespace WolvenKit.RED4.Types
{
	public partial class gamedataHomingGDM_Record
	{
		[RED("accelerationZ")]
		[REDProperty(IsIgnored = true)]
		public CFloat AccelerationZ
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bounciness")]
		[REDProperty(IsIgnored = true)]
		public CFloat Bounciness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("detonationTimer")]
		[REDProperty(IsIgnored = true)]
		public CFloat DetonationTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("flyToTargetParameters")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FlyToTargetParameters
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("flyUpParameters")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FlyUpParameters
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("freezeDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat FreezeDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("freezeDelayAfterBounce")]
		[REDProperty(IsIgnored = true)]
		public CFloat FreezeDelayAfterBounce
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("freezeDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat FreezeDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("initialQuickThrowVelocity")]
		[REDProperty(IsIgnored = true)]
		public CFloat InitialQuickThrowVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("initialVelocity")]
		[REDProperty(IsIgnored = true)]
		public CFloat InitialVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lockOnAltitude")]
		[REDProperty(IsIgnored = true)]
		public CFloat LockOnAltitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lockOnDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat LockOnDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lockOnFailDetonationDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat LockOnFailDetonationDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("trackingRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat TrackingRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("type")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Type
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
