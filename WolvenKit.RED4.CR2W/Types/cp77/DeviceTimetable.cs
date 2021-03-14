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
			get
			{
				if (_timeTableSetup == null)
				{
					_timeTableSetup = (CHandle<DeviceTimeTableManager>) CR2WTypeManager.Create("handle:DeviceTimeTableManager", "timeTableSetup", cr2w, this);
				}
				return _timeTableSetup;
			}
			set
			{
				if (_timeTableSetup == value)
				{
					return;
				}
				_timeTableSetup = value;
				PropertySet(this);
			}
		}

		public DeviceTimetable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
