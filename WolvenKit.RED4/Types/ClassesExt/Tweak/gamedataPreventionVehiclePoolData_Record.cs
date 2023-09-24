
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPreventionVehiclePoolData_Record
	{
		[RED("vehicleRecord")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehicleRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("weight")]
		[REDProperty(IsIgnored = true)]
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
