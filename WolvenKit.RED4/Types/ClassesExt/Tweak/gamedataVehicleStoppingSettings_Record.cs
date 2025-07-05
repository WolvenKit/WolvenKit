
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleStoppingSettings_Record
	{
		[RED("decreaseMul")]
		[REDProperty(IsIgnored = true)]
		public CFloat DecreaseMul
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("errorMagnitudeForFullBrakingChange")]
		[REDProperty(IsIgnored = true)]
		public CFloat ErrorMagnitudeForFullBrakingChange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("errorMagnitudeForMildBrakingChange")]
		[REDProperty(IsIgnored = true)]
		public CFloat ErrorMagnitudeForMildBrakingChange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("fullBrakingChangeSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat FullBrakingChangeSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("mildBrakingChangeSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MildBrakingChangeSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
