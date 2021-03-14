using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CpoHudRootGameController : gameuiWidgetGameController
	{
		private CHandle<inkWidget> _hitIndicator;
		private CHandle<inkWidget> _chatBox;
		private CHandle<inkWidget> _playerList;
		private CHandle<inkWidget> _narration_journal;
		private CHandle<inkWidget> _narrative_plate;
		private CHandle<inkWidget> _inventory;
		private CHandle<inkWidget> _loadouts;

		[Ordinal(2)] 
		[RED("hitIndicator")] 
		public CHandle<inkWidget> HitIndicator
		{
			get
			{
				if (_hitIndicator == null)
				{
					_hitIndicator = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "hitIndicator", cr2w, this);
				}
				return _hitIndicator;
			}
			set
			{
				if (_hitIndicator == value)
				{
					return;
				}
				_hitIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("chatBox")] 
		public CHandle<inkWidget> ChatBox
		{
			get
			{
				if (_chatBox == null)
				{
					_chatBox = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "chatBox", cr2w, this);
				}
				return _chatBox;
			}
			set
			{
				if (_chatBox == value)
				{
					return;
				}
				_chatBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playerList")] 
		public CHandle<inkWidget> PlayerList
		{
			get
			{
				if (_playerList == null)
				{
					_playerList = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "playerList", cr2w, this);
				}
				return _playerList;
			}
			set
			{
				if (_playerList == value)
				{
					return;
				}
				_playerList = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("narration_journal")] 
		public CHandle<inkWidget> Narration_journal
		{
			get
			{
				if (_narration_journal == null)
				{
					_narration_journal = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "narration_journal", cr2w, this);
				}
				return _narration_journal;
			}
			set
			{
				if (_narration_journal == value)
				{
					return;
				}
				_narration_journal = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("narrative_plate")] 
		public CHandle<inkWidget> Narrative_plate
		{
			get
			{
				if (_narrative_plate == null)
				{
					_narrative_plate = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "narrative_plate", cr2w, this);
				}
				return _narrative_plate;
			}
			set
			{
				if (_narrative_plate == value)
				{
					return;
				}
				_narrative_plate = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("inventory")] 
		public CHandle<inkWidget> Inventory
		{
			get
			{
				if (_inventory == null)
				{
					_inventory = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "inventory", cr2w, this);
				}
				return _inventory;
			}
			set
			{
				if (_inventory == value)
				{
					return;
				}
				_inventory = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("loadouts")] 
		public CHandle<inkWidget> Loadouts
		{
			get
			{
				if (_loadouts == null)
				{
					_loadouts = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "loadouts", cr2w, this);
				}
				return _loadouts;
			}
			set
			{
				if (_loadouts == value)
				{
					return;
				}
				_loadouts = value;
				PropertySet(this);
			}
		}

		public CpoHudRootGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
