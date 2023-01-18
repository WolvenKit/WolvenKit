
namespace WolvenKit.RED4.Types
{
	public partial class QuestCombatActionNotification : QuestSecuritySystemInput
	{
		public QuestCombatActionNotification()
		{
			NotifySpecificNPCs = new();
			RevealPlayerSettings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
