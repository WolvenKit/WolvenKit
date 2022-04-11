
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BackDoorObjectiveData : GemplayObjectiveData
	{

		public BackDoorObjectiveData()
		{
			QuestUniqueId = "NETWORK";
			QuestTitle = "NETWORK";
			ObjectiveDescription = "Hack backdoor in order to get access to the network";
			UniqueIdPrefix = "backdoor";
		}
	}
}
