using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Crosshair_Custom_HMG : gameuiCrosshairBaseGameController
	{
		private inkWidgetReference _leftPart;
		private inkWidgetReference _rightPart;
		private inkWidgetReference _topPart;
		private inkWidgetReference _bottomPart;
		private inkWidgetReference _horiPart;
		private inkWidgetReference _vertPart;
		private inkWidgetReference _overheatContainer;
		private inkWidgetReference _overheatWarning;
		private inkWidgetReference _overheatMask;
		private inkTextWidgetReference _overheatValueL;
		private inkTextWidgetReference _overheatValueR;
		private inkImageWidgetReference _leftPartExtra;
		private inkImageWidgetReference _rightPartExtra;
		private inkCanvasWidgetReference _crosshairContainer;
		private CFloat _offsetLeftRight;
		private CFloat _offsetLeftRightExtra;
		private CFloat _latchVertical;
		private CWeakHandle<gameIBlackboard> _weaponLocalBB;
		private CHandle<redCallbackObject> _overheatBBID;
		private CHandle<redCallbackObject> _forcedOverheatBBID;
		private inkWidgetReference _targetColorChange;
		private CHandle<inkanimProxy> _forcedCooldownProxy;
		private inkanimPlaybackOptions _forcedCooldownOptions;

		[Ordinal(18)] 
		[RED("leftPart")] 
		public inkWidgetReference LeftPart
		{
			get => GetProperty(ref _leftPart);
			set => SetProperty(ref _leftPart, value);
		}

		[Ordinal(19)] 
		[RED("rightPart")] 
		public inkWidgetReference RightPart
		{
			get => GetProperty(ref _rightPart);
			set => SetProperty(ref _rightPart, value);
		}

		[Ordinal(20)] 
		[RED("topPart")] 
		public inkWidgetReference TopPart
		{
			get => GetProperty(ref _topPart);
			set => SetProperty(ref _topPart, value);
		}

		[Ordinal(21)] 
		[RED("bottomPart")] 
		public inkWidgetReference BottomPart
		{
			get => GetProperty(ref _bottomPart);
			set => SetProperty(ref _bottomPart, value);
		}

		[Ordinal(22)] 
		[RED("horiPart")] 
		public inkWidgetReference HoriPart
		{
			get => GetProperty(ref _horiPart);
			set => SetProperty(ref _horiPart, value);
		}

		[Ordinal(23)] 
		[RED("vertPart")] 
		public inkWidgetReference VertPart
		{
			get => GetProperty(ref _vertPart);
			set => SetProperty(ref _vertPart, value);
		}

		[Ordinal(24)] 
		[RED("overheatContainer")] 
		public inkWidgetReference OverheatContainer
		{
			get => GetProperty(ref _overheatContainer);
			set => SetProperty(ref _overheatContainer, value);
		}

		[Ordinal(25)] 
		[RED("overheatWarning")] 
		public inkWidgetReference OverheatWarning
		{
			get => GetProperty(ref _overheatWarning);
			set => SetProperty(ref _overheatWarning, value);
		}

		[Ordinal(26)] 
		[RED("overheatMask")] 
		public inkWidgetReference OverheatMask
		{
			get => GetProperty(ref _overheatMask);
			set => SetProperty(ref _overheatMask, value);
		}

		[Ordinal(27)] 
		[RED("overheatValueL")] 
		public inkTextWidgetReference OverheatValueL
		{
			get => GetProperty(ref _overheatValueL);
			set => SetProperty(ref _overheatValueL, value);
		}

		[Ordinal(28)] 
		[RED("overheatValueR")] 
		public inkTextWidgetReference OverheatValueR
		{
			get => GetProperty(ref _overheatValueR);
			set => SetProperty(ref _overheatValueR, value);
		}

		[Ordinal(29)] 
		[RED("leftPartExtra")] 
		public inkImageWidgetReference LeftPartExtra
		{
			get => GetProperty(ref _leftPartExtra);
			set => SetProperty(ref _leftPartExtra, value);
		}

		[Ordinal(30)] 
		[RED("rightPartExtra")] 
		public inkImageWidgetReference RightPartExtra
		{
			get => GetProperty(ref _rightPartExtra);
			set => SetProperty(ref _rightPartExtra, value);
		}

		[Ordinal(31)] 
		[RED("crosshairContainer")] 
		public inkCanvasWidgetReference CrosshairContainer
		{
			get => GetProperty(ref _crosshairContainer);
			set => SetProperty(ref _crosshairContainer, value);
		}

		[Ordinal(32)] 
		[RED("offsetLeftRight")] 
		public CFloat OffsetLeftRight
		{
			get => GetProperty(ref _offsetLeftRight);
			set => SetProperty(ref _offsetLeftRight, value);
		}

		[Ordinal(33)] 
		[RED("offsetLeftRightExtra")] 
		public CFloat OffsetLeftRightExtra
		{
			get => GetProperty(ref _offsetLeftRightExtra);
			set => SetProperty(ref _offsetLeftRightExtra, value);
		}

		[Ordinal(34)] 
		[RED("latchVertical")] 
		public CFloat LatchVertical
		{
			get => GetProperty(ref _latchVertical);
			set => SetProperty(ref _latchVertical, value);
		}

		[Ordinal(35)] 
		[RED("weaponLocalBB")] 
		public CWeakHandle<gameIBlackboard> WeaponLocalBB
		{
			get => GetProperty(ref _weaponLocalBB);
			set => SetProperty(ref _weaponLocalBB, value);
		}

		[Ordinal(36)] 
		[RED("overheatBBID")] 
		public CHandle<redCallbackObject> OverheatBBID
		{
			get => GetProperty(ref _overheatBBID);
			set => SetProperty(ref _overheatBBID, value);
		}

		[Ordinal(37)] 
		[RED("forcedOverheatBBID")] 
		public CHandle<redCallbackObject> ForcedOverheatBBID
		{
			get => GetProperty(ref _forcedOverheatBBID);
			set => SetProperty(ref _forcedOverheatBBID, value);
		}

		[Ordinal(38)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetProperty(ref _targetColorChange);
			set => SetProperty(ref _targetColorChange, value);
		}

		[Ordinal(39)] 
		[RED("forcedCooldownProxy")] 
		public CHandle<inkanimProxy> ForcedCooldownProxy
		{
			get => GetProperty(ref _forcedCooldownProxy);
			set => SetProperty(ref _forcedCooldownProxy, value);
		}

		[Ordinal(40)] 
		[RED("forcedCooldownOptions")] 
		public inkanimPlaybackOptions ForcedCooldownOptions
		{
			get => GetProperty(ref _forcedCooldownOptions);
			set => SetProperty(ref _forcedCooldownOptions, value);
		}
	}
}
