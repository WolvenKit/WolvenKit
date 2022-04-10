
namespace WolvenKit.RED4.Types
{
	public partial class NotifyParentsEvent : redEvent
	{
		public NotifyParentsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
