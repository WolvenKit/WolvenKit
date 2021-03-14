using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestListGameController : gameuiHUDGameController
	{
		private inkVerticalPanelWidgetReference _entryList;
		private inkCompoundWidgetReference _scanPulse;
		private inkWidgetReference _optionalHeader;
		private inkWidgetReference _toDoHeader;
		private inkVerticalPanelWidgetReference _optionalList;
		private inkVerticalPanelWidgetReference _nonOptionalList;
		private CHandle<inkScriptDynArray> _entryControllers;
		private CHandle<inkanimProxy> _scanPulseAnimProxy;
		private CUInt32 _stateChangesBlackboardId;
		private CUInt32 _trackedChangesBlackboardId;
		private CHandle<JournalWrapper> _journalWrapper;
		private wCHandle<gameObject> _player;
		private CHandle<QuestListHeaderLogicController> _optionalHeaderController;
		private CHandle<QuestListHeaderLogicController> _toDoHeaderController;
		private CHandle<QuestObjectiveWrapper> _lastNonOptionalObjective;

		[Ordinal(9)] 
		[RED("entryList")] 
		public inkVerticalPanelWidgetReference EntryList
		{
			get
			{
				if (_entryList == null)
				{
					_entryList = (inkVerticalPanelWidgetReference) CR2WTypeManager.Create("inkVerticalPanelWidgetReference", "entryList", cr2w, this);
				}
				return _entryList;
			}
			set
			{
				if (_entryList == value)
				{
					return;
				}
				_entryList = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("scanPulse")] 
		public inkCompoundWidgetReference ScanPulse
		{
			get
			{
				if (_scanPulse == null)
				{
					_scanPulse = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "scanPulse", cr2w, this);
				}
				return _scanPulse;
			}
			set
			{
				if (_scanPulse == value)
				{
					return;
				}
				_scanPulse = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("optionalHeader")] 
		public inkWidgetReference OptionalHeader
		{
			get
			{
				if (_optionalHeader == null)
				{
					_optionalHeader = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "optionalHeader", cr2w, this);
				}
				return _optionalHeader;
			}
			set
			{
				if (_optionalHeader == value)
				{
					return;
				}
				_optionalHeader = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("toDoHeader")] 
		public inkWidgetReference ToDoHeader
		{
			get
			{
				if (_toDoHeader == null)
				{
					_toDoHeader = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "toDoHeader", cr2w, this);
				}
				return _toDoHeader;
			}
			set
			{
				if (_toDoHeader == value)
				{
					return;
				}
				_toDoHeader = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("optionalList")] 
		public inkVerticalPanelWidgetReference OptionalList
		{
			get
			{
				if (_optionalList == null)
				{
					_optionalList = (inkVerticalPanelWidgetReference) CR2WTypeManager.Create("inkVerticalPanelWidgetReference", "optionalList", cr2w, this);
				}
				return _optionalList;
			}
			set
			{
				if (_optionalList == value)
				{
					return;
				}
				_optionalList = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("nonOptionalList")] 
		public inkVerticalPanelWidgetReference NonOptionalList
		{
			get
			{
				if (_nonOptionalList == null)
				{
					_nonOptionalList = (inkVerticalPanelWidgetReference) CR2WTypeManager.Create("inkVerticalPanelWidgetReference", "nonOptionalList", cr2w, this);
				}
				return _nonOptionalList;
			}
			set
			{
				if (_nonOptionalList == value)
				{
					return;
				}
				_nonOptionalList = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("entryControllers")] 
		public CHandle<inkScriptDynArray> EntryControllers
		{
			get
			{
				if (_entryControllers == null)
				{
					_entryControllers = (CHandle<inkScriptDynArray>) CR2WTypeManager.Create("handle:inkScriptDynArray", "entryControllers", cr2w, this);
				}
				return _entryControllers;
			}
			set
			{
				if (_entryControllers == value)
				{
					return;
				}
				_entryControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("scanPulseAnimProxy")] 
		public CHandle<inkanimProxy> ScanPulseAnimProxy
		{
			get
			{
				if (_scanPulseAnimProxy == null)
				{
					_scanPulseAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "scanPulseAnimProxy", cr2w, this);
				}
				return _scanPulseAnimProxy;
			}
			set
			{
				if (_scanPulseAnimProxy == value)
				{
					return;
				}
				_scanPulseAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("stateChangesBlackboardId")] 
		public CUInt32 StateChangesBlackboardId
		{
			get
			{
				if (_stateChangesBlackboardId == null)
				{
					_stateChangesBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "stateChangesBlackboardId", cr2w, this);
				}
				return _stateChangesBlackboardId;
			}
			set
			{
				if (_stateChangesBlackboardId == value)
				{
					return;
				}
				_stateChangesBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("trackedChangesBlackboardId")] 
		public CUInt32 TrackedChangesBlackboardId
		{
			get
			{
				if (_trackedChangesBlackboardId == null)
				{
					_trackedChangesBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "trackedChangesBlackboardId", cr2w, this);
				}
				return _trackedChangesBlackboardId;
			}
			set
			{
				if (_trackedChangesBlackboardId == value)
				{
					return;
				}
				_trackedChangesBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("JournalWrapper")] 
		public CHandle<JournalWrapper> JournalWrapper
		{
			get
			{
				if (_journalWrapper == null)
				{
					_journalWrapper = (CHandle<JournalWrapper>) CR2WTypeManager.Create("handle:JournalWrapper", "JournalWrapper", cr2w, this);
				}
				return _journalWrapper;
			}
			set
			{
				if (_journalWrapper == value)
				{
					return;
				}
				_journalWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("optionalHeaderController")] 
		public CHandle<QuestListHeaderLogicController> OptionalHeaderController
		{
			get
			{
				if (_optionalHeaderController == null)
				{
					_optionalHeaderController = (CHandle<QuestListHeaderLogicController>) CR2WTypeManager.Create("handle:QuestListHeaderLogicController", "optionalHeaderController", cr2w, this);
				}
				return _optionalHeaderController;
			}
			set
			{
				if (_optionalHeaderController == value)
				{
					return;
				}
				_optionalHeaderController = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("toDoHeaderController")] 
		public CHandle<QuestListHeaderLogicController> ToDoHeaderController
		{
			get
			{
				if (_toDoHeaderController == null)
				{
					_toDoHeaderController = (CHandle<QuestListHeaderLogicController>) CR2WTypeManager.Create("handle:QuestListHeaderLogicController", "toDoHeaderController", cr2w, this);
				}
				return _toDoHeaderController;
			}
			set
			{
				if (_toDoHeaderController == value)
				{
					return;
				}
				_toDoHeaderController = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("lastNonOptionalObjective")] 
		public CHandle<QuestObjectiveWrapper> LastNonOptionalObjective
		{
			get
			{
				if (_lastNonOptionalObjective == null)
				{
					_lastNonOptionalObjective = (CHandle<QuestObjectiveWrapper>) CR2WTypeManager.Create("handle:QuestObjectiveWrapper", "lastNonOptionalObjective", cr2w, this);
				}
				return _lastNonOptionalObjective;
			}
			set
			{
				if (_lastNonOptionalObjective == value)
				{
					return;
				}
				_lastNonOptionalObjective = value;
				PropertySet(this);
			}
		}

		public QuestListGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
