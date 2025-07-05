
namespace WolvenKit.RED4.Types
{
	public partial class DebugRemoteConnectionEvent : redEvent
	{
		public DebugRemoteConnectionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
