using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehiclesManagerPopupGameController : BaseModalListPopupGameController
	{
		[Ordinal(13)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetPropertyValue<inkScrollAreaWidgetReference>();
			set => SetPropertyValue<inkScrollAreaWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("scrollControllerWidget")] 
		public inkWidgetReference ScrollControllerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("dataView")] 
		public CHandle<VehiclesManagerDataView> DataView
		{
			get => GetPropertyValue<CHandle<VehiclesManagerDataView>>();
			set => SetPropertyValue<CHandle<VehiclesManagerDataView>>(value);
		}

		[Ordinal(17)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(18)] 
		[RED("quickSlotsManager")] 
		public CWeakHandle<QuickSlotsManager> QuickSlotsManager
		{
			get => GetPropertyValue<CWeakHandle<QuickSlotsManager>>();
			set => SetPropertyValue<CWeakHandle<QuickSlotsManager>>(value);
		}

		[Ordinal(19)] 
		[RED("scrollController")] 
		public CWeakHandle<inkScrollController> ScrollController
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		public VehiclesManagerPopupGameController()
		{
			Icon = new inkImageWidgetReference();
			ScrollArea = new inkScrollAreaWidgetReference();
			ScrollControllerWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
