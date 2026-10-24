
namespace WolvenKit.RED4.Types
{
	public partial class MorningPreset : SmartHousePreset
	{
		public MorningPreset()
		{
			Timetable = new SPresetTimetableEntry();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
