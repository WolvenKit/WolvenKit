using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsMappinSystemReplicatedState : gameIGameSystemReplicatedState
	{
		private CArray<gameNewMappinID> _mappinState;
		private CArray<CUInt32> _mappinWithJournalState;

		[Ordinal(0)] 
		[RED("mappinState")] 
		public CArray<gameNewMappinID> MappinState
		{
			get
			{
				if (_mappinState == null)
				{
					_mappinState = (CArray<gameNewMappinID>) CR2WTypeManager.Create("array:gameNewMappinID", "mappinState", cr2w, this);
				}
				return _mappinState;
			}
			set
			{
				if (_mappinState == value)
				{
					return;
				}
				_mappinState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mappinWithJournalState")] 
		public CArray<CUInt32> MappinWithJournalState
		{
			get
			{
				if (_mappinWithJournalState == null)
				{
					_mappinWithJournalState = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "mappinWithJournalState", cr2w, this);
				}
				return _mappinWithJournalState;
			}
			set
			{
				if (_mappinWithJournalState == value)
				{
					return;
				}
				_mappinWithJournalState = value;
				PropertySet(this);
			}
		}

		public gamemappinsMappinSystemReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
