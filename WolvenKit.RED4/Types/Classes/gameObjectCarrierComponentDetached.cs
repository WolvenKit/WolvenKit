
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameObjectCarrierComponentDetached : redEvent
	{
		public gameObjectCarrierComponentDetached()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
