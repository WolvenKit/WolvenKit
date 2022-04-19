
namespace WolvenKit.RED4.Types
{
	public partial class InitializeCLSEvent : redEvent
	{
		public InitializeCLSEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
