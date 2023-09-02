
namespace WolvenKit.RED4.Types
{
	public partial class QuestIllegalActionNotification : QuestSecuritySystemInput
	{
		public QuestIllegalActionNotification()
		{
			NotifySpecificNPCs = new();
			RevealPlayerSettings = new RevealPlayerSettings();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
