using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class megatronCrosshairGameController : gameuiWidgetGameController
	{
		private CUInt32 _bulletSpreedBlackboardId;
		private CUInt32 _crosshairStateBlackboardId;
		private wCHandle<inkImageWidget> _leftPart;
		private wCHandle<inkImageWidget> _rightPart;
		private wCHandle<inkImageWidget> _nearCenterPart;
		private wCHandle<inkImageWidget> _farCenterPart;
		private Vector2 _bufferedSpread;
		private CHandle<gameIBlackboard> _weaponlocalBB;
		private Vector2 _orgSideSize;
		private CFloat _minSpread;
		private CFloat _gameplaySpreadMultiplier;
		private CEnum<gamePSMCrosshairStates> _crosshairState;

		[Ordinal(2)] 
		[RED("bulletSpreedBlackboardId")] 
		public CUInt32 BulletSpreedBlackboardId
		{
			get => GetProperty(ref _bulletSpreedBlackboardId);
			set => SetProperty(ref _bulletSpreedBlackboardId, value);
		}

		[Ordinal(3)] 
		[RED("crosshairStateBlackboardId")] 
		public CUInt32 CrosshairStateBlackboardId
		{
			get => GetProperty(ref _crosshairStateBlackboardId);
			set => SetProperty(ref _crosshairStateBlackboardId, value);
		}

		[Ordinal(4)] 
		[RED("leftPart")] 
		public wCHandle<inkImageWidget> LeftPart
		{
			get => GetProperty(ref _leftPart);
			set => SetProperty(ref _leftPart, value);
		}

		[Ordinal(5)] 
		[RED("rightPart")] 
		public wCHandle<inkImageWidget> RightPart
		{
			get => GetProperty(ref _rightPart);
			set => SetProperty(ref _rightPart, value);
		}

		[Ordinal(6)] 
		[RED("nearCenterPart")] 
		public wCHandle<inkImageWidget> NearCenterPart
		{
			get => GetProperty(ref _nearCenterPart);
			set => SetProperty(ref _nearCenterPart, value);
		}

		[Ordinal(7)] 
		[RED("farCenterPart")] 
		public wCHandle<inkImageWidget> FarCenterPart
		{
			get => GetProperty(ref _farCenterPart);
			set => SetProperty(ref _farCenterPart, value);
		}

		[Ordinal(8)] 
		[RED("bufferedSpread")] 
		public Vector2 BufferedSpread
		{
			get => GetProperty(ref _bufferedSpread);
			set => SetProperty(ref _bufferedSpread, value);
		}

		[Ordinal(9)] 
		[RED("weaponlocalBB")] 
		public CHandle<gameIBlackboard> WeaponlocalBB
		{
			get => GetProperty(ref _weaponlocalBB);
			set => SetProperty(ref _weaponlocalBB, value);
		}

		[Ordinal(10)] 
		[RED("orgSideSize")] 
		public Vector2 OrgSideSize
		{
			get => GetProperty(ref _orgSideSize);
			set => SetProperty(ref _orgSideSize, value);
		}

		[Ordinal(11)] 
		[RED("minSpread")] 
		public CFloat MinSpread
		{
			get => GetProperty(ref _minSpread);
			set => SetProperty(ref _minSpread, value);
		}

		[Ordinal(12)] 
		[RED("gameplaySpreadMultiplier")] 
		public CFloat GameplaySpreadMultiplier
		{
			get => GetProperty(ref _gameplaySpreadMultiplier);
			set => SetProperty(ref _gameplaySpreadMultiplier, value);
		}

		[Ordinal(13)] 
		[RED("crosshairState")] 
		public CEnum<gamePSMCrosshairStates> CrosshairState
		{
			get => GetProperty(ref _crosshairState);
			set => SetProperty(ref _crosshairState, value);
		}

		public megatronCrosshairGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
