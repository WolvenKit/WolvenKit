
namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_KeyPose : animAnimEvent
	{
		public animAnimEvent_KeyPose()
		{
			EventName = "key_pose";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
