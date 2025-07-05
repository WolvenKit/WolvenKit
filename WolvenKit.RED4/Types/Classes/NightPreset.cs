
namespace WolvenKit.RED4.Types
{
	public partial class NightPreset : SmartHousePreset
	{
		public NightPreset()
		{
			Timetable = new SPresetTimetableEntry { Time = new SSimpleGameTime() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
