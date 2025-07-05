
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleSeatSet_Record
	{
		[RED("vehSeats")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> VehSeats
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
