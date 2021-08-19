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
		private wCHandle<QuestListHeaderLogicController> _optionalHeaderController;
		private wCHandle<QuestListHeaderLogicController> _toDoHeaderController;
		private CHandle<QuestObjectiveWrapper> _lastNonOptionalObjective;

		[Ordinal(9)] 
		[RED("entryList")] 
		public inkVerticalPanelWidgetReference EntryList
		{
			get => GetProperty(ref _entryList);
			set => SetProperty(ref _entryList, value);
		}

		[Ordinal(10)] 
		[RED("scanPulse")] 
		public inkCompoundWidgetReference ScanPulse
		{
			get => GetProperty(ref _scanPulse);
			set => SetProperty(ref _scanPulse, value);
		}

		[Ordinal(11)] 
		[RED("optionalHeader")] 
		public inkWidgetReference OptionalHeader
		{
			get => GetProperty(ref _optionalHeader);
			set => SetProperty(ref _optionalHeader, value);
		}

		[Ordinal(12)] 
		[RED("toDoHeader")] 
		public inkWidgetReference ToDoHeader
		{
			get => GetProperty(ref _toDoHeader);
			set => SetProperty(ref _toDoHeader, value);
		}

		[Ordinal(13)] 
		[RED("optionalList")] 
		public inkVerticalPanelWidgetReference OptionalList
		{
			get => GetProperty(ref _optionalList);
			set => SetProperty(ref _optionalList, value);
		}

		[Ordinal(14)] 
		[RED("nonOptionalList")] 
		public inkVerticalPanelWidgetReference NonOptionalList
		{
			get => GetProperty(ref _nonOptionalList);
			set => SetProperty(ref _nonOptionalList, value);
		}

		[Ordinal(15)] 
		[RED("entryControllers")] 
		public CHandle<inkScriptDynArray> EntryControllers
		{
			get => GetProperty(ref _entryControllers);
			set => SetProperty(ref _entryControllers, value);
		}

		[Ordinal(16)] 
		[RED("scanPulseAnimProxy")] 
		public CHandle<inkanimProxy> ScanPulseAnimProxy
		{
			get => GetProperty(ref _scanPulseAnimProxy);
			set => SetProperty(ref _scanPulseAnimProxy, value);
		}

		[Ordinal(17)] 
		[RED("stateChangesBlackboardId")] 
		public CUInt32 StateChangesBlackboardId
		{
			get => GetProperty(ref _stateChangesBlackboardId);
			set => SetProperty(ref _stateChangesBlackboardId, value);
		}

		[Ordinal(18)] 
		[RED("trackedChangesBlackboardId")] 
		public CUInt32 TrackedChangesBlackboardId
		{
			get => GetProperty(ref _trackedChangesBlackboardId);
			set => SetProperty(ref _trackedChangesBlackboardId, value);
		}

		[Ordinal(19)] 
		[RED("JournalWrapper")] 
		public CHandle<JournalWrapper> JournalWrapper
		{
			get => GetProperty(ref _journalWrapper);
			set => SetProperty(ref _journalWrapper, value);
		}

		[Ordinal(20)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(21)] 
		[RED("optionalHeaderController")] 
		public wCHandle<QuestListHeaderLogicController> OptionalHeaderController
		{
			get => GetProperty(ref _optionalHeaderController);
			set => SetProperty(ref _optionalHeaderController, value);
		}

		[Ordinal(22)] 
		[RED("toDoHeaderController")] 
		public wCHandle<QuestListHeaderLogicController> ToDoHeaderController
		{
			get => GetProperty(ref _toDoHeaderController);
			set => SetProperty(ref _toDoHeaderController, value);
		}

		[Ordinal(23)] 
		[RED("lastNonOptionalObjective")] 
		public CHandle<QuestObjectiveWrapper> LastNonOptionalObjective
		{
			get => GetProperty(ref _lastNonOptionalObjective);
			set => SetProperty(ref _lastNonOptionalObjective, value);
		}

		public QuestListGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
