
namespace WolvenKit.RED4.Types
{
	public partial class workIsSyncMasterCondition : workIWorkspotCondition
	{
		public workIsSyncMasterCondition()
		{
			Equals = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
