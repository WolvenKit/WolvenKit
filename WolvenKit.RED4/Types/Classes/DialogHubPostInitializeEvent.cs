
namespace WolvenKit.RED4.Types
{
	public partial class DialogHubPostInitializeEvent : redEvent
	{
		public DialogHubPostInitializeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
