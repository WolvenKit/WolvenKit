using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalManagerSharedState : gameIGameSystemReplicatedState
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

		public gameJournalManagerSharedState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
