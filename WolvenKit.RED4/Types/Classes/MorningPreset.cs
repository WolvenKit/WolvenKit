
namespace WolvenKit.RED4.Types
{
	public partial class MorningPreset : SmartHousePreset
	{
		public MorningPreset()
		{
			Timetable = new SPresetTimetableEntry { Time = new SSimpleGameTime() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
