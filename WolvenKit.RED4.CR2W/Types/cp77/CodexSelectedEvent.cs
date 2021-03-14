using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexSelectedEvent : redEvent
	{
		private CBool _group;
		private CInt32 _entryHash;
		private CInt32 _level;
		private wCHandle<CodexEntryData> _data;
		private wCHandle<CodexListSyncData> _activeDataSync;

		[Ordinal(0)] 
		[RED("group")] 
		public CBool Group
		{
			get
			{
				if (_group == null)
				{
					_group = (CBool) CR2WTypeManager.Create("Bool", "group", cr2w, this);
				}
				return _group;
			}
			set
			{
				if (_group == value)
				{
					return;
				}
				_group = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entryHash")] 
		public CInt32 EntryHash
		{
			get
			{
				if (_entryHash == null)
				{
					_entryHash = (CInt32) CR2WTypeManager.Create("Int32", "entryHash", cr2w, this);
				}
				return _entryHash;
			}
			set
			{
				if (_entryHash == value)
				{
					return;
				}
				_entryHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("level")] 
		public CInt32 Level
		{
			get
			{
				if (_level == null)
				{
					_level = (CInt32) CR2WTypeManager.Create("Int32", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("data")] 
		public wCHandle<CodexEntryData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (wCHandle<CodexEntryData>) CR2WTypeManager.Create("whandle:CodexEntryData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("activeDataSync")] 
		public wCHandle<CodexListSyncData> ActiveDataSync
		{
			get
			{
				if (_activeDataSync == null)
				{
					_activeDataSync = (wCHandle<CodexListSyncData>) CR2WTypeManager.Create("whandle:CodexListSyncData", "activeDataSync", cr2w, this);
				}
				return _activeDataSync;
			}
			set
			{
				if (_activeDataSync == value)
				{
					return;
				}
				_activeDataSync = value;
				PropertySet(this);
			}
		}

		public CodexSelectedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
