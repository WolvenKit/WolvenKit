
namespace WolvenKit.RED4.Types
{
	public partial class senseInitializeEvent : redEvent
	{
		public senseInitializeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
