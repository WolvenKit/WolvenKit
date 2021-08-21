using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Basic : gameuiCrosshairBaseGameController
	{
		private inkImageWidgetReference _leftPart;
		private inkImageWidgetReference _rightPart;
		private inkImageWidgetReference _upPart;
		private inkImageWidgetReference _downPart;
		private inkImageWidgetReference _centerPart;
		private Vector2 _bufferedSpread;
		private CEnum<gamedataTriggerMode> _currentFireMode;
		private wCHandle<gameIBlackboard> _weaponlocalBB;
		private CHandle<redCallbackObject> _bbcurrentFireMode;
		private CUInt32 _ricochetModeActive;
		private CUInt32 _ricochetChance;
		private CFloat _horizontalMinSpread;
		private CFloat _verticalMinSpread;
		private CFloat _gameplaySpreadMultiplier;

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
		[RED("upPart")] 
		public inkImageWidgetReference UpPart
		{
			get => GetProperty(ref _upPart);
			set => SetProperty(ref _upPart, value);
		}

		[Ordinal(21)] 
		[RED("downPart")] 
		public inkImageWidgetReference DownPart
		{
			get => GetProperty(ref _downPart);
			set => SetProperty(ref _downPart, value);
		}

		[Ordinal(22)] 
		[RED("centerPart")] 
		public inkImageWidgetReference CenterPart
		{
			get => GetProperty(ref _centerPart);
			set => SetProperty(ref _centerPart, value);
		}

		[Ordinal(23)] 
		[RED("bufferedSpread")] 
		public Vector2 BufferedSpread
		{
			get => GetProperty(ref _bufferedSpread);
			set => SetProperty(ref _bufferedSpread, value);
		}

		[Ordinal(24)] 
		[RED("currentFireMode")] 
		public CEnum<gamedataTriggerMode> CurrentFireMode
		{
			get => GetProperty(ref _currentFireMode);
			set => SetProperty(ref _currentFireMode, value);
		}

		[Ordinal(25)] 
		[RED("weaponlocalBB")] 
		public wCHandle<gameIBlackboard> WeaponlocalBB
		{
			get => GetProperty(ref _weaponlocalBB);
			set => SetProperty(ref _weaponlocalBB, value);
		}

		[Ordinal(26)] 
		[RED("bbcurrentFireMode")] 
		public CHandle<redCallbackObject> BbcurrentFireMode
		{
			get => GetProperty(ref _bbcurrentFireMode);
			set => SetProperty(ref _bbcurrentFireMode, value);
		}

		[Ordinal(27)] 
		[RED("ricochetModeActive")] 
		public CUInt32 RicochetModeActive
		{
			get => GetProperty(ref _ricochetModeActive);
			set => SetProperty(ref _ricochetModeActive, value);
		}

		[Ordinal(28)] 
		[RED("RicochetChance")] 
		public CUInt32 RicochetChance
		{
			get => GetProperty(ref _ricochetChance);
			set => SetProperty(ref _ricochetChance, value);
		}

		[Ordinal(29)] 
		[RED("horizontalMinSpread")] 
		public CFloat HorizontalMinSpread
		{
			get => GetProperty(ref _horizontalMinSpread);
			set => SetProperty(ref _horizontalMinSpread, value);
		}

		[Ordinal(30)] 
		[RED("verticalMinSpread")] 
		public CFloat VerticalMinSpread
		{
			get => GetProperty(ref _verticalMinSpread);
			set => SetProperty(ref _verticalMinSpread, value);
		}

		[Ordinal(31)] 
		[RED("gameplaySpreadMultiplier")] 
		public CFloat GameplaySpreadMultiplier
		{
			get => GetProperty(ref _gameplaySpreadMultiplier);
			set => SetProperty(ref _gameplaySpreadMultiplier, value);
		}

		public CrosshairGameController_Basic(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
