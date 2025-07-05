
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameSmartObjectInstance : RedBaseClass
	{
		public gameSmartObjectInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
