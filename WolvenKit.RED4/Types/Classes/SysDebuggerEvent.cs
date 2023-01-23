
namespace WolvenKit.RED4.Types
{
	public partial class SysDebuggerEvent : gameTickableEvent
	{
		public SysDebuggerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
