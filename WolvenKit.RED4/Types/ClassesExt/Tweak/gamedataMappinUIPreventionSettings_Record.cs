
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMappinUIPreventionSettings_Record
	{
		[RED("preventionDetectionThresholdForVisionCone")]
		[REDProperty(IsIgnored = true)]
		public CFloat PreventionDetectionThresholdForVisionCone
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("preventionMappinMaxDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat PreventionMappinMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("preventionVehicleMappinMaxDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat PreventionVehicleMappinMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
