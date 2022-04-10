
namespace WolvenKit.RED4.Types
{
	public partial class NightPreset : SmartHousePreset
	{
		public NightPreset()
		{
			Timetable = new() { Time = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
