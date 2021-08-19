using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cursorDeviceGameController : gameuiWidgetGameController
	{
		private wCHandle<gameIBlackboard> _bbUIData;
		private wCHandle<gameIBlackboard> _bbWeaponInfo;
		private CHandle<redCallbackObject> _bbWeaponEventId;
		private CHandle<redCallbackObject> _bbPlayerTierEventId;
		private CHandle<redCallbackObject> _interactionBlackboardId;
		private CHandle<redCallbackObject> _upperBodyStateBlackboardId;
		private CEnum<GameplayTier> _sceneTier;
		private CEnum<gamePSMUpperBodyStates> _upperBodyState;
		private CBool _isUnarmed;
		private wCHandle<inkImageWidget> _cursorDevice;
		private CHandle<inkanimDefinition> _fadeOutAnimation;
		private CHandle<inkanimDefinition> _fadeInAnimation;
		private CBool _wasLastInteractionWithDevice;
		private CBool _interactionDeviceState;

		[Ordinal(2)] 
		[RED("bbUIData")] 
		public wCHandle<gameIBlackboard> BbUIData
		{
			get => GetProperty(ref _bbUIData);
			set => SetProperty(ref _bbUIData, value);
		}

		[Ordinal(3)] 
		[RED("bbWeaponInfo")] 
		public wCHandle<gameIBlackboard> BbWeaponInfo
		{
			get => GetProperty(ref _bbWeaponInfo);
			set => SetProperty(ref _bbWeaponInfo, value);
		}

		[Ordinal(4)] 
		[RED("bbWeaponEventId")] 
		public CHandle<redCallbackObject> BbWeaponEventId
		{
			get => GetProperty(ref _bbWeaponEventId);
			set => SetProperty(ref _bbWeaponEventId, value);
		}

		[Ordinal(5)] 
		[RED("bbPlayerTierEventId")] 
		public CHandle<redCallbackObject> BbPlayerTierEventId
		{
			get => GetProperty(ref _bbPlayerTierEventId);
			set => SetProperty(ref _bbPlayerTierEventId, value);
		}

		[Ordinal(6)] 
		[RED("interactionBlackboardId")] 
		public CHandle<redCallbackObject> InteractionBlackboardId
		{
			get => GetProperty(ref _interactionBlackboardId);
			set => SetProperty(ref _interactionBlackboardId, value);
		}

		[Ordinal(7)] 
		[RED("upperBodyStateBlackboardId")] 
		public CHandle<redCallbackObject> UpperBodyStateBlackboardId
		{
			get => GetProperty(ref _upperBodyStateBlackboardId);
			set => SetProperty(ref _upperBodyStateBlackboardId, value);
		}

		[Ordinal(8)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get => GetProperty(ref _sceneTier);
			set => SetProperty(ref _sceneTier, value);
		}

		[Ordinal(9)] 
		[RED("upperBodyState")] 
		public CEnum<gamePSMUpperBodyStates> UpperBodyState
		{
			get => GetProperty(ref _upperBodyState);
			set => SetProperty(ref _upperBodyState, value);
		}

		[Ordinal(10)] 
		[RED("isUnarmed")] 
		public CBool IsUnarmed
		{
			get => GetProperty(ref _isUnarmed);
			set => SetProperty(ref _isUnarmed, value);
		}

		[Ordinal(11)] 
		[RED("cursorDevice")] 
		public wCHandle<inkImageWidget> CursorDevice
		{
			get => GetProperty(ref _cursorDevice);
			set => SetProperty(ref _cursorDevice, value);
		}

		[Ordinal(12)] 
		[RED("fadeOutAnimation")] 
		public CHandle<inkanimDefinition> FadeOutAnimation
		{
			get => GetProperty(ref _fadeOutAnimation);
			set => SetProperty(ref _fadeOutAnimation, value);
		}

		[Ordinal(13)] 
		[RED("fadeInAnimation")] 
		public CHandle<inkanimDefinition> FadeInAnimation
		{
			get => GetProperty(ref _fadeInAnimation);
			set => SetProperty(ref _fadeInAnimation, value);
		}

		[Ordinal(14)] 
		[RED("wasLastInteractionWithDevice")] 
		public CBool WasLastInteractionWithDevice
		{
			get => GetProperty(ref _wasLastInteractionWithDevice);
			set => SetProperty(ref _wasLastInteractionWithDevice, value);
		}

		[Ordinal(15)] 
		[RED("interactionDeviceState")] 
		public CBool InteractionDeviceState
		{
			get => GetProperty(ref _interactionDeviceState);
			set => SetProperty(ref _interactionDeviceState, value);
		}

		public cursorDeviceGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
