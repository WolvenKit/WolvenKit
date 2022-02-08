
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EveningPreset : SmartHousePreset
	{

		public EveningPreset()
		{
			Timetable = new() { Time = new() };
		}
	}
}
