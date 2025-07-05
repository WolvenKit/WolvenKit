using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestListVirtualController : inkVirtualListController
	{
		[Ordinal(9)] 
		[RED("dataView")] 
		public CHandle<QuestListVirtualDataView> DataView
		{
			get => GetPropertyValue<CHandle<QuestListVirtualDataView>>();
			set => SetPropertyValue<CHandle<QuestListVirtualDataView>>(value);
		}

		[Ordinal(10)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(11)] 
		[RED("classifier")] 
		public CHandle<QuestListVirtualTemplateClassifier> Classifier
		{
			get => GetPropertyValue<CHandle<QuestListVirtualTemplateClassifier>>();
			set => SetPropertyValue<CHandle<QuestListVirtualTemplateClassifier>>(value);
		}

		[Ordinal(12)] 
		[RED("controller")] 
		public CWeakHandle<QuestMissionLinkController> Controller
		{
			get => GetPropertyValue<CWeakHandle<QuestMissionLinkController>>();
			set => SetPropertyValue<CWeakHandle<QuestMissionLinkController>>(value);
		}

		[Ordinal(13)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(14)] 
		[RED("questSortType")] 
		public CEnum<QuestListSortType> QuestSortType
		{
			get => GetPropertyValue<CEnum<QuestListSortType>>();
			set => SetPropertyValue<CEnum<QuestListSortType>>(value);
		}

		public QuestListVirtualController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
