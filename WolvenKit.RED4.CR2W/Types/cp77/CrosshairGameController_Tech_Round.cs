using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Tech_Round : BaseTechCrosshairController
	{
		private wCHandle<inkWidget> _root;
		private inkImageWidgetReference _leftPart;
		private inkImageWidgetReference _rightPart;
		private CFloat _offsetLeftRight;
		private CFloat _offsetLeftRightExtra;
		private CFloat _latchVertical;
		private inkImageWidgetReference _topPart;
		private inkImageWidgetReference _bottomPart;
		private inkWidgetReference _horiPart;
		private inkWidgetReference _vertPart;
		private wCHandle<inkCanvasWidget> _chargeBar;
		private wCHandle<inkRectangleWidget> _chargeBarFG;
		private wCHandle<inkRectangleWidget> _chargeBarBG;
		private wCHandle<inkRectangleWidget> _chargeBarMG;
		private wCHandle<inkWidget> _centerPart;
		private wCHandle<inkWidget> _bottom_hip_bar;
		private wCHandle<inkTextWidget> _realFluffText_1;
		private wCHandle<inkTextWidget> _realFluffText_2;
		private Vector2 _bufferedSpread;
		private CHandle<gameIBlackboard> _weaponlocalBB;
		private CUInt32 _bbcharge;
		private CUInt32 _bbmagazineAmmoCapacity;
		private CUInt32 _bbmagazineAmmoCount;
		private CUInt32 _bbcurrentFireMode;
		private CInt32 _currentAmmo;
		private CInt32 _currentMaxAmmo;
		private CInt32 _maxSupportedAmmo;
		private CEnum<gamedataTriggerMode> _currentFireMode;
		private Vector2 _orgSideSize;
		private CFloat _sidesScale;
		private CUInt32 _bbNPCStatsInfo;
		private CUInt32 _currentObstructedTargetBBID;
		private wCHandle<gameObject> _potentialVisibleTarget;
		private wCHandle<gameObject> _potentialObstructedTarget;
		private CBool _useVisibleTarget;
		private CFloat _horizontalMinSpread;
		private CFloat _verticalMinSpread;
		private CFloat _gameplaySpreadMultiplier;
		private CHandle<inkanimProxy> _chargeAnimationProxy;
		private CFloat _spreadRA;

		[Ordinal(24)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(25)] 
		[RED("leftPart")] 
		public inkImageWidgetReference LeftPart
		{
			get => GetProperty(ref _leftPart);
			set => SetProperty(ref _leftPart, value);
		}

		[Ordinal(26)] 
		[RED("rightPart")] 
		public inkImageWidgetReference RightPart
		{
			get => GetProperty(ref _rightPart);
			set => SetProperty(ref _rightPart, value);
		}

		[Ordinal(27)] 
		[RED("offsetLeftRight")] 
		public CFloat OffsetLeftRight
		{
			get => GetProperty(ref _offsetLeftRight);
			set => SetProperty(ref _offsetLeftRight, value);
		}

		[Ordinal(28)] 
		[RED("offsetLeftRightExtra")] 
		public CFloat OffsetLeftRightExtra
		{
			get => GetProperty(ref _offsetLeftRightExtra);
			set => SetProperty(ref _offsetLeftRightExtra, value);
		}

		[Ordinal(29)] 
		[RED("latchVertical")] 
		public CFloat LatchVertical
		{
			get => GetProperty(ref _latchVertical);
			set => SetProperty(ref _latchVertical, value);
		}

		[Ordinal(30)] 
		[RED("topPart")] 
		public inkImageWidgetReference TopPart
		{
			get => GetProperty(ref _topPart);
			set => SetProperty(ref _topPart, value);
		}

		[Ordinal(31)] 
		[RED("bottomPart")] 
		public inkImageWidgetReference BottomPart
		{
			get => GetProperty(ref _bottomPart);
			set => SetProperty(ref _bottomPart, value);
		}

		[Ordinal(32)] 
		[RED("horiPart")] 
		public inkWidgetReference HoriPart
		{
			get => GetProperty(ref _horiPart);
			set => SetProperty(ref _horiPart, value);
		}

		[Ordinal(33)] 
		[RED("vertPart")] 
		public inkWidgetReference VertPart
		{
			get => GetProperty(ref _vertPart);
			set => SetProperty(ref _vertPart, value);
		}

		[Ordinal(34)] 
		[RED("chargeBar")] 
		public wCHandle<inkCanvasWidget> ChargeBar
		{
			get => GetProperty(ref _chargeBar);
			set => SetProperty(ref _chargeBar, value);
		}

		[Ordinal(35)] 
		[RED("chargeBarFG")] 
		public wCHandle<inkRectangleWidget> ChargeBarFG
		{
			get => GetProperty(ref _chargeBarFG);
			set => SetProperty(ref _chargeBarFG, value);
		}

		[Ordinal(36)] 
		[RED("chargeBarBG")] 
		public wCHandle<inkRectangleWidget> ChargeBarBG
		{
			get => GetProperty(ref _chargeBarBG);
			set => SetProperty(ref _chargeBarBG, value);
		}

		[Ordinal(37)] 
		[RED("chargeBarMG")] 
		public wCHandle<inkRectangleWidget> ChargeBarMG
		{
			get => GetProperty(ref _chargeBarMG);
			set => SetProperty(ref _chargeBarMG, value);
		}

		[Ordinal(38)] 
		[RED("centerPart")] 
		public wCHandle<inkWidget> CenterPart
		{
			get => GetProperty(ref _centerPart);
			set => SetProperty(ref _centerPart, value);
		}

		[Ordinal(39)] 
		[RED("bottom_hip_bar")] 
		public wCHandle<inkWidget> Bottom_hip_bar
		{
			get => GetProperty(ref _bottom_hip_bar);
			set => SetProperty(ref _bottom_hip_bar, value);
		}

		[Ordinal(40)] 
		[RED("realFluffText_1")] 
		public wCHandle<inkTextWidget> RealFluffText_1
		{
			get => GetProperty(ref _realFluffText_1);
			set => SetProperty(ref _realFluffText_1, value);
		}

		[Ordinal(41)] 
		[RED("realFluffText_2")] 
		public wCHandle<inkTextWidget> RealFluffText_2
		{
			get => GetProperty(ref _realFluffText_2);
			set => SetProperty(ref _realFluffText_2, value);
		}

		[Ordinal(42)] 
		[RED("bufferedSpread")] 
		public Vector2 BufferedSpread
		{
			get => GetProperty(ref _bufferedSpread);
			set => SetProperty(ref _bufferedSpread, value);
		}

		[Ordinal(43)] 
		[RED("weaponlocalBB")] 
		public CHandle<gameIBlackboard> WeaponlocalBB
		{
			get => GetProperty(ref _weaponlocalBB);
			set => SetProperty(ref _weaponlocalBB, value);
		}

		[Ordinal(44)] 
		[RED("bbcharge")] 
		public CUInt32 Bbcharge
		{
			get => GetProperty(ref _bbcharge);
			set => SetProperty(ref _bbcharge, value);
		}

		[Ordinal(45)] 
		[RED("bbmagazineAmmoCapacity")] 
		public CUInt32 BbmagazineAmmoCapacity
		{
			get => GetProperty(ref _bbmagazineAmmoCapacity);
			set => SetProperty(ref _bbmagazineAmmoCapacity, value);
		}

		[Ordinal(46)] 
		[RED("bbmagazineAmmoCount")] 
		public CUInt32 BbmagazineAmmoCount
		{
			get => GetProperty(ref _bbmagazineAmmoCount);
			set => SetProperty(ref _bbmagazineAmmoCount, value);
		}

		[Ordinal(47)] 
		[RED("bbcurrentFireMode")] 
		public CUInt32 BbcurrentFireMode
		{
			get => GetProperty(ref _bbcurrentFireMode);
			set => SetProperty(ref _bbcurrentFireMode, value);
		}

		[Ordinal(48)] 
		[RED("currentAmmo")] 
		public CInt32 CurrentAmmo
		{
			get => GetProperty(ref _currentAmmo);
			set => SetProperty(ref _currentAmmo, value);
		}

		[Ordinal(49)] 
		[RED("currentMaxAmmo")] 
		public CInt32 CurrentMaxAmmo
		{
			get => GetProperty(ref _currentMaxAmmo);
			set => SetProperty(ref _currentMaxAmmo, value);
		}

		[Ordinal(50)] 
		[RED("maxSupportedAmmo")] 
		public CInt32 MaxSupportedAmmo
		{
			get => GetProperty(ref _maxSupportedAmmo);
			set => SetProperty(ref _maxSupportedAmmo, value);
		}

		[Ordinal(51)] 
		[RED("currentFireMode")] 
		public CEnum<gamedataTriggerMode> CurrentFireMode
		{
			get => GetProperty(ref _currentFireMode);
			set => SetProperty(ref _currentFireMode, value);
		}

		[Ordinal(52)] 
		[RED("orgSideSize")] 
		public Vector2 OrgSideSize
		{
			get => GetProperty(ref _orgSideSize);
			set => SetProperty(ref _orgSideSize, value);
		}

		[Ordinal(53)] 
		[RED("sidesScale")] 
		public CFloat SidesScale
		{
			get => GetProperty(ref _sidesScale);
			set => SetProperty(ref _sidesScale, value);
		}

		[Ordinal(54)] 
		[RED("bbNPCStatsInfo")] 
		public CUInt32 BbNPCStatsInfo
		{
			get => GetProperty(ref _bbNPCStatsInfo);
			set => SetProperty(ref _bbNPCStatsInfo, value);
		}

		[Ordinal(55)] 
		[RED("currentObstructedTargetBBID")] 
		public CUInt32 CurrentObstructedTargetBBID
		{
			get => GetProperty(ref _currentObstructedTargetBBID);
			set => SetProperty(ref _currentObstructedTargetBBID, value);
		}

		[Ordinal(56)] 
		[RED("potentialVisibleTarget")] 
		public wCHandle<gameObject> PotentialVisibleTarget
		{
			get => GetProperty(ref _potentialVisibleTarget);
			set => SetProperty(ref _potentialVisibleTarget, value);
		}

		[Ordinal(57)] 
		[RED("potentialObstructedTarget")] 
		public wCHandle<gameObject> PotentialObstructedTarget
		{
			get => GetProperty(ref _potentialObstructedTarget);
			set => SetProperty(ref _potentialObstructedTarget, value);
		}

		[Ordinal(58)] 
		[RED("useVisibleTarget")] 
		public CBool UseVisibleTarget
		{
			get => GetProperty(ref _useVisibleTarget);
			set => SetProperty(ref _useVisibleTarget, value);
		}

		[Ordinal(59)] 
		[RED("horizontalMinSpread")] 
		public CFloat HorizontalMinSpread
		{
			get => GetProperty(ref _horizontalMinSpread);
			set => SetProperty(ref _horizontalMinSpread, value);
		}

		[Ordinal(60)] 
		[RED("verticalMinSpread")] 
		public CFloat VerticalMinSpread
		{
			get => GetProperty(ref _verticalMinSpread);
			set => SetProperty(ref _verticalMinSpread, value);
		}

		[Ordinal(61)] 
		[RED("gameplaySpreadMultiplier")] 
		public CFloat GameplaySpreadMultiplier
		{
			get => GetProperty(ref _gameplaySpreadMultiplier);
			set => SetProperty(ref _gameplaySpreadMultiplier, value);
		}

		[Ordinal(62)] 
		[RED("chargeAnimationProxy")] 
		public CHandle<inkanimProxy> ChargeAnimationProxy
		{
			get => GetProperty(ref _chargeAnimationProxy);
			set => SetProperty(ref _chargeAnimationProxy, value);
		}

		[Ordinal(63)] 
		[RED("spreadRA")] 
		public CFloat SpreadRA
		{
			get => GetProperty(ref _spreadRA);
			set => SetProperty(ref _spreadRA, value);
		}

		public CrosshairGameController_Tech_Round(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
