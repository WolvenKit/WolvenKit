using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmartHousePreset : IScriptable
	{
		[Ordinal(0)] [RED("timetable")] public SPresetTimetableEntry Timetable { get; set; }

		public SmartHousePreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
