using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehiclesManagerPopupGameController : BaseModalListPopupGameController
	{
		[Ordinal(15)] 
		[RED("repairOverlay")] 
		public inkWidgetReference RepairOverlay
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("vehicleIconContainer")] 
		public inkWidgetReference VehicleIconContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("vehicleIcon")] 
		public inkImageWidgetReference VehicleIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetPropertyValue<inkScrollAreaWidgetReference>();
			set => SetPropertyValue<inkScrollAreaWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("scrollControllerWidget")] 
		public inkWidgetReference ScrollControllerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("confirmButton")] 
		public inkWidgetReference ConfirmButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("favoriteInputHint")] 
		public inkTextWidgetReference FavoriteInputHint
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("dataView")] 
		public CHandle<VehiclesManagerDataView> DataView
		{
			get => GetPropertyValue<CHandle<VehiclesManagerDataView>>();
			set => SetPropertyValue<CHandle<VehiclesManagerDataView>>(value);
		}

		[Ordinal(23)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(24)] 
		[RED("quickSlotsManager")] 
		public CWeakHandle<QuickSlotsManager> QuickSlotsManager
		{
			get => GetPropertyValue<CWeakHandle<QuickSlotsManager>>();
			set => SetPropertyValue<CWeakHandle<QuickSlotsManager>>(value);
		}

		[Ordinal(25)] 
		[RED("scrollController")] 
		public CWeakHandle<inkScrollController> ScrollController
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		[Ordinal(26)] 
		[RED("selectAnimProxy")] 
		public CHandle<inkanimProxy> SelectAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(27)] 
		[RED("initialIndex")] 
		public CUInt32 InitialIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public VehiclesManagerPopupGameController()
		{
			RepairOverlay = new inkWidgetReference();
			VehicleIconContainer = new inkWidgetReference();
			VehicleIcon = new inkImageWidgetReference();
			ScrollArea = new inkScrollAreaWidgetReference();
			ScrollControllerWidget = new inkWidgetReference();
			ConfirmButton = new inkWidgetReference();
			FavoriteInputHint = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
