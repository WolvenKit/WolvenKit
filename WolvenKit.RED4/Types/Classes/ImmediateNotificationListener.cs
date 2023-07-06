
namespace WolvenKit.RED4.Types
{
	public abstract partial class ImmediateNotificationListener : IScriptable
	{
		public ImmediateNotificationListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
