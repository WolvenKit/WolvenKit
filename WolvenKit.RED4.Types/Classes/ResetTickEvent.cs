
namespace WolvenKit.RED4.Types
{
	public partial class ResetTickEvent : gameTickableEvent
	{
		public ResetTickEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
