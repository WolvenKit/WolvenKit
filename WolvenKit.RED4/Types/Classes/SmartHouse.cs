using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SmartHouse : InteractiveMasterDevice
	{
		[Ordinal(98)] 
		[RED("timetableActive")] 
		public CBool TimetableActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SmartHouse()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
