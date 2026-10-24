
namespace WolvenKit.RED4.Types
{
	public partial class EveningPreset : SmartHousePreset
	{
		public EveningPreset()
		{
			Timetable = new SPresetTimetableEntry();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
