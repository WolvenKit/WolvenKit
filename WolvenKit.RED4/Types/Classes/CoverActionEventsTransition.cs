
namespace WolvenKit.RED4.Types
{
	public abstract partial class CoverActionEventsTransition : CoverActionTransition
	{
		public CoverActionEventsTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
