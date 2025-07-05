
namespace WolvenKit.RED4.Types
{
	public abstract partial class gsmIStateObserver : RedBaseClass
	{
		public gsmIStateObserver()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
