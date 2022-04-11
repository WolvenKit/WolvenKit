
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestCombatActionNotification : QuestSecuritySystemInput
	{

		public QuestCombatActionNotification()
		{
			NotifySpecificNPCs = new();
			RevealPlayerSettings = new();
		}
	}
}
