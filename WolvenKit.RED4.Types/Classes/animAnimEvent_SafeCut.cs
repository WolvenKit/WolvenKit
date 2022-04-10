
namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_SafeCut : animAnimEvent
	{
		public animAnimEvent_SafeCut()
		{
			EventName = "safe_cut";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
