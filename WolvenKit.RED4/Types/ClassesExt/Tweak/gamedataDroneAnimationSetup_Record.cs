
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDroneAnimationSetup_Record
	{
		[RED("mass")]
		[REDProperty(IsIgnored = true)]
		public CFloat Mass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("massNormalizedCoefficient")]
		[REDProperty(IsIgnored = true)]
		public CFloat MassNormalizedCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("pseudoAcceleration")]
		[REDProperty(IsIgnored = true)]
		public CFloat PseudoAcceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sizeBack")]
		[REDProperty(IsIgnored = true)]
		public CFloat SizeBack
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sizeFront")]
		[REDProperty(IsIgnored = true)]
		public CFloat SizeFront
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sizeLeft")]
		[REDProperty(IsIgnored = true)]
		public CFloat SizeLeft
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sizeRight")]
		[REDProperty(IsIgnored = true)]
		public CFloat SizeRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("speedIdleThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpeedIdleThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("startingRecoveryBalance")]
		[REDProperty(IsIgnored = true)]
		public CFloat StartingRecoveryBalance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tiltAngleOnSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat TiltAngleOnSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("turnInertiaDamping")]
		[REDProperty(IsIgnored = true)]
		public CFloat TurnInertiaDamping
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("walkTiltCoefficient")]
		[REDProperty(IsIgnored = true)]
		public CFloat WalkTiltCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
