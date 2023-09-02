using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestDetailsObjectiveController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("objectiveName")] 
		public inkTextWidgetReference ObjectiveName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("trackingMarker")] 
		public inkWidgetReference TrackingMarker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("objective")] 
		public CWeakHandle<gameJournalQuestObjective> Objective
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuestObjective>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuestObjective>>(value);
		}

		[Ordinal(5)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuestDetailsObjectiveController()
		{
			ObjectiveName = new inkTextWidgetReference();
			TrackingMarker = new inkWidgetReference();
			Root = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
