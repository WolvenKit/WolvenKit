using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalManagerSharedState : gameIGameSystemReplicatedState
	{
		private CArray<gameJournalSharedStateData> _entryData;
		private CUInt32 _trackedQuestPath;

		[Ordinal(0)] 
		[RED("entryData")] 
		public CArray<gameJournalSharedStateData> EntryData
		{
			get => GetProperty(ref _entryData);
			set => SetProperty(ref _entryData, value);
		}

		[Ordinal(1)] 
		[RED("trackedQuestPath")] 
		public CUInt32 TrackedQuestPath
		{
			get => GetProperty(ref _trackedQuestPath);
			set => SetProperty(ref _trackedQuestPath, value);
		}
	}
}
