
namespace WolvenKit.RED4.Types
{
	public partial class MorningPreset : SmartHousePreset
	{
		public MorningPreset()
		{
			Timetable = new() { Time = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
