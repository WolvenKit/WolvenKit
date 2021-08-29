using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SmartHousePreset : IScriptable
	{
		private SPresetTimetableEntry _timetable;

		[Ordinal(0)] 
		[RED("timetable")] 
		public SPresetTimetableEntry Timetable
		{
			get => GetProperty(ref _timetable);
			set => SetProperty(ref _timetable, value);
		}
	}
}
