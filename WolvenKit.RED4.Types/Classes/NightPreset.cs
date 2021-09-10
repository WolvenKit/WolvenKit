
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NightPreset : SmartHousePreset
	{

		public NightPreset()
		{
			Timetable = new() { Time = new() };
		}
	}
}
