using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questQuestsSystemReplicatedState : gameIGameSystemReplicatedState
	{
		private CArray<questQuestPrefabsEntry> _replicatedQuestPrefabs;

		[Ordinal(0)] 
		[RED("replicatedQuestPrefabs")] 
		public CArray<questQuestPrefabsEntry> ReplicatedQuestPrefabs
		{
			get => GetProperty(ref _replicatedQuestPrefabs);
			set => SetProperty(ref _replicatedQuestPrefabs, value);
		}
	}
}
