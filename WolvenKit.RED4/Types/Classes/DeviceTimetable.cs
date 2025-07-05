using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceTimetable : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("timeTableSetup")] 
		public CHandle<DeviceTimeTableManager> TimeTableSetup
		{
			get => GetPropertyValue<CHandle<DeviceTimeTableManager>>();
			set => SetPropertyValue<CHandle<DeviceTimeTableManager>>(value);
		}

		public DeviceTimetable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
