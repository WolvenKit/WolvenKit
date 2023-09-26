
namespace WolvenKit.RED4.Types
{
	public partial class workIsSyncMasterCondition : workIWorkspotCondition
	{
		public workIsSyncMasterCondition()
		{
			Equals_ = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
