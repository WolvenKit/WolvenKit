using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerHackingMinigameEffector : gameEffector
	{
		private wCHandle<gameObject> _owner;
		private CUInt32 _listener;
		private gameItemID _item;
		private TweakDBID _reward;
		private CString _journalEntry;
		private CName _fact;
		private CInt32 _factValue;
		private CBool _showPopup;
		private CBool _returnToJournal;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("listener")] 
		public CUInt32 Listener
		{
			get
			{
				if (_listener == null)
				{
					_listener = (CUInt32) CR2WTypeManager.Create("Uint32", "listener", cr2w, this);
				}
				return _listener;
			}
			set
			{
				if (_listener == value)
				{
					return;
				}
				_listener = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("item")] 
		public gameItemID Item
		{
			get
			{
				if (_item == null)
				{
					_item = (gameItemID) CR2WTypeManager.Create("gameItemID", "item", cr2w, this);
				}
				return _item;
			}
			set
			{
				if (_item == value)
				{
					return;
				}
				_item = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("reward")] 
		public TweakDBID Reward
		{
			get
			{
				if (_reward == null)
				{
					_reward = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "reward", cr2w, this);
				}
				return _reward;
			}
			set
			{
				if (_reward == value)
				{
					return;
				}
				_reward = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("journalEntry")] 
		public CString JournalEntry
		{
			get
			{
				if (_journalEntry == null)
				{
					_journalEntry = (CString) CR2WTypeManager.Create("String", "journalEntry", cr2w, this);
				}
				return _journalEntry;
			}
			set
			{
				if (_journalEntry == value)
				{
					return;
				}
				_journalEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("fact")] 
		public CName Fact
		{
			get
			{
				if (_fact == null)
				{
					_fact = (CName) CR2WTypeManager.Create("CName", "fact", cr2w, this);
				}
				return _fact;
			}
			set
			{
				if (_fact == value)
				{
					return;
				}
				_fact = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("factValue")] 
		public CInt32 FactValue
		{
			get
			{
				if (_factValue == null)
				{
					_factValue = (CInt32) CR2WTypeManager.Create("Int32", "factValue", cr2w, this);
				}
				return _factValue;
			}
			set
			{
				if (_factValue == value)
				{
					return;
				}
				_factValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("showPopup")] 
		public CBool ShowPopup
		{
			get
			{
				if (_showPopup == null)
				{
					_showPopup = (CBool) CR2WTypeManager.Create("Bool", "showPopup", cr2w, this);
				}
				return _showPopup;
			}
			set
			{
				if (_showPopup == value)
				{
					return;
				}
				_showPopup = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("returnToJournal")] 
		public CBool ReturnToJournal
		{
			get
			{
				if (_returnToJournal == null)
				{
					_returnToJournal = (CBool) CR2WTypeManager.Create("Bool", "returnToJournal", cr2w, this);
				}
				return _returnToJournal;
			}
			set
			{
				if (_returnToJournal == value)
				{
					return;
				}
				_returnToJournal = value;
				PropertySet(this);
			}
		}

		public TriggerHackingMinigameEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
