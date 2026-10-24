
namespace WolvenKit.RED4.Types
{
	public partial class workInSyncCondition : workIWorkspotCondition
	{
		public workInSyncCondition()
		{
			Equals = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
