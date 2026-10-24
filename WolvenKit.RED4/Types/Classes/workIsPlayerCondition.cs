
namespace WolvenKit.RED4.Types
{
	public partial class workIsPlayerCondition : workIWorkspotCondition
	{
		public workIsPlayerCondition()
		{
			Equals = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
