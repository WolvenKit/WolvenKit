
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBikeDriveModelData_Record
	{
		[RED("bikeCOMOffsetDampFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat BikeCOMOffsetDampFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bikeCurvesPath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> BikeCurvesPath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("bikeMaxCOMLongOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat BikeMaxCOMLongOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bikeMaxTilt")]
		[REDProperty(IsIgnored = true)]
		public CFloat BikeMaxTilt
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bikeMinCOMLongOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat BikeMinCOMLongOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bikeTiltCustomSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat BikeTiltCustomSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bikeTiltPID")]
		[REDProperty(IsIgnored = true)]
		public CArray<CFloat> BikeTiltPID
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}
		
		[RED("bikeTiltReturnSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat BikeTiltReturnSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bikeTiltSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat BikeTiltSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
