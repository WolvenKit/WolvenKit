
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMappinUICustomOpacityParams_Record
	{
		[RED("distanceWhenFullyHidden")]
		[REDProperty(IsIgnored = true)]
		public CFloat DistanceWhenFullyHidden
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("distanceWhenFullyVisible")]
		[REDProperty(IsIgnored = true)]
		public CFloat DistanceWhenFullyVisible
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("visibilityConeEndAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat VisibilityConeEndAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("visibilityConeMaximumOpacity")]
		[REDProperty(IsIgnored = true)]
		public CFloat VisibilityConeMaximumOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("visibilityConeStartAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat VisibilityConeStartAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
