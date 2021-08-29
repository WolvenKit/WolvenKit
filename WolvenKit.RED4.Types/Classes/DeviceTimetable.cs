using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceTimetable : gameScriptableComponent
	{
		private CHandle<DeviceTimeTableManager> _timeTableSetup;

		[Ordinal(5)] 
		[RED("timeTableSetup")] 
		public CHandle<DeviceTimeTableManager> TimeTableSetup
		{
			get => GetProperty(ref _timeTableSetup);
			set => SetProperty(ref _timeTableSetup, value);
		}
	}
}
