
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAimAssistFinishing_Record
	{
		[RED("inputHistoryTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat InputHistoryTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("isEnabled")]
		[REDProperty(IsIgnored = true)]
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("maxCorrectionAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxCorrectionAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxCorrectionPitch")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxCorrectionPitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxCorrectionYaw")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxCorrectionYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("velocityDecreaseActivationFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat VelocityDecreaseActivationFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
