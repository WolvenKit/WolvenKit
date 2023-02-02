
namespace WolvenKit.RED4.Types
{
	public partial class entPostInitializeEvent : redEvent
	{
		public entPostInitializeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
