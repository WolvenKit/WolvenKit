using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestListGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("entryList")] 
		public inkVerticalPanelWidgetReference EntryList
		{
			get => GetPropertyValue<inkVerticalPanelWidgetReference>();
			set => SetPropertyValue<inkVerticalPanelWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("scanPulse")] 
		public inkCompoundWidgetReference ScanPulse
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("optionalHeader")] 
		public inkWidgetReference OptionalHeader
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("toDoHeader")] 
		public inkWidgetReference ToDoHeader
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("optionalList")] 
		public inkVerticalPanelWidgetReference OptionalList
		{
			get => GetPropertyValue<inkVerticalPanelWidgetReference>();
			set => SetPropertyValue<inkVerticalPanelWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("nonOptionalList")] 
		public inkVerticalPanelWidgetReference NonOptionalList
		{
			get => GetPropertyValue<inkVerticalPanelWidgetReference>();
			set => SetPropertyValue<inkVerticalPanelWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("entryControllers")] 
		public CHandle<inkScriptDynArray> EntryControllers
		{
			get => GetPropertyValue<CHandle<inkScriptDynArray>>();
			set => SetPropertyValue<CHandle<inkScriptDynArray>>(value);
		}

		[Ordinal(16)] 
		[RED("scanPulseAnimProxy")] 
		public CHandle<inkanimProxy> ScanPulseAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(17)] 
		[RED("stateChangesBlackboardId")] 
		public CUInt32 StateChangesBlackboardId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(18)] 
		[RED("trackedChangesBlackboardId")] 
		public CUInt32 TrackedChangesBlackboardId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(19)] 
		[RED("JournalWrapper")] 
		public CHandle<JournalWrapper> JournalWrapper
		{
			get => GetPropertyValue<CHandle<JournalWrapper>>();
			set => SetPropertyValue<CHandle<JournalWrapper>>(value);
		}

		[Ordinal(20)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(21)] 
		[RED("optionalHeaderController")] 
		public CWeakHandle<QuestListHeaderLogicController> OptionalHeaderController
		{
			get => GetPropertyValue<CWeakHandle<QuestListHeaderLogicController>>();
			set => SetPropertyValue<CWeakHandle<QuestListHeaderLogicController>>(value);
		}

		[Ordinal(22)] 
		[RED("toDoHeaderController")] 
		public CWeakHandle<QuestListHeaderLogicController> ToDoHeaderController
		{
			get => GetPropertyValue<CWeakHandle<QuestListHeaderLogicController>>();
			set => SetPropertyValue<CWeakHandle<QuestListHeaderLogicController>>(value);
		}

		[Ordinal(23)] 
		[RED("lastNonOptionalObjective")] 
		public CHandle<QuestObjectiveWrapper> LastNonOptionalObjective
		{
			get => GetPropertyValue<CHandle<QuestObjectiveWrapper>>();
			set => SetPropertyValue<CHandle<QuestObjectiveWrapper>>(value);
		}

		public QuestListGameController()
		{
			EntryList = new();
			ScanPulse = new();
			OptionalHeader = new();
			ToDoHeader = new();
			OptionalList = new();
			NonOptionalList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
