using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerkSkillsLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("virtualGridContainer")] 
		public inkVirtualCompoundWidgetReference VirtualGridContainer
		{
			get => GetPropertyValue<inkVirtualCompoundWidgetReference>();
			set => SetPropertyValue<inkVirtualCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("scrollBarContainer")] 
		public inkWidgetReference ScrollBarContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("virtualGrid")] 
		public CWeakHandle<inkVirtualGridController> VirtualGrid
		{
			get => GetPropertyValue<CWeakHandle<inkVirtualGridController>>();
			set => SetPropertyValue<CWeakHandle<inkVirtualGridController>>(value);
		}

		[Ordinal(4)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(5)] 
		[RED("itemsClassifier")] 
		public CHandle<inkVirtualItemTemplateClassifierWrapper> ItemsClassifier
		{
			get => GetPropertyValue<CHandle<inkVirtualItemTemplateClassifierWrapper>>();
			set => SetPropertyValue<CHandle<inkVirtualItemTemplateClassifierWrapper>>(value);
		}

		[Ordinal(6)] 
		[RED("scrollBar")] 
		public CWeakHandle<inkScrollController> ScrollBar
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		[Ordinal(7)] 
		[RED("dataManager")] 
		public CWeakHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetPropertyValue<CWeakHandle<PlayerDevelopmentDataManager>>();
			set => SetPropertyValue<CWeakHandle<PlayerDevelopmentDataManager>>(value);
		}

		[Ordinal(8)] 
		[RED("isActiveScreen")] 
		public CBool IsActiveScreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("virtualItems")] 
		public CArray<CHandle<IScriptable>> VirtualItems
		{
			get => GetPropertyValue<CArray<CHandle<IScriptable>>>();
			set => SetPropertyValue<CArray<CHandle<IScriptable>>>(value);
		}

		public NewPerkSkillsLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
