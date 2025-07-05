
namespace WolvenKit.RED4.Types
{
	public abstract partial class FailedLandingAbstractDecisions : AbstractLandDecisions
	{
		public FailedLandingAbstractDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
