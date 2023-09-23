using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestMappinController : gameuiQuestMappinController
	{
		[Ordinal(14)] 
		[RED("arrowCanvas")] 
		public inkWidgetReference ArrowCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("arrowPart")] 
		public inkWidgetReference ArrowPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("selector")] 
		public inkWidgetReference Selector
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("scanningDiamond")] 
		public inkWidgetReference ScanningDiamond
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("portalIcon")] 
		public inkWidgetReference PortalIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("aboveWidget")] 
		public CWeakHandle<inkWidget> AboveWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(20)] 
		[RED("belowWidget")] 
		public CWeakHandle<inkWidget> BelowWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(21)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsIMappin> Mappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsIMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsIMappin>>(value);
		}

		[Ordinal(22)] 
		[RED("questMappin")] 
		public CWeakHandle<gamemappinsQuestMappin> QuestMappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsQuestMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsQuestMappin>>(value);
		}

		[Ordinal(23)] 
		[RED("runtimeMappin")] 
		public CWeakHandle<gamemappinsRuntimeMappin> RuntimeMappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsRuntimeMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsRuntimeMappin>>(value);
		}

		[Ordinal(24)] 
		[RED("root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(25)] 
		[RED("isMainQuest")] 
		public CBool IsMainQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("shouldHideWhenClamped")] 
		public CBool ShouldHideWhenClamped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("isCompletedPhase")] 
		public CBool IsCompletedPhase
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(29)] 
		[RED("animOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(30)] 
		[RED("vehicleAlreadySummonedTime")] 
		public EngineTime VehicleAlreadySummonedTime
		{
			get => GetPropertyValue<EngineTime>();
			set => SetPropertyValue<EngineTime>(value);
		}

		[Ordinal(31)] 
		[RED("vehiclePulseTimeSecs")] 
		public CFloat VehiclePulseTimeSecs
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("vehicleMappinComponent")] 
		public CHandle<VehicleMappinComponent> VehicleMappinComponent
		{
			get => GetPropertyValue<CHandle<VehicleMappinComponent>>();
			set => SetPropertyValue<CHandle<VehicleMappinComponent>>(value);
		}

		public QuestMappinController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
