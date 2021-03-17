using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Simple : gameuiCrosshairBaseGameController
	{
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
		private inkWidgetReference _targetColorChange;
		private inkWidgetReference _middlePart;
		private inkWidgetReference _overheatShake;
		private inkWidgetReference _overheatTL;
		private inkWidgetReference _overheatBL;
		private inkWidgetReference _overheatTR;
		private inkWidgetReference _overheatBR;
		private CHandle<gameIBlackboard> _weaponLocalBB;
		private CUInt32 _onChargeChangeBBID;
		private CHandle<inkanimProxy> _shakeAnimation;
		private CBool _isInForcedCool;

		[Ordinal(18)] 
		[RED("leftPart")] 
		public inkImageWidgetReference LeftPart
		{
			get => GetProperty(ref _leftPart);
			set => SetProperty(ref _leftPart, value);
		}

		[Ordinal(19)] 
		[RED("rightPart")] 
		public inkImageWidgetReference RightPart
		{
			get => GetProperty(ref _rightPart);
			set => SetProperty(ref _rightPart, value);
		}

		[Ordinal(20)] 
		[RED("leftPartExtra")] 
		public inkImageWidgetReference LeftPartExtra
		{
			get => GetProperty(ref _leftPartExtra);
			set => SetProperty(ref _leftPartExtra, value);
		}

		[Ordinal(21)] 
		[RED("rightPartExtra")] 
		public inkImageWidgetReference RightPartExtra
		{
			get => GetProperty(ref _rightPartExtra);
			set => SetProperty(ref _rightPartExtra, value);
		}

		[Ordinal(22)] 
		[RED("offsetLeftRight")] 
		public CFloat OffsetLeftRight
		{
			get => GetProperty(ref _offsetLeftRight);
			set => SetProperty(ref _offsetLeftRight, value);
		}

		[Ordinal(23)] 
		[RED("offsetLeftRightExtra")] 
		public CFloat OffsetLeftRightExtra
		{
			get => GetProperty(ref _offsetLeftRightExtra);
			set => SetProperty(ref _offsetLeftRightExtra, value);
		}

		[Ordinal(24)] 
		[RED("latchVertical")] 
		public CFloat LatchVertical
		{
			get => GetProperty(ref _latchVertical);
			set => SetProperty(ref _latchVertical, value);
		}

		[Ordinal(25)] 
		[RED("topPart")] 
		public inkImageWidgetReference TopPart
		{
			get => GetProperty(ref _topPart);
			set => SetProperty(ref _topPart, value);
		}

		[Ordinal(26)] 
		[RED("bottomPart")] 
		public inkImageWidgetReference BottomPart
		{
			get => GetProperty(ref _bottomPart);
			set => SetProperty(ref _bottomPart, value);
		}

		[Ordinal(27)] 
		[RED("horiPart")] 
		public inkWidgetReference HoriPart
		{
			get => GetProperty(ref _horiPart);
			set => SetProperty(ref _horiPart, value);
		}

		[Ordinal(28)] 
		[RED("vertPart")] 
		public inkWidgetReference VertPart
		{
			get => GetProperty(ref _vertPart);
			set => SetProperty(ref _vertPart, value);
		}

		[Ordinal(29)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetProperty(ref _targetColorChange);
			set => SetProperty(ref _targetColorChange, value);
		}

		[Ordinal(30)] 
		[RED("middlePart")] 
		public inkWidgetReference MiddlePart
		{
			get => GetProperty(ref _middlePart);
			set => SetProperty(ref _middlePart, value);
		}

		[Ordinal(31)] 
		[RED("overheatShake")] 
		public inkWidgetReference OverheatShake
		{
			get => GetProperty(ref _overheatShake);
			set => SetProperty(ref _overheatShake, value);
		}

		[Ordinal(32)] 
		[RED("overheatTL")] 
		public inkWidgetReference OverheatTL
		{
			get => GetProperty(ref _overheatTL);
			set => SetProperty(ref _overheatTL, value);
		}

		[Ordinal(33)] 
		[RED("overheatBL")] 
		public inkWidgetReference OverheatBL
		{
			get => GetProperty(ref _overheatBL);
			set => SetProperty(ref _overheatBL, value);
		}

		[Ordinal(34)] 
		[RED("overheatTR")] 
		public inkWidgetReference OverheatTR
		{
			get => GetProperty(ref _overheatTR);
			set => SetProperty(ref _overheatTR, value);
		}

		[Ordinal(35)] 
		[RED("overheatBR")] 
		public inkWidgetReference OverheatBR
		{
			get => GetProperty(ref _overheatBR);
			set => SetProperty(ref _overheatBR, value);
		}

		[Ordinal(36)] 
		[RED("weaponLocalBB")] 
		public CHandle<gameIBlackboard> WeaponLocalBB
		{
			get => GetProperty(ref _weaponLocalBB);
			set => SetProperty(ref _weaponLocalBB, value);
		}

		[Ordinal(37)] 
		[RED("onChargeChangeBBID")] 
		public CUInt32 OnChargeChangeBBID
		{
			get => GetProperty(ref _onChargeChangeBBID);
			set => SetProperty(ref _onChargeChangeBBID, value);
		}

		[Ordinal(38)] 
		[RED("shakeAnimation")] 
		public CHandle<inkanimProxy> ShakeAnimation
		{
			get => GetProperty(ref _shakeAnimation);
			set => SetProperty(ref _shakeAnimation, value);
		}

		[Ordinal(39)] 
		[RED("isInForcedCool")] 
		public CBool IsInForcedCool
		{
			get => GetProperty(ref _isInForcedCool);
			set => SetProperty(ref _isInForcedCool, value);
		}

		public CrosshairGameController_Simple(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
