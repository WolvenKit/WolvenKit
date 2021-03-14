using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmartHousePreset : IScriptable
	{
		private SPresetTimetableEntry _timetable;

		[Ordinal(0)] 
		[RED("timetable")] 
		public SPresetTimetableEntry Timetable
		{
			get
			{
				if (_timetable == null)
				{
					_timetable = (SPresetTimetableEntry) CR2WTypeManager.Create("SPresetTimetableEntry", "timetable", cr2w, this);
				}
				return _timetable;
			}
			set
			{
				if (_timetable == value)
				{
					return;
				}
				_timetable = value;
				PropertySet(this);
			}
		}

		public SmartHousePreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
