
namespace WolvenKit.RED4.Types
{
	public abstract partial class FailedLandingAbstractEvents : AbstractLandEvents
	{
		public FailedLandingAbstractEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
