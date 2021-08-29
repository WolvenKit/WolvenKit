using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class megatronCrosshairGameController : gameuiWidgetGameController
	{
		private CHandle<redCallbackObject> _bulletSpreedBlackboardId;
		private CHandle<redCallbackObject> _crosshairStateBlackboardId;
		private CWeakHandle<inkImageWidget> _leftPart;
		private CWeakHandle<inkImageWidget> _rightPart;
		private CWeakHandle<inkImageWidget> _nearCenterPart;
		private CWeakHandle<inkImageWidget> _farCenterPart;
		private Vector2 _bufferedSpread;
		private Vector2 _orgSideSize;
		private CFloat _minSpread;
		private CFloat _gameplaySpreadMultiplier;
		private CEnum<gamePSMCrosshairStates> _crosshairState;

		[Ordinal(2)] 
		[RED("bulletSpreedBlackboardId")] 
		public CHandle<redCallbackObject> BulletSpreedBlackboardId
		{
			get => GetProperty(ref _bulletSpreedBlackboardId);
			set => SetProperty(ref _bulletSpreedBlackboardId, value);
		}

		[Ordinal(3)] 
		[RED("crosshairStateBlackboardId")] 
		public CHandle<redCallbackObject> CrosshairStateBlackboardId
		{
			get => GetProperty(ref _crosshairStateBlackboardId);
			set => SetProperty(ref _crosshairStateBlackboardId, value);
		}

		[Ordinal(4)] 
		[RED("leftPart")] 
		public CWeakHandle<inkImageWidget> LeftPart
		{
			get => GetProperty(ref _leftPart);
			set => SetProperty(ref _leftPart, value);
		}

		[Ordinal(5)] 
		[RED("rightPart")] 
		public CWeakHandle<inkImageWidget> RightPart
		{
			get => GetProperty(ref _rightPart);
			set => SetProperty(ref _rightPart, value);
		}

		[Ordinal(6)] 
		[RED("nearCenterPart")] 
		public CWeakHandle<inkImageWidget> NearCenterPart
		{
			get => GetProperty(ref _nearCenterPart);
			set => SetProperty(ref _nearCenterPart, value);
		}

		[Ordinal(7)] 
		[RED("farCenterPart")] 
		public CWeakHandle<inkImageWidget> FarCenterPart
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
		[RED("orgSideSize")] 
		public Vector2 OrgSideSize
		{
			get => GetProperty(ref _orgSideSize);
			set => SetProperty(ref _orgSideSize, value);
		}

		[Ordinal(10)] 
		[RED("minSpread")] 
		public CFloat MinSpread
		{
			get => GetProperty(ref _minSpread);
			set => SetProperty(ref _minSpread, value);
		}

		[Ordinal(11)] 
		[RED("gameplaySpreadMultiplier")] 
		public CFloat GameplaySpreadMultiplier
		{
			get => GetProperty(ref _gameplaySpreadMultiplier);
			set => SetProperty(ref _gameplaySpreadMultiplier, value);
		}

		[Ordinal(12)] 
		[RED("crosshairState")] 
		public CEnum<gamePSMCrosshairStates> CrosshairState
		{
			get => GetProperty(ref _crosshairState);
			set => SetProperty(ref _crosshairState, value);
		}
	}
}
