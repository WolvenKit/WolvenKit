
namespace WolvenKit.RED4.Types
{
	public partial class gamedataGrenadeDeliveryMethod_Record
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
