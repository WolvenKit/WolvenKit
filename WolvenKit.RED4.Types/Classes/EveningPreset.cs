
namespace WolvenKit.RED4.Types
{
	public partial class EveningPreset : SmartHousePreset
	{
		public EveningPreset()
		{
			Timetable = new() { Time = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
