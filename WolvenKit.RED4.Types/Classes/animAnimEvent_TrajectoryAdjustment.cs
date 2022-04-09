
namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_TrajectoryAdjustment : animAnimEvent
	{
		public animAnimEvent_TrajectoryAdjustment()
		{
			DurationInFrames = 15;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
