using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SmartHousePreset : IScriptable
	{
		[Ordinal(0)] 
		[RED("timetable")] 
		public SPresetTimetableEntry Timetable
		{
			get => GetPropertyValue<SPresetTimetableEntry>();
			set => SetPropertyValue<SPresetTimetableEntry>(value);
		}

		public SmartHousePreset()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
