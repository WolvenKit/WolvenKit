
namespace WolvenKit.RED4.Types
{
	public partial class workIsSyncSlaveCondition : workIWorkspotCondition
	{
		public workIsSyncSlaveCondition()
		{
			Equals = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
