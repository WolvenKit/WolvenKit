using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questQuestsSystemReplicatedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)] 
		[RED("replicatedQuestPrefabs")] 
		public CArray<questQuestPrefabsEntry> ReplicatedQuestPrefabs
		{
			get => GetPropertyValue<CArray<questQuestPrefabsEntry>>();
			set => SetPropertyValue<CArray<questQuestPrefabsEntry>>(value);
		}

		public questQuestsSystemReplicatedState()
		{
			ReplicatedQuestPrefabs = new();
		}
	}
}
