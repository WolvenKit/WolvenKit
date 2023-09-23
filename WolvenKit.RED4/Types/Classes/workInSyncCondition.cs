
namespace WolvenKit.RED4.Types
{
	public partial class workInSyncCondition : workIWorkspotCondition
	{
		public workInSyncCondition()
		{
			Equals_ = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
