
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleGear_Record
	{
		[RED("maxEngineRPM")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxEngineRPM
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minEngineRPM")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinEngineRPM
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("torqueMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat TorqueMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
