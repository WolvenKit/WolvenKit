using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrosshairGameController_Tech_Hex : BaseTechCrosshairController
	{
		private CWeakHandle<inkImageWidget> _leftBracket;
		private CWeakHandle<inkImageWidget> _rightBracket;
		private CWeakHandle<inkWidget> _hori;
		private CWeakHandle<inkWidget> _chargeBar;
		private CWeakHandle<inkWidget> _ammoLeft;
		private CWeakHandle<inkWidget> _ammoRight;
		private CWeakHandle<inkWidget> _ammoLeftFill;
		private CWeakHandle<inkWidget> _ammoRightFill;
		private CWeakHandle<inkWidget> _chargeBoth;
		private CWeakHandle<inkRectangleWidget> _chargeLeftBar;
		private CWeakHandle<inkRectangleWidget> _chargeRightBar;
		private CWeakHandle<inkImageWidget> _centerPart;
		private CWeakHandle<inkWidget> _fluffCanvas;
		private CHandle<inkanimProxy> _chargeAnimationProxy;
		private Vector2 _bufferedSpread;
		private CWeakHandle<gameIBlackboard> _weaponlocalBB;
		private CHandle<redCallbackObject> _bbcharge;
		private CHandle<redCallbackObject> _bbmagazineAmmoCount;
		private CHandle<redCallbackObject> _bbcurrentFireMode;
		private CInt32 _currentAmmo;
		private CInt32 _currentMaxAmmo;
		private CInt32 _maxSupportedAmmo;
		private CEnum<gamedataTriggerMode> _currentFireMode;
		private CHandle<redCallbackObject> _bbNPCStatsInfo;
		private CFloat _horizontalMinSpread;
		private CFloat _verticalMinSpread;
		private CFloat _gameplaySpreadMultiplier;
		private CFloat _charge;
		private CFloat _spread;

		[Ordinal(24)] 
		[RED("leftBracket")] 
		public CWeakHandle<inkImageWidget> LeftBracket
		{
			get => GetProperty(ref _leftBracket);
			set => SetProperty(ref _leftBracket, value);
		}

		[Ordinal(25)] 
		[RED("rightBracket")] 
		public CWeakHandle<inkImageWidget> RightBracket
		{
			get => GetProperty(ref _rightBracket);
			set => SetProperty(ref _rightBracket, value);
		}

		[Ordinal(26)] 
		[RED("hori")] 
		public CWeakHandle<inkWidget> Hori
		{
			get => GetProperty(ref _hori);
			set => SetProperty(ref _hori, value);
		}

		[Ordinal(27)] 
		[RED("chargeBar")] 
		public CWeakHandle<inkWidget> ChargeBar
		{
			get => GetProperty(ref _chargeBar);
			set => SetProperty(ref _chargeBar, value);
		}

		[Ordinal(28)] 
		[RED("ammoLeft")] 
		public CWeakHandle<inkWidget> AmmoLeft
		{
			get => GetProperty(ref _ammoLeft);
			set => SetProperty(ref _ammoLeft, value);
		}

		[Ordinal(29)] 
		[RED("ammoRight")] 
		public CWeakHandle<inkWidget> AmmoRight
		{
			get => GetProperty(ref _ammoRight);
			set => SetProperty(ref _ammoRight, value);
		}

		[Ordinal(30)] 
		[RED("ammoLeftFill")] 
		public CWeakHandle<inkWidget> AmmoLeftFill
		{
			get => GetProperty(ref _ammoLeftFill);
			set => SetProperty(ref _ammoLeftFill, value);
		}

		[Ordinal(31)] 
		[RED("ammoRightFill")] 
		public CWeakHandle<inkWidget> AmmoRightFill
		{
			get => GetProperty(ref _ammoRightFill);
			set => SetProperty(ref _ammoRightFill, value);
		}

		[Ordinal(32)] 
		[RED("chargeBoth")] 
		public CWeakHandle<inkWidget> ChargeBoth
		{
			get => GetProperty(ref _chargeBoth);
			set => SetProperty(ref _chargeBoth, value);
		}

		[Ordinal(33)] 
		[RED("chargeLeftBar")] 
		public CWeakHandle<inkRectangleWidget> ChargeLeftBar
		{
			get => GetProperty(ref _chargeLeftBar);
			set => SetProperty(ref _chargeLeftBar, value);
		}

		[Ordinal(34)] 
		[RED("chargeRightBar")] 
		public CWeakHandle<inkRectangleWidget> ChargeRightBar
		{
			get => GetProperty(ref _chargeRightBar);
			set => SetProperty(ref _chargeRightBar, value);
		}

		[Ordinal(35)] 
		[RED("centerPart")] 
		public CWeakHandle<inkImageWidget> CenterPart
		{
			get => GetProperty(ref _centerPart);
			set => SetProperty(ref _centerPart, value);
		}

		[Ordinal(36)] 
		[RED("fluffCanvas")] 
		public CWeakHandle<inkWidget> FluffCanvas
		{
			get => GetProperty(ref _fluffCanvas);
			set => SetProperty(ref _fluffCanvas, value);
		}

		[Ordinal(37)] 
		[RED("chargeAnimationProxy")] 
		public CHandle<inkanimProxy> ChargeAnimationProxy
		{
			get => GetProperty(ref _chargeAnimationProxy);
			set => SetProperty(ref _chargeAnimationProxy, value);
		}

		[Ordinal(38)] 
		[RED("bufferedSpread")] 
		public Vector2 BufferedSpread
		{
			get => GetProperty(ref _bufferedSpread);
			set => SetProperty(ref _bufferedSpread, value);
		}

		[Ordinal(39)] 
		[RED("weaponlocalBB")] 
		public CWeakHandle<gameIBlackboard> WeaponlocalBB
		{
			get => GetProperty(ref _weaponlocalBB);
			set => SetProperty(ref _weaponlocalBB, value);
		}

		[Ordinal(40)] 
		[RED("bbcharge")] 
		public CHandle<redCallbackObject> Bbcharge
		{
			get => GetProperty(ref _bbcharge);
			set => SetProperty(ref _bbcharge, value);
		}

		[Ordinal(41)] 
		[RED("bbmagazineAmmoCount")] 
		public CHandle<redCallbackObject> BbmagazineAmmoCount
		{
			get => GetProperty(ref _bbmagazineAmmoCount);
			set => SetProperty(ref _bbmagazineAmmoCount, value);
		}

		[Ordinal(42)] 
		[RED("bbcurrentFireMode")] 
		public CHandle<redCallbackObject> BbcurrentFireMode
		{
			get => GetProperty(ref _bbcurrentFireMode);
			set => SetProperty(ref _bbcurrentFireMode, value);
		}

		[Ordinal(43)] 
		[RED("currentAmmo")] 
		public CInt32 CurrentAmmo
		{
			get => GetProperty(ref _currentAmmo);
			set => SetProperty(ref _currentAmmo, value);
		}

		[Ordinal(44)] 
		[RED("currentMaxAmmo")] 
		public CInt32 CurrentMaxAmmo
		{
			get => GetProperty(ref _currentMaxAmmo);
			set => SetProperty(ref _currentMaxAmmo, value);
		}

		[Ordinal(45)] 
		[RED("maxSupportedAmmo")] 
		public CInt32 MaxSupportedAmmo
		{
			get => GetProperty(ref _maxSupportedAmmo);
			set => SetProperty(ref _maxSupportedAmmo, value);
		}

		[Ordinal(46)] 
		[RED("currentFireMode")] 
		public CEnum<gamedataTriggerMode> CurrentFireMode
		{
			get => GetProperty(ref _currentFireMode);
			set => SetProperty(ref _currentFireMode, value);
		}

		[Ordinal(47)] 
		[RED("bbNPCStatsInfo")] 
		public CHandle<redCallbackObject> BbNPCStatsInfo
		{
			get => GetProperty(ref _bbNPCStatsInfo);
			set => SetProperty(ref _bbNPCStatsInfo, value);
		}

		[Ordinal(48)] 
		[RED("horizontalMinSpread")] 
		public CFloat HorizontalMinSpread
		{
			get => GetProperty(ref _horizontalMinSpread);
			set => SetProperty(ref _horizontalMinSpread, value);
		}

		[Ordinal(49)] 
		[RED("verticalMinSpread")] 
		public CFloat VerticalMinSpread
		{
			get => GetProperty(ref _verticalMinSpread);
			set => SetProperty(ref _verticalMinSpread, value);
		}

		[Ordinal(50)] 
		[RED("gameplaySpreadMultiplier")] 
		public CFloat GameplaySpreadMultiplier
		{
			get => GetProperty(ref _gameplaySpreadMultiplier);
			set => SetProperty(ref _gameplaySpreadMultiplier, value);
		}

		[Ordinal(51)] 
		[RED("charge")] 
		public CFloat Charge
		{
			get => GetProperty(ref _charge);
			set => SetProperty(ref _charge, value);
		}

		[Ordinal(52)] 
		[RED("spread")] 
		public CFloat Spread
		{
			get => GetProperty(ref _spread);
			set => SetProperty(ref _spread, value);
		}
	}
}
