using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestMappinController : gameuiQuestMappinController
	{
		private inkWidgetReference _arrowCanvas;
		private inkWidgetReference _arrowPart;
		private inkWidgetReference _selector;
		private inkWidgetReference _scanningDiamond;
		private inkWidgetReference _portalIcon;
		private wCHandle<inkWidget> _aboveWidget;
		private wCHandle<inkWidget> _belowWidget;
		private wCHandle<gamemappinsIMappin> _mappin;
		private wCHandle<gamemappinsQuestMappin> _questMappin;
		private wCHandle<gamemappinsRuntimeMappin> _runtimeMappin;
		private wCHandle<inkCompoundWidget> _root;
		private CBool _isMainQuest;
		private CBool _shouldHideWhenClamped;
		private CBool _isCompletedPhase;
		private CHandle<inkanimProxy> _animProxy;
		private inkanimPlaybackOptions _animOptions;
		private EngineTime _vehicleAlreadySummonedTime;
		private CFloat _vehiclePulseTimeSecs;
		private CHandle<VehicleMappinComponent> _vehicleMappinComponent;

		[Ordinal(14)] 
		[RED("arrowCanvas")] 
		public inkWidgetReference ArrowCanvas
		{
			get => GetProperty(ref _arrowCanvas);
			set => SetProperty(ref _arrowCanvas, value);
		}

		[Ordinal(15)] 
		[RED("arrowPart")] 
		public inkWidgetReference ArrowPart
		{
			get => GetProperty(ref _arrowPart);
			set => SetProperty(ref _arrowPart, value);
		}

		[Ordinal(16)] 
		[RED("selector")] 
		public inkWidgetReference Selector
		{
			get => GetProperty(ref _selector);
			set => SetProperty(ref _selector, value);
		}

		[Ordinal(17)] 
		[RED("scanningDiamond")] 
		public inkWidgetReference ScanningDiamond
		{
			get => GetProperty(ref _scanningDiamond);
			set => SetProperty(ref _scanningDiamond, value);
		}

		[Ordinal(18)] 
		[RED("portalIcon")] 
		public inkWidgetReference PortalIcon
		{
			get => GetProperty(ref _portalIcon);
			set => SetProperty(ref _portalIcon, value);
		}

		[Ordinal(19)] 
		[RED("aboveWidget")] 
		public wCHandle<inkWidget> AboveWidget
		{
			get => GetProperty(ref _aboveWidget);
			set => SetProperty(ref _aboveWidget, value);
		}

		[Ordinal(20)] 
		[RED("belowWidget")] 
		public wCHandle<inkWidget> BelowWidget
		{
			get => GetProperty(ref _belowWidget);
			set => SetProperty(ref _belowWidget, value);
		}

		[Ordinal(21)] 
		[RED("mappin")] 
		public wCHandle<gamemappinsIMappin> Mappin
		{
			get => GetProperty(ref _mappin);
			set => SetProperty(ref _mappin, value);
		}

		[Ordinal(22)] 
		[RED("questMappin")] 
		public wCHandle<gamemappinsQuestMappin> QuestMappin
		{
			get => GetProperty(ref _questMappin);
			set => SetProperty(ref _questMappin, value);
		}

		[Ordinal(23)] 
		[RED("runtimeMappin")] 
		public wCHandle<gamemappinsRuntimeMappin> RuntimeMappin
		{
			get => GetProperty(ref _runtimeMappin);
			set => SetProperty(ref _runtimeMappin, value);
		}

		[Ordinal(24)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(25)] 
		[RED("isMainQuest")] 
		public CBool IsMainQuest
		{
			get => GetProperty(ref _isMainQuest);
			set => SetProperty(ref _isMainQuest, value);
		}

		[Ordinal(26)] 
		[RED("shouldHideWhenClamped")] 
		public CBool ShouldHideWhenClamped
		{
			get => GetProperty(ref _shouldHideWhenClamped);
			set => SetProperty(ref _shouldHideWhenClamped, value);
		}

		[Ordinal(27)] 
		[RED("isCompletedPhase")] 
		public CBool IsCompletedPhase
		{
			get => GetProperty(ref _isCompletedPhase);
			set => SetProperty(ref _isCompletedPhase, value);
		}

		[Ordinal(28)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(29)] 
		[RED("animOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetProperty(ref _animOptions);
			set => SetProperty(ref _animOptions, value);
		}

		[Ordinal(30)] 
		[RED("vehicleAlreadySummonedTime")] 
		public EngineTime VehicleAlreadySummonedTime
		{
			get => GetProperty(ref _vehicleAlreadySummonedTime);
			set => SetProperty(ref _vehicleAlreadySummonedTime, value);
		}

		[Ordinal(31)] 
		[RED("vehiclePulseTimeSecs")] 
		public CFloat VehiclePulseTimeSecs
		{
			get => GetProperty(ref _vehiclePulseTimeSecs);
			set => SetProperty(ref _vehiclePulseTimeSecs, value);
		}

		[Ordinal(32)] 
		[RED("vehicleMappinComponent")] 
		public CHandle<VehicleMappinComponent> VehicleMappinComponent
		{
			get => GetProperty(ref _vehicleMappinComponent);
			set => SetProperty(ref _vehicleMappinComponent, value);
		}

		public QuestMappinController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
