
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTracking_Record
	{
		[RED("angleInterpolationDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleInterpolationDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bendFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat BendFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bendTimeRatio")]
		[REDProperty(IsIgnored = true)]
		public CFloat BendTimeRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("endLeanAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat EndLeanAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("halfLeanAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat HalfLeanAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("interpolationTimeRatio")]
		[REDProperty(IsIgnored = true)]
		public CFloat InterpolationTimeRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("linearTimeRatio")]
		[REDProperty(IsIgnored = true)]
		public CFloat LinearTimeRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("returnTimeMargin")]
		[REDProperty(IsIgnored = true)]
		public CFloat ReturnTimeMargin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
