using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AimingStateEvents : UpperBodyEventsTransition
	{
		private CHandle<gameweaponAnimFeature_AimPlayer> _aim;
		private CHandle<AnimFeature_ProceduralIronsightData> _posAnimFeature;
		private CHandle<DefaultTransitionStatusEffectListener> _statusEffectListener;
		private CWeakHandle<gameweaponObject> _weapon;
		private CWeakHandle<gameObject> _executionOwner;
		private CFloat _mouseZoomLevel;
		private CInt32 _zoomLevelNum;
		private CInt32 _numZoomLevels;
		private CInt32 _delayAimSnap;
		private CBool _isAiming;
		private CFloat _aimInTimeRemaining;
		private CBool _aimBroadcast;
		private CFloat _zoomLevel;
		private CFloat _finalZoomLevel;
		private CFloat _previousZoomLevel;
		private CFloat _currentZoomLevel;
		private CFloat _timeToBlendZoom;
		private CFloat _time;
		private CFloat _speed;
		private CBool _itemChanged;
		private CBool _firearmsNoUnequipNoSwitch;
		private CBool _shootingRangeCompetition;
		private CHandle<gameAttachmentSlotsScriptListener> _attachmentSlotListener;

		[Ordinal(6)] 
		[RED("aim")] 
		public CHandle<gameweaponAnimFeature_AimPlayer> Aim
		{
			get => GetProperty(ref _aim);
			set => SetProperty(ref _aim, value);
		}

		[Ordinal(7)] 
		[RED("posAnimFeature")] 
		public CHandle<AnimFeature_ProceduralIronsightData> PosAnimFeature
		{
			get => GetProperty(ref _posAnimFeature);
			set => SetProperty(ref _posAnimFeature, value);
		}

		[Ordinal(8)] 
		[RED("statusEffectListener")] 
		public CHandle<DefaultTransitionStatusEffectListener> StatusEffectListener
		{
			get => GetProperty(ref _statusEffectListener);
			set => SetProperty(ref _statusEffectListener, value);
		}

		[Ordinal(9)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(10)] 
		[RED("executionOwner")] 
		public CWeakHandle<gameObject> ExecutionOwner
		{
			get => GetProperty(ref _executionOwner);
			set => SetProperty(ref _executionOwner, value);
		}

		[Ordinal(11)] 
		[RED("mouseZoomLevel")] 
		public CFloat MouseZoomLevel
		{
			get => GetProperty(ref _mouseZoomLevel);
			set => SetProperty(ref _mouseZoomLevel, value);
		}

		[Ordinal(12)] 
		[RED("zoomLevelNum")] 
		public CInt32 ZoomLevelNum
		{
			get => GetProperty(ref _zoomLevelNum);
			set => SetProperty(ref _zoomLevelNum, value);
		}

		[Ordinal(13)] 
		[RED("numZoomLevels")] 
		public CInt32 NumZoomLevels
		{
			get => GetProperty(ref _numZoomLevels);
			set => SetProperty(ref _numZoomLevels, value);
		}

		[Ordinal(14)] 
		[RED("delayAimSnap")] 
		public CInt32 DelayAimSnap
		{
			get => GetProperty(ref _delayAimSnap);
			set => SetProperty(ref _delayAimSnap, value);
		}

		[Ordinal(15)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetProperty(ref _isAiming);
			set => SetProperty(ref _isAiming, value);
		}

		[Ordinal(16)] 
		[RED("aimInTimeRemaining")] 
		public CFloat AimInTimeRemaining
		{
			get => GetProperty(ref _aimInTimeRemaining);
			set => SetProperty(ref _aimInTimeRemaining, value);
		}

		[Ordinal(17)] 
		[RED("aimBroadcast")] 
		public CBool AimBroadcast
		{
			get => GetProperty(ref _aimBroadcast);
			set => SetProperty(ref _aimBroadcast, value);
		}

		[Ordinal(18)] 
		[RED("zoomLevel")] 
		public CFloat ZoomLevel
		{
			get => GetProperty(ref _zoomLevel);
			set => SetProperty(ref _zoomLevel, value);
		}

		[Ordinal(19)] 
		[RED("finalZoomLevel")] 
		public CFloat FinalZoomLevel
		{
			get => GetProperty(ref _finalZoomLevel);
			set => SetProperty(ref _finalZoomLevel, value);
		}

		[Ordinal(20)] 
		[RED("previousZoomLevel")] 
		public CFloat PreviousZoomLevel
		{
			get => GetProperty(ref _previousZoomLevel);
			set => SetProperty(ref _previousZoomLevel, value);
		}

		[Ordinal(21)] 
		[RED("currentZoomLevel")] 
		public CFloat CurrentZoomLevel
		{
			get => GetProperty(ref _currentZoomLevel);
			set => SetProperty(ref _currentZoomLevel, value);
		}

		[Ordinal(22)] 
		[RED("timeToBlendZoom")] 
		public CFloat TimeToBlendZoom
		{
			get => GetProperty(ref _timeToBlendZoom);
			set => SetProperty(ref _timeToBlendZoom, value);
		}

		[Ordinal(23)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(24)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(25)] 
		[RED("itemChanged")] 
		public CBool ItemChanged
		{
			get => GetProperty(ref _itemChanged);
			set => SetProperty(ref _itemChanged, value);
		}

		[Ordinal(26)] 
		[RED("firearmsNoUnequipNoSwitch")] 
		public CBool FirearmsNoUnequipNoSwitch
		{
			get => GetProperty(ref _firearmsNoUnequipNoSwitch);
			set => SetProperty(ref _firearmsNoUnequipNoSwitch, value);
		}

		[Ordinal(27)] 
		[RED("shootingRangeCompetition")] 
		public CBool ShootingRangeCompetition
		{
			get => GetProperty(ref _shootingRangeCompetition);
			set => SetProperty(ref _shootingRangeCompetition, value);
		}

		[Ordinal(28)] 
		[RED("attachmentSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> AttachmentSlotListener
		{
			get => GetProperty(ref _attachmentSlotListener);
			set => SetProperty(ref _attachmentSlotListener, value);
		}
	}
}
