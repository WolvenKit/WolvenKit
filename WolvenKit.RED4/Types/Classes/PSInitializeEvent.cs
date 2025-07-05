
namespace WolvenKit.RED4.Types
{
	public partial class PSInitializeEvent : redEvent
	{
		public PSInitializeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
