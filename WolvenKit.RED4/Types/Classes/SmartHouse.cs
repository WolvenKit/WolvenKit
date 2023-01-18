using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SmartHouse : InteractiveMasterDevice
	{
		[Ordinal(94)] 
		[RED("timetableActive")] 
		public CBool TimetableActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SmartHouse()
		{
			ControllerTypeName = "SmartHouseController";
			TimetableActive = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
