using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceTimetable : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("timeTableSetup")] 
		public CHandle<DeviceTimeTableManager> TimeTableSetup
		{
			get => GetPropertyValue<CHandle<DeviceTimeTableManager>>();
			set => SetPropertyValue<CHandle<DeviceTimeTableManager>>(value);
		}
	}
}
