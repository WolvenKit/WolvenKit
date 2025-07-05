
namespace WolvenKit.RED4.Types
{
	public partial class OnAttachedEvent : redEvent
	{
		public OnAttachedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
