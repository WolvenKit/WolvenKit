
namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_SimpleDuration : animAnimEvent
	{
		public animAnimEvent_SimpleDuration()
		{
			DurationInFrames = 15;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
