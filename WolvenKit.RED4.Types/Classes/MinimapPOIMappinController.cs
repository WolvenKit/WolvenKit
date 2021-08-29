using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinimapPOIMappinController : gameuiBaseMinimapMappinController
	{
		private inkWidgetReference _pulseWidget;
		private CBool _pingAnimationOnStateChange;
		private CWeakHandle<gamemappinsPointOfInterestMappin> _poiMappin;
		private CBool _isCompletedPhase;
		private CEnum<gamedataMappinPhase> _mappinPhase;
		private CHandle<inkanimProxy> _pingAnim;
		private CUInt32 _c_pingAnimCount;
		private CHandle<VehicleMinimapMappinComponent> _vehicleMinimapMappinComponent;
		private CBool _keepIconOnClamping;

		[Ordinal(14)] 
		[RED("pulseWidget")] 
		public inkWidgetReference PulseWidget
		{
			get => GetProperty(ref _pulseWidget);
			set => SetProperty(ref _pulseWidget, value);
		}

		[Ordinal(15)] 
		[RED("pingAnimationOnStateChange")] 
		public CBool PingAnimationOnStateChange
		{
			get => GetProperty(ref _pingAnimationOnStateChange);
			set => SetProperty(ref _pingAnimationOnStateChange, value);
		}

		[Ordinal(16)] 
		[RED("poiMappin")] 
		public CWeakHandle<gamemappinsPointOfInterestMappin> PoiMappin
		{
			get => GetProperty(ref _poiMappin);
			set => SetProperty(ref _poiMappin, value);
		}

		[Ordinal(17)] 
		[RED("isCompletedPhase")] 
		public CBool IsCompletedPhase
		{
			get => GetProperty(ref _isCompletedPhase);
			set => SetProperty(ref _isCompletedPhase, value);
		}

		[Ordinal(18)] 
		[RED("mappinPhase")] 
		public CEnum<gamedataMappinPhase> MappinPhase
		{
			get => GetProperty(ref _mappinPhase);
			set => SetProperty(ref _mappinPhase, value);
		}

		[Ordinal(19)] 
		[RED("pingAnim")] 
		public CHandle<inkanimProxy> PingAnim
		{
			get => GetProperty(ref _pingAnim);
			set => SetProperty(ref _pingAnim, value);
		}

		[Ordinal(20)] 
		[RED("c_pingAnimCount")] 
		public CUInt32 C_pingAnimCount
		{
			get => GetProperty(ref _c_pingAnimCount);
			set => SetProperty(ref _c_pingAnimCount, value);
		}

		[Ordinal(21)] 
		[RED("vehicleMinimapMappinComponent")] 
		public CHandle<VehicleMinimapMappinComponent> VehicleMinimapMappinComponent
		{
			get => GetProperty(ref _vehicleMinimapMappinComponent);
			set => SetProperty(ref _vehicleMinimapMappinComponent, value);
		}

		[Ordinal(22)] 
		[RED("keepIconOnClamping")] 
		public CBool KeepIconOnClamping
		{
			get => GetProperty(ref _keepIconOnClamping);
			set => SetProperty(ref _keepIconOnClamping, value);
		}
	}
}
