
namespace WolvenKit.RED4.Types
{
	public partial class PSInstantiateEvent : redEvent
	{
		public PSInstantiateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
