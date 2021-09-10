
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestIllegalActionNotification : QuestSecuritySystemInput
	{

		public QuestIllegalActionNotification()
		{
			NotifySpecificNPCs = new();
			RevealPlayerSettings = new();
		}
	}
}
