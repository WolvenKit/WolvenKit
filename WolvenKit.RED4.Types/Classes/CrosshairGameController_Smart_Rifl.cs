using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrosshairGameController_Smart_Rifl : gameuiCrosshairBaseGameController
	{
		private inkTextWidgetReference _txtAccuracy;
		private inkTextWidgetReference _txtTargetsCount;
		private inkTextWidgetReference _txtFluffStatus;
		private inkImageWidgetReference _leftPart;
		private inkImageWidgetReference _rightPart;
		private inkImageWidgetReference _leftPartExtra;
		private inkImageWidgetReference _rightPartExtra;
		private CFloat _offsetLeftRight;
		private CFloat _offsetLeftRightExtra;
		private CFloat _latchVertical;
		private inkImageWidgetReference _topPart;
		private inkImageWidgetReference _bottomPart;
		private inkWidgetReference _horiPart;
		private inkWidgetReference _vertPart;
		private CName _targetWidgetLibraryName;
		private CInt32 _targetsPullSize;
		private inkWidgetReference _targetColorChange;
		private inkWidgetReference _targetingFrame;
		private inkWidgetReference _reticleFrame;
		private inkWidgetReference _bufferFrame;
		private inkCompoundWidgetReference _targetHolder;
		private inkCompoundWidgetReference _lockHolder;
		private inkCompoundWidgetReference _reloadIndicator;
		private inkCompoundWidgetReference _reloadIndicatorInv;
		private inkCompoundWidgetReference _smartLinkDot;
		private inkCompoundWidgetReference _smartLinkFrame;
		private inkCompoundWidgetReference _smartLinkFluff;
		private inkCompoundWidgetReference _smartLinkFirmwareOnline;
		private inkCompoundWidgetReference _smartLinkFirmwareOffline;
		private CWeakHandle<gameIBlackboard> _weaponBlackboard;
		private CHandle<redCallbackObject> _weaponParamsListenerId;
		private CArray<CWeakHandle<inkWidget>> _targets;
		private CArray<gamesmartGunUITargetParameters> _targetsData;
		private CBool _isBlocked;
		private CBool _isAimDownSights;
		private Vector2 _bufferedSpread;
		private CHandle<inkanimProxy> _reloadAnimationProxy;
		private CArray<entEntityID> _prevTargetedEntityIDs;

		[Ordinal(18)] 
		[RED("txtAccuracy")] 
		public inkTextWidgetReference TxtAccuracy
		{
			get => GetProperty(ref _txtAccuracy);
			set => SetProperty(ref _txtAccuracy, value);
		}

		[Ordinal(19)] 
		[RED("txtTargetsCount")] 
		public inkTextWidgetReference TxtTargetsCount
		{
			get => GetProperty(ref _txtTargetsCount);
			set => SetProperty(ref _txtTargetsCount, value);
		}

		[Ordinal(20)] 
		[RED("txtFluffStatus")] 
		public inkTextWidgetReference TxtFluffStatus
		{
			get => GetProperty(ref _txtFluffStatus);
			set => SetProperty(ref _txtFluffStatus, value);
		}

		[Ordinal(21)] 
		[RED("leftPart")] 
		public inkImageWidgetReference LeftPart
		{
			get => GetProperty(ref _leftPart);
			set => SetProperty(ref _leftPart, value);
		}

		[Ordinal(22)] 
		[RED("rightPart")] 
		public inkImageWidgetReference RightPart
		{
			get => GetProperty(ref _rightPart);
			set => SetProperty(ref _rightPart, value);
		}

		[Ordinal(23)] 
		[RED("leftPartExtra")] 
		public inkImageWidgetReference LeftPartExtra
		{
			get => GetProperty(ref _leftPartExtra);
			set => SetProperty(ref _leftPartExtra, value);
		}

		[Ordinal(24)] 
		[RED("rightPartExtra")] 
		public inkImageWidgetReference RightPartExtra
		{
			get => GetProperty(ref _rightPartExtra);
			set => SetProperty(ref _rightPartExtra, value);
		}

		[Ordinal(25)] 
		[RED("offsetLeftRight")] 
		public CFloat OffsetLeftRight
		{
			get => GetProperty(ref _offsetLeftRight);
			set => SetProperty(ref _offsetLeftRight, value);
		}

		[Ordinal(26)] 
		[RED("offsetLeftRightExtra")] 
		public CFloat OffsetLeftRightExtra
		{
			get => GetProperty(ref _offsetLeftRightExtra);
			set => SetProperty(ref _offsetLeftRightExtra, value);
		}

		[Ordinal(27)] 
		[RED("latchVertical")] 
		public CFloat LatchVertical
		{
			get => GetProperty(ref _latchVertical);
			set => SetProperty(ref _latchVertical, value);
		}

		[Ordinal(28)] 
		[RED("topPart")] 
		public inkImageWidgetReference TopPart
		{
			get => GetProperty(ref _topPart);
			set => SetProperty(ref _topPart, value);
		}

		[Ordinal(29)] 
		[RED("bottomPart")] 
		public inkImageWidgetReference BottomPart
		{
			get => GetProperty(ref _bottomPart);
			set => SetProperty(ref _bottomPart, value);
		}

		[Ordinal(30)] 
		[RED("horiPart")] 
		public inkWidgetReference HoriPart
		{
			get => GetProperty(ref _horiPart);
			set => SetProperty(ref _horiPart, value);
		}

		[Ordinal(31)] 
		[RED("vertPart")] 
		public inkWidgetReference VertPart
		{
			get => GetProperty(ref _vertPart);
			set => SetProperty(ref _vertPart, value);
		}

		[Ordinal(32)] 
		[RED("targetWidgetLibraryName")] 
		public CName TargetWidgetLibraryName
		{
			get => GetProperty(ref _targetWidgetLibraryName);
			set => SetProperty(ref _targetWidgetLibraryName, value);
		}

		[Ordinal(33)] 
		[RED("targetsPullSize")] 
		public CInt32 TargetsPullSize
		{
			get => GetProperty(ref _targetsPullSize);
			set => SetProperty(ref _targetsPullSize, value);
		}

		[Ordinal(34)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetProperty(ref _targetColorChange);
			set => SetProperty(ref _targetColorChange, value);
		}

		[Ordinal(35)] 
		[RED("targetingFrame")] 
		public inkWidgetReference TargetingFrame
		{
			get => GetProperty(ref _targetingFrame);
			set => SetProperty(ref _targetingFrame, value);
		}

		[Ordinal(36)] 
		[RED("reticleFrame")] 
		public inkWidgetReference ReticleFrame
		{
			get => GetProperty(ref _reticleFrame);
			set => SetProperty(ref _reticleFrame, value);
		}

		[Ordinal(37)] 
		[RED("bufferFrame")] 
		public inkWidgetReference BufferFrame
		{
			get => GetProperty(ref _bufferFrame);
			set => SetProperty(ref _bufferFrame, value);
		}

		[Ordinal(38)] 
		[RED("targetHolder")] 
		public inkCompoundWidgetReference TargetHolder
		{
			get => GetProperty(ref _targetHolder);
			set => SetProperty(ref _targetHolder, value);
		}

		[Ordinal(39)] 
		[RED("lockHolder")] 
		public inkCompoundWidgetReference LockHolder
		{
			get => GetProperty(ref _lockHolder);
			set => SetProperty(ref _lockHolder, value);
		}

		[Ordinal(40)] 
		[RED("reloadIndicator")] 
		public inkCompoundWidgetReference ReloadIndicator
		{
			get => GetProperty(ref _reloadIndicator);
			set => SetProperty(ref _reloadIndicator, value);
		}

		[Ordinal(41)] 
		[RED("reloadIndicatorInv")] 
		public inkCompoundWidgetReference ReloadIndicatorInv
		{
			get => GetProperty(ref _reloadIndicatorInv);
			set => SetProperty(ref _reloadIndicatorInv, value);
		}

		[Ordinal(42)] 
		[RED("smartLinkDot")] 
		public inkCompoundWidgetReference SmartLinkDot
		{
			get => GetProperty(ref _smartLinkDot);
			set => SetProperty(ref _smartLinkDot, value);
		}

		[Ordinal(43)] 
		[RED("smartLinkFrame")] 
		public inkCompoundWidgetReference SmartLinkFrame
		{
			get => GetProperty(ref _smartLinkFrame);
			set => SetProperty(ref _smartLinkFrame, value);
		}

		[Ordinal(44)] 
		[RED("smartLinkFluff")] 
		public inkCompoundWidgetReference SmartLinkFluff
		{
			get => GetProperty(ref _smartLinkFluff);
			set => SetProperty(ref _smartLinkFluff, value);
		}

		[Ordinal(45)] 
		[RED("smartLinkFirmwareOnline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOnline
		{
			get => GetProperty(ref _smartLinkFirmwareOnline);
			set => SetProperty(ref _smartLinkFirmwareOnline, value);
		}

		[Ordinal(46)] 
		[RED("smartLinkFirmwareOffline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOffline
		{
			get => GetProperty(ref _smartLinkFirmwareOffline);
			set => SetProperty(ref _smartLinkFirmwareOffline, value);
		}

		[Ordinal(47)] 
		[RED("weaponBlackboard")] 
		public CWeakHandle<gameIBlackboard> WeaponBlackboard
		{
			get => GetProperty(ref _weaponBlackboard);
			set => SetProperty(ref _weaponBlackboard, value);
		}

		[Ordinal(48)] 
		[RED("weaponParamsListenerId")] 
		public CHandle<redCallbackObject> WeaponParamsListenerId
		{
			get => GetProperty(ref _weaponParamsListenerId);
			set => SetProperty(ref _weaponParamsListenerId, value);
		}

		[Ordinal(49)] 
		[RED("targets")] 
		public CArray<CWeakHandle<inkWidget>> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		[Ordinal(50)] 
		[RED("targetsData")] 
		public CArray<gamesmartGunUITargetParameters> TargetsData
		{
			get => GetProperty(ref _targetsData);
			set => SetProperty(ref _targetsData, value);
		}

		[Ordinal(51)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get => GetProperty(ref _isBlocked);
			set => SetProperty(ref _isBlocked, value);
		}

		[Ordinal(52)] 
		[RED("isAimDownSights")] 
		public CBool IsAimDownSights
		{
			get => GetProperty(ref _isAimDownSights);
			set => SetProperty(ref _isAimDownSights, value);
		}

		[Ordinal(53)] 
		[RED("bufferedSpread")] 
		public Vector2 BufferedSpread
		{
			get => GetProperty(ref _bufferedSpread);
			set => SetProperty(ref _bufferedSpread, value);
		}

		[Ordinal(54)] 
		[RED("reloadAnimationProxy")] 
		public CHandle<inkanimProxy> ReloadAnimationProxy
		{
			get => GetProperty(ref _reloadAnimationProxy);
			set => SetProperty(ref _reloadAnimationProxy, value);
		}

		[Ordinal(55)] 
		[RED("prevTargetedEntityIDs")] 
		public CArray<entEntityID> PrevTargetedEntityIDs
		{
			get => GetProperty(ref _prevTargetedEntityIDs);
			set => SetProperty(ref _prevTargetedEntityIDs, value);
		}

		public CrosshairGameController_Smart_Rifl()
		{
			_offsetLeftRight = 0.800000F;
			_offsetLeftRightExtra = 1.200000F;
			_latchVertical = 40.000000F;
			_targetWidgetLibraryName = "bucket";
			_targetsPullSize = 10;
		}
	}
}
