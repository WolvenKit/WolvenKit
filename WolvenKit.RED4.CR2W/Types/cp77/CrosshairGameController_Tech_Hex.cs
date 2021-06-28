using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Tech_Hex : BaseTechCrosshairController
	{
		private wCHandle<inkImageWidget> _leftBracket;
		private wCHandle<inkImageWidget> _rightBracket;
		private wCHandle<inkWidget> _hori;
		private wCHandle<inkWidget> _chargeBar;
		private wCHandle<inkWidget> _ammoLeft;
		private wCHandle<inkWidget> _ammoRight;
		private wCHandle<inkWidget> _ammoLeftFill;
		private wCHandle<inkWidget> _ammoRightFill;
		private wCHandle<inkWidget> _chargeBoth;
		private wCHandle<inkRectangleWidget> _chargeLeftBar;
		private wCHandle<inkRectangleWidget> _chargeRightBar;
		private wCHandle<inkImageWidget> _centerPart;
		private wCHandle<inkWidget> _fluffCanvas;
		private CHandle<inkanimProxy> _chargeAnimationProxy;
		private Vector2 _bufferedSpread;
		private CHandle<gameIBlackboard> _weaponlocalBB;
		private CUInt32 _bbcharge;
		private CUInt32 _bbmagazineAmmoCount;
		private CUInt32 _bbcurrentFireMode;
		private CInt32 _currentAmmo;
		private CInt32 _currentMaxAmmo;
		private CInt32 _maxSupportedAmmo;
		private CEnum<gamedataTriggerMode> _currentFireMode;
		private CUInt32 _bbNPCStatsInfo;
		private CFloat _horizontalMinSpread;
		private CFloat _verticalMinSpread;
		private CFloat _gameplaySpreadMultiplier;
		private CFloat _charge;
		private CFloat _spread;

		[Ordinal(24)] 
		[RED("leftBracket")] 
		public wCHandle<inkImageWidget> LeftBracket
		{
			get => GetProperty(ref _leftBracket);
			set => SetProperty(ref _leftBracket, value);
		}

		[Ordinal(25)] 
		[RED("rightBracket")] 
		public wCHandle<inkImageWidget> RightBracket
		{
			get => GetProperty(ref _rightBracket);
			set => SetProperty(ref _rightBracket, value);
		}

		[Ordinal(26)] 
		[RED("hori")] 
		public wCHandle<inkWidget> Hori
		{
			get => GetProperty(ref _hori);
			set => SetProperty(ref _hori, value);
		}

		[Ordinal(27)] 
		[RED("chargeBar")] 
		public wCHandle<inkWidget> ChargeBar
		{
			get => GetProperty(ref _chargeBar);
			set => SetProperty(ref _chargeBar, value);
		}

		[Ordinal(28)] 
		[RED("ammoLeft")] 
		public wCHandle<inkWidget> AmmoLeft
		{
			get => GetProperty(ref _ammoLeft);
			set => SetProperty(ref _ammoLeft, value);
		}

		[Ordinal(29)] 
		[RED("ammoRight")] 
		public wCHandle<inkWidget> AmmoRight
		{
			get => GetProperty(ref _ammoRight);
			set => SetProperty(ref _ammoRight, value);
		}

		[Ordinal(30)] 
		[RED("ammoLeftFill")] 
		public wCHandle<inkWidget> AmmoLeftFill
		{
			get => GetProperty(ref _ammoLeftFill);
			set => SetProperty(ref _ammoLeftFill, value);
		}

		[Ordinal(31)] 
		[RED("ammoRightFill")] 
		public wCHandle<inkWidget> AmmoRightFill
		{
			get => GetProperty(ref _ammoRightFill);
			set => SetProperty(ref _ammoRightFill, value);
		}

		[Ordinal(32)] 
		[RED("chargeBoth")] 
		public wCHandle<inkWidget> ChargeBoth
		{
			get => GetProperty(ref _chargeBoth);
			set => SetProperty(ref _chargeBoth, value);
		}

		[Ordinal(33)] 
		[RED("chargeLeftBar")] 
		public wCHandle<inkRectangleWidget> ChargeLeftBar
		{
			get => GetProperty(ref _chargeLeftBar);
			set => SetProperty(ref _chargeLeftBar, value);
		}

		[Ordinal(34)] 
		[RED("chargeRightBar")] 
		public wCHandle<inkRectangleWidget> ChargeRightBar
		{
			get => GetProperty(ref _chargeRightBar);
			set => SetProperty(ref _chargeRightBar, value);
		}

		[Ordinal(35)] 
		[RED("centerPart")] 
		public wCHandle<inkImageWidget> CenterPart
		{
			get => GetProperty(ref _centerPart);
			set => SetProperty(ref _centerPart, value);
		}

		[Ordinal(36)] 
		[RED("fluffCanvas")] 
		public wCHandle<inkWidget> FluffCanvas
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
		public CHandle<gameIBlackboard> WeaponlocalBB
		{
			get => GetProperty(ref _weaponlocalBB);
			set => SetProperty(ref _weaponlocalBB, value);
		}

		[Ordinal(40)] 
		[RED("bbcharge")] 
		public CUInt32 Bbcharge
		{
			get => GetProperty(ref _bbcharge);
			set => SetProperty(ref _bbcharge, value);
		}

		[Ordinal(41)] 
		[RED("bbmagazineAmmoCount")] 
		public CUInt32 BbmagazineAmmoCount
		{
			get => GetProperty(ref _bbmagazineAmmoCount);
			set => SetProperty(ref _bbmagazineAmmoCount, value);
		}

		[Ordinal(42)] 
		[RED("bbcurrentFireMode")] 
		public CUInt32 BbcurrentFireMode
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
		public CUInt32 BbNPCStatsInfo
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

		public CrosshairGameController_Tech_Hex(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
