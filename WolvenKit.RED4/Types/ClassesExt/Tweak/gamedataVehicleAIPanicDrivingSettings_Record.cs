
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleAIPanicDrivingSettings_Record
	{
		[RED("basePanicSpeedIncrease")]
		[REDProperty(IsIgnored = true)]
		public CFloat BasePanicSpeedIncrease
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("boostMaxSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat BoostMaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("boostMinSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat BoostMinSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("curvatureLookupRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat CurvatureLookupRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("perLaneSpeedIncrease")]
		[REDProperty(IsIgnored = true)]
		public CFloat PerLaneSpeedIncrease
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("topSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat TopSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
