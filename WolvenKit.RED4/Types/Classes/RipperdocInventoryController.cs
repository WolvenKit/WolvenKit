using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocInventoryController : inkWidgetLogicController
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
		[RED("labelPrefix")] 
		public inkTextWidgetReference LabelPrefix
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("labelSuffix")] 
		public inkTextWidgetReference LabelSuffix
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("virtualGrid")] 
		public CWeakHandle<inkVirtualGridController> VirtualGrid
		{
			get => GetPropertyValue<CWeakHandle<inkVirtualGridController>>();
			set => SetPropertyValue<CWeakHandle<inkVirtualGridController>>(value);
		}

		[Ordinal(6)] 
		[RED("backpackItemsClassifier")] 
		public CHandle<RipperdocInventoryTemplateClassifier> BackpackItemsClassifier
		{
			get => GetPropertyValue<CHandle<RipperdocInventoryTemplateClassifier>>();
			set => SetPropertyValue<CHandle<RipperdocInventoryTemplateClassifier>>(value);
		}

		[Ordinal(7)] 
		[RED("backpackItemsDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> BackpackItemsDataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(8)] 
		[RED("backpackItemsDataView")] 
		public CHandle<inkScriptableDataViewWrapper> BackpackItemsDataView
		{
			get => GetPropertyValue<CHandle<inkScriptableDataViewWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataViewWrapper>>(value);
		}

		[Ordinal(9)] 
		[RED("scrollBar")] 
		public CWeakHandle<inkScrollController> ScrollBar
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		[Ordinal(10)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(11)] 
		[RED("opacityAnimation")] 
		public CHandle<inkanimProxy> OpacityAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(12)] 
		[RED("labelPulse")] 
		public CHandle<PulseAnimation> LabelPulse
		{
			get => GetPropertyValue<CHandle<PulseAnimation>>();
			set => SetPropertyValue<CHandle<PulseAnimation>>(value);
		}

		[Ordinal(13)] 
		[RED("cachedPlayerItems")] 
		public CArray<CHandle<RipperdocWrappedUIInventoryItem>> CachedPlayerItems
		{
			get => GetPropertyValue<CArray<CHandle<RipperdocWrappedUIInventoryItem>>>();
			set => SetPropertyValue<CArray<CHandle<RipperdocWrappedUIInventoryItem>>>(value);
		}

		[Ordinal(14)] 
		[RED("cachedVendorItems")] 
		public CArray<CHandle<RipperdocWrappedUIInventoryItem>> CachedVendorItems
		{
			get => GetPropertyValue<CArray<CHandle<RipperdocWrappedUIInventoryItem>>>();
			set => SetPropertyValue<CArray<CHandle<RipperdocWrappedUIInventoryItem>>>(value);
		}

		[Ordinal(15)] 
		[RED("cachedArea")] 
		public CEnum<gamedataEquipmentArea> CachedArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(16)] 
		[RED("openArea")] 
		public CEnum<gamedataEquipmentArea> OpenArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(17)] 
		[RED("cachedAttribute")] 
		public CEnum<gamedataStatType> CachedAttribute
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(18)] 
		[RED("openAttribute")] 
		public CEnum<gamedataStatType> OpenAttribute
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(19)] 
		[RED("hasCache")] 
		public CBool HasCache
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("isAreaCache")] 
		public CBool IsAreaCache
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RipperdocInventoryController()
		{
			VirtualGridContainer = new inkVirtualCompoundWidgetReference();
			ScrollBarContainer = new inkWidgetReference();
			LabelPrefix = new inkTextWidgetReference();
			LabelSuffix = new inkTextWidgetReference();
			CachedPlayerItems = new();
			CachedVendorItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
