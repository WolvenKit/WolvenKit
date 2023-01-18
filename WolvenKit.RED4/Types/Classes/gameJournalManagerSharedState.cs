using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalManagerSharedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)] 
		[RED("entryData")] 
		public CArray<gameJournalSharedStateData> EntryData
		{
			get => GetPropertyValue<CArray<gameJournalSharedStateData>>();
			set => SetPropertyValue<CArray<gameJournalSharedStateData>>(value);
		}

		[Ordinal(1)] 
		[RED("trackedQuestPath")] 
		public CUInt32 TrackedQuestPath
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameJournalManagerSharedState()
		{
			EntryData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
