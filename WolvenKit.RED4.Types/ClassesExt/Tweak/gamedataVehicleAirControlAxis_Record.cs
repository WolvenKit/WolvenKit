
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleAirControlAxis_Record
	{
		[RED("angleCorrectionFactorMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleCorrectionFactorMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("angleCorrectionFactorMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleCorrectionFactorMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("angleCorrectionThresholdMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleCorrectionThresholdMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("angleCorrectionThresholdMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleCorrectionThresholdMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("brakeMultiplierWhenNoInput")]
		[REDProperty(IsIgnored = true)]
		public CFloat BrakeMultiplierWhenNoInput
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("controlAxis")]
		[REDProperty(IsIgnored = true)]
		public CName ControlAxis
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("maxAngleCompensation")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxAngleCompensation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxAngleToCompensateThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxAngleToCompensateThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxVelocityCompensation")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxVelocityCompensation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("multiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat Multiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("stabilizeAxis")]
		[REDProperty(IsIgnored = true)]
		public CBool StabilizeAxis
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("velocityDampingFactorMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat VelocityDampingFactorMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("velocityDampingFactorMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat VelocityDampingFactorMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("velocityDampingThresholdMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat VelocityDampingThresholdMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("velocityDampingThresholdMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat VelocityDampingThresholdMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("zeroAngleThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat ZeroAngleThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
