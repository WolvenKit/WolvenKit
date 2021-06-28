using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceTimetable : gameScriptableComponent
	{
		private CHandle<DeviceTimeTableManager> _timeTableSetup;

		[Ordinal(5)] 
		[RED("timeTableSetup")] 
		public CHandle<DeviceTimeTableManager> TimeTableSetup
		{
			get => GetProperty(ref _timeTableSetup);
			set => SetProperty(ref _timeTableSetup, value);
		}

		public DeviceTimetable(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
