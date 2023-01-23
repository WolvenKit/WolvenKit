
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
	}
}
