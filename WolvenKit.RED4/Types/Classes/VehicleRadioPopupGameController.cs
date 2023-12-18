using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleRadioPopupGameController : BaseModalListPopupGameController
	{
		[Ordinal(15)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("trackName")] 
		public inkTextWidgetReference TrackName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetPropertyValue<inkScrollAreaWidgetReference>();
			set => SetPropertyValue<inkScrollAreaWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("scrollControllerWidget")] 
		public inkWidgetReference ScrollControllerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("radioVolumeSettings")] 
		public inkWidgetReference RadioVolumeSettings
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("volumeSettingGroupName")] 
		public CName VolumeSettingGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("volumeSettingVarName")] 
		public CName VolumeSettingVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("dataView")] 
		public CHandle<RadioStationsDataView> DataView
		{
			get => GetPropertyValue<CHandle<RadioStationsDataView>>();
			set => SetPropertyValue<CHandle<RadioStationsDataView>>(value);
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
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(26)] 
		[RED("playerVehicle")] 
		public CWeakHandle<vehicleBaseObject> PlayerVehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(27)] 
		[RED("startupIndex")] 
		public CUInt32 StartupIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(28)] 
		[RED("currentRadioId")] 
		public CInt32 CurrentRadioId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(29)] 
		[RED("selectedItem")] 
		public CWeakHandle<RadioStationListItemController> SelectedItem
		{
			get => GetPropertyValue<CWeakHandle<RadioStationListItemController>>();
			set => SetPropertyValue<CWeakHandle<RadioStationListItemController>>(value);
		}

		[Ordinal(30)] 
		[RED("scrollController")] 
		public CWeakHandle<inkScrollController> ScrollController
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		[Ordinal(31)] 
		[RED("canVolumeDown")] 
		public CBool CanVolumeDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("canVolumeUp")] 
		public CBool CanVolumeUp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("radioVolumeSettingsController")] 
		public CWeakHandle<RadioVolumeSettingsController> RadioVolumeSettingsController
		{
			get => GetPropertyValue<CWeakHandle<RadioVolumeSettingsController>>();
			set => SetPropertyValue<CWeakHandle<RadioVolumeSettingsController>>(value);
		}

		public VehicleRadioPopupGameController()
		{
			Icon = new inkImageWidgetReference();
			TrackName = new inkTextWidgetReference();
			ScrollArea = new inkScrollAreaWidgetReference();
			ScrollControllerWidget = new inkWidgetReference();
			RadioVolumeSettings = new inkWidgetReference();
			VolumeSettingGroupName = "/audio/volume";
			VolumeSettingVarName = "CarRadioVolume";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
