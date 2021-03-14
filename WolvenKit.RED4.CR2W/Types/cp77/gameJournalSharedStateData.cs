using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalSharedStateData : CVariable
	{
		private CUInt32 _pathHash;
		private CEnum<gameJournalEntryState> _entryState;

		[Ordinal(0)] 
		[RED("pathHash")] 
		public CUInt32 PathHash
		{
			get
			{
				if (_pathHash == null)
				{
					_pathHash = (CUInt32) CR2WTypeManager.Create("Uint32", "pathHash", cr2w, this);
				}
				return _pathHash;
			}
			set
			{
				if (_pathHash == value)
				{
					return;
				}
				_pathHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entryState")] 
		public CEnum<gameJournalEntryState> EntryState
		{
			get
			{
				if (_entryState == null)
				{
					_entryState = (CEnum<gameJournalEntryState>) CR2WTypeManager.Create("gameJournalEntryState", "entryState", cr2w, this);
				}
				return _entryState;
			}
			set
			{
				if (_entryState == value)
				{
					return;
				}
				_entryState = value;
				PropertySet(this);
			}
		}

		public gameJournalSharedStateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
