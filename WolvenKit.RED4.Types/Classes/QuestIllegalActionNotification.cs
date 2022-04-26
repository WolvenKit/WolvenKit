
namespace WolvenKit.RED4.Types
{
	public partial class QuestIllegalActionNotification : QuestSecuritySystemInput
	{
		public QuestIllegalActionNotification()
		{
			NotifySpecificNPCs = new();
			RevealPlayerSettings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
