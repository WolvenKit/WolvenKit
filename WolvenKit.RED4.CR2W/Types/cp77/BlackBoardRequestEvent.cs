using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BlackBoardRequestEvent : redEvent
	{
		private CHandle<gameIBlackboard> _blackBoard;
		private CEnum<gameScriptedBlackboardStorage> _storageClass;
		private CName _entryTag;

		[Ordinal(0)] 
		[RED("blackBoard")] 
		public CHandle<gameIBlackboard> BlackBoard
		{
			get
			{
				if (_blackBoard == null)
				{
					_blackBoard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "blackBoard", cr2w, this);
				}
				return _blackBoard;
			}
			set
			{
				if (_blackBoard == value)
				{
					return;
				}
				_blackBoard = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("storageClass")] 
		public CEnum<gameScriptedBlackboardStorage> StorageClass
		{
			get
			{
				if (_storageClass == null)
				{
					_storageClass = (CEnum<gameScriptedBlackboardStorage>) CR2WTypeManager.Create("gameScriptedBlackboardStorage", "storageClass", cr2w, this);
				}
				return _storageClass;
			}
			set
			{
				if (_storageClass == value)
				{
					return;
				}
				_storageClass = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entryTag")] 
		public CName EntryTag
		{
			get
			{
				if (_entryTag == null)
				{
					_entryTag = (CName) CR2WTypeManager.Create("CName", "entryTag", cr2w, this);
				}
				return _entryTag;
			}
			set
			{
				if (_entryTag == value)
				{
					return;
				}
				_entryTag = value;
				PropertySet(this);
			}
		}

		public BlackBoardRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
