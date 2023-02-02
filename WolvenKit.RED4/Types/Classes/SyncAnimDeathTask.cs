
namespace WolvenKit.RED4.Types
{
	public partial class SyncAnimDeathTask : WithoutHitDataDeathTask
	{
		public SyncAnimDeathTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
