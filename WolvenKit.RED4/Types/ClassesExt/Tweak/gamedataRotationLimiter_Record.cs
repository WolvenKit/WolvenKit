
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRotationLimiter_Record
	{
		[RED("driftExceededAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat DriftExceededAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("driftFullAngleBegin")]
		[REDProperty(IsIgnored = true)]
		public CFloat DriftFullAngleBegin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("driftFullAngleEnd")]
		[REDProperty(IsIgnored = true)]
		public CFloat DriftFullAngleEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("driftLimit")]
		[REDProperty(IsIgnored = true)]
		public CFloat DriftLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("driftLimitMaxVel")]
		[REDProperty(IsIgnored = true)]
		public CFloat DriftLimitMaxVel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("driftLimitStartVel")]
		[REDProperty(IsIgnored = true)]
		public CFloat DriftLimitStartVel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("handbrakeLimit")]
		[REDProperty(IsIgnored = true)]
		public CFloat HandbrakeLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxAngularSpeedRad")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxAngularSpeedRad
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("smoothingTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat SmoothingTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
