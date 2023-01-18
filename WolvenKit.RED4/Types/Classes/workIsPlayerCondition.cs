
namespace WolvenKit.RED4.Types
{
	public partial class workIsPlayerCondition : workIWorkspotCondition
	{
		public workIsPlayerCondition()
		{
			Equals_ = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
