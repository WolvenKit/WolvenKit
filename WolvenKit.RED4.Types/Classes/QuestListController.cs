using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestListController : inkWidgetLogicController
	{
		private inkTextWidgetReference _categoryName;
		private inkImageWidgetReference _icon;
		private inkCompoundWidgetReference _questListRef;
		private CEnum<gameJournalQuestType> _questType;
		private CArray<CWeakHandle<QuestItemController>> _questItems;
		private CWeakHandle<QuestDataWrapper> _lastQuestData;

		[Ordinal(1)] 
		[RED("CategoryName")] 
		public inkTextWidgetReference CategoryName
		{
			get => GetProperty(ref _categoryName);
			set => SetProperty(ref _categoryName, value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(3)] 
		[RED("QuestListRef")] 
		public inkCompoundWidgetReference QuestListRef
		{
			get => GetProperty(ref _questListRef);
			set => SetProperty(ref _questListRef, value);
		}

		[Ordinal(4)] 
		[RED("QuestType")] 
		public CEnum<gameJournalQuestType> QuestType
		{
			get => GetProperty(ref _questType);
			set => SetProperty(ref _questType, value);
		}

		[Ordinal(5)] 
		[RED("QuestItems")] 
		public CArray<CWeakHandle<QuestItemController>> QuestItems
		{
			get => GetProperty(ref _questItems);
			set => SetProperty(ref _questItems, value);
		}

		[Ordinal(6)] 
		[RED("LastQuestData")] 
		public CWeakHandle<QuestDataWrapper> LastQuestData
		{
			get => GetProperty(ref _lastQuestData);
			set => SetProperty(ref _lastQuestData, value);
		}
	}
}
