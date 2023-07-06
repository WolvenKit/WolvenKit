
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameinteractionsPublisherBaseEvent : RedBaseClass
	{
		public gameinteractionsPublisherBaseEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
