
namespace WolvenKit.RED4.Types
{
	public partial class DelayedRegisterToGlobalInputCallbackEvent : redEvent
	{
		public DelayedRegisterToGlobalInputCallbackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
