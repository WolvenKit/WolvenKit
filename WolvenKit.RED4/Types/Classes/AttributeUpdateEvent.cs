
namespace WolvenKit.RED4.Types
{
	public partial class AttributeUpdateEvent : redEvent
	{
		public AttributeUpdateEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
