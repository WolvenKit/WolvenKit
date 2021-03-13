using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceTimeTableManager : IScriptable
	{
		[Ordinal(0)] [RED("timeTable")] public CArray<SDeviceTimetableEntry> TimeTable { get; set; }

		public DeviceTimeTableManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
