
namespace WolvenKit.RED4.Types
{
	public partial class DelayedHUDInitializeEvent : redEvent
	{
		public DelayedHUDInitializeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
