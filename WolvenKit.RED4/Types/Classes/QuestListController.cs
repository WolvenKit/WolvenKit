using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestListController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("CategoryName")] 
		public inkTextWidgetReference CategoryName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("QuestListRef")] 
		public inkCompoundWidgetReference QuestListRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("QuestType")] 
		public CEnum<gameJournalQuestType> QuestType
		{
			get => GetPropertyValue<CEnum<gameJournalQuestType>>();
			set => SetPropertyValue<CEnum<gameJournalQuestType>>(value);
		}

		[Ordinal(5)] 
		[RED("QuestItems")] 
		public CArray<CWeakHandle<QuestItemController>> QuestItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<QuestItemController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<QuestItemController>>>(value);
		}

		[Ordinal(6)] 
		[RED("LastQuestData")] 
		public CWeakHandle<QuestDataWrapper> LastQuestData
		{
			get => GetPropertyValue<CWeakHandle<QuestDataWrapper>>();
			set => SetPropertyValue<CWeakHandle<QuestDataWrapper>>(value);
		}

		public QuestListController()
		{
			CategoryName = new inkTextWidgetReference();
			Icon = new inkImageWidgetReference();
			QuestListRef = new inkCompoundWidgetReference();
			QuestItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
