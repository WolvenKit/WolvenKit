
namespace WolvenKit.RED4.Types
{
	public partial class entPreUninitializeEvent : redEvent
	{
		public entPreUninitializeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
