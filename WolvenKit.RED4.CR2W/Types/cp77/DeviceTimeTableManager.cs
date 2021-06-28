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
			get => GetProperty(ref _timeTable);
			set => SetProperty(ref _timeTable, value);
		}

		public DeviceTimeTableManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
