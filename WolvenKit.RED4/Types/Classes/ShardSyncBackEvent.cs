
namespace WolvenKit.RED4.Types
{
	public partial class ShardSyncBackEvent : redEvent
	{
		public ShardSyncBackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
