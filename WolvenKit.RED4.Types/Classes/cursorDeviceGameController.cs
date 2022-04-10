using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cursorDeviceGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("bbUIData")] 
		public CWeakHandle<gameIBlackboard> BbUIData
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(3)] 
		[RED("bbWeaponInfo")] 
		public CWeakHandle<gameIBlackboard> BbWeaponInfo
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(4)] 
		[RED("bbWeaponEventId")] 
		public CHandle<redCallbackObject> BbWeaponEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(5)] 
		[RED("bbPlayerTierEventId")] 
		public CHandle<redCallbackObject> BbPlayerTierEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(6)] 
		[RED("interactionBlackboardId")] 
		public CHandle<redCallbackObject> InteractionBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(7)] 
		[RED("upperBodyStateBlackboardId")] 
		public CHandle<redCallbackObject> UpperBodyStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(8)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get => GetPropertyValue<CEnum<GameplayTier>>();
			set => SetPropertyValue<CEnum<GameplayTier>>(value);
		}

		[Ordinal(9)] 
		[RED("upperBodyState")] 
		public CEnum<gamePSMUpperBodyStates> UpperBodyState
		{
			get => GetPropertyValue<CEnum<gamePSMUpperBodyStates>>();
			set => SetPropertyValue<CEnum<gamePSMUpperBodyStates>>(value);
		}

		[Ordinal(10)] 
		[RED("isUnarmed")] 
		public CBool IsUnarmed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("cursorDevice")] 
		public CWeakHandle<inkImageWidget> CursorDevice
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(12)] 
		[RED("fadeOutAnimation")] 
		public CHandle<inkanimDefinition> FadeOutAnimation
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(13)] 
		[RED("fadeInAnimation")] 
		public CHandle<inkanimDefinition> FadeInAnimation
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(14)] 
		[RED("wasLastInteractionWithDevice")] 
		public CBool WasLastInteractionWithDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("interactionDeviceState")] 
		public CBool InteractionDeviceState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public cursorDeviceGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
