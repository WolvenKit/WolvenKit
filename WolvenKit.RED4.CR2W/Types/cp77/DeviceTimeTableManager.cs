using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceTimeTableManager : IScriptable
	{
		private CArray<SDeviceTimetableEntry> _timeTable;

		[Ordinal(0)] 
		[RED("timeTable")] 
		public CArray<SDeviceTimetableEntry> TimeTable
		{
			get
			{
				if (_timeTable == null)
				{
					_timeTable = (CArray<SDeviceTimetableEntry>) CR2WTypeManager.Create("array:SDeviceTimetableEntry", "timeTable", cr2w, this);
				}
				return _timeTable;
			}
			set
			{
				if (_timeTable == value)
				{
					return;
				}
				_timeTable = value;
				PropertySet(this);
			}
		}

		public DeviceTimeTableManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
