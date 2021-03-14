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
			get
			{
				if (_entryData == null)
				{
					_entryData = (CArray<gameJournalSharedStateData>) CR2WTypeManager.Create("array:gameJournalSharedStateData", "entryData", cr2w, this);
				}
				return _entryData;
			}
			set
			{
				if (_entryData == value)
				{
					return;
				}
				_entryData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("trackedQuestPath")] 
		public CUInt32 TrackedQuestPath
		{
			get
			{
				if (_trackedQuestPath == null)
				{
					_trackedQuestPath = (CUInt32) CR2WTypeManager.Create("Uint32", "trackedQuestPath", cr2w, this);
				}
				return _trackedQuestPath;
			}
			set
			{
				if (_trackedQuestPath == value)
				{
					return;
				}
				_trackedQuestPath = value;
				PropertySet(this);
			}
		}

		public gameJournalManagerSharedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
