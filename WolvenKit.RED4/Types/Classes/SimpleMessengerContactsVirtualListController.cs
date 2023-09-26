using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SimpleMessengerContactsVirtualListController : inkVirtualListController
	{
		[Ordinal(9)] 
		[RED("dataView")] 
		public CHandle<SimpleMessengerContactDataView> DataView
		{
			get => GetPropertyValue<CHandle<SimpleMessengerContactDataView>>();
			set => SetPropertyValue<CHandle<SimpleMessengerContactDataView>>(value);
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

		public SimpleMessengerContactsVirtualListController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
