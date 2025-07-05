
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDynamicVehicleData_Record
	{
		[RED("unitRecordsPool")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> UnitRecordsPool
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("vehicleRecord")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehicleRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
