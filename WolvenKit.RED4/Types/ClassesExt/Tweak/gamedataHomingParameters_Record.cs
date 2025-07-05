
namespace WolvenKit.RED4.Types
{
	public partial class gamedataHomingParameters_Record
	{
		[RED("accuracy")]
		[REDProperty(IsIgnored = true)]
		public CFloat Accuracy
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("angleInHitPlane")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleInHitPlane
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("angleInterpolationDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleInterpolationDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("angleInVerticalPlane")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleInVerticalPlane
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
		
		[RED("shouldRotate")]
		[REDProperty(IsIgnored = true)]
		public CBool ShouldRotate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("snapRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat SnapRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("startVelocity")]
		[REDProperty(IsIgnored = true)]
		public CFloat StartVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
