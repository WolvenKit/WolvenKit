using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestListVirtualDataView : inkScriptableDataViewWrapper
	{
		[Ordinal(0)] 
		[RED("filterType")] 
		public CEnum<QuestListItemType> FilterType
		{
			get => GetPropertyValue<CEnum<QuestListItemType>>();
			set => SetPropertyValue<CEnum<QuestListItemType>>(value);
		}

		[Ordinal(1)] 
		[RED("compareBuilder")] 
		public CHandle<CompareBuilder> CompareBuilder
		{
			get => GetPropertyValue<CHandle<CompareBuilder>>();
			set => SetPropertyValue<CHandle<CompareBuilder>>(value);
		}

		[Ordinal(2)] 
		[RED("currentQuestSortType")] 
		public CEnum<QuestListSortType> CurrentQuestSortType
		{
			get => GetPropertyValue<CEnum<QuestListSortType>>();
			set => SetPropertyValue<CEnum<QuestListSortType>>(value);
		}

		public QuestListVirtualDataView()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
