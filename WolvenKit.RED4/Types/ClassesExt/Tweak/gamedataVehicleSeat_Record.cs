
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleSeat_Record
	{
		[RED("seatName")]
		[REDProperty(IsIgnored = true)]
		public CName SeatName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("springReboundDampingLowRate")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> SpringReboundDampingLowRate
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
