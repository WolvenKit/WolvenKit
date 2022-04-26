
namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_Phase : animAnimEvent
	{
		public animAnimEvent_Phase()
		{
			DurationInFrames = 15;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
