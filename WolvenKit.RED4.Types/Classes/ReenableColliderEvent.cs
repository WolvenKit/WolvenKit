
namespace WolvenKit.RED4.Types
{
	public partial class ReenableColliderEvent : redEvent
	{
		public ReenableColliderEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
