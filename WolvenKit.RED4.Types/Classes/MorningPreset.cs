
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MorningPreset : SmartHousePreset
	{

		public MorningPreset()
		{
			Timetable = new() { Time = new() };
		}
	}
}
