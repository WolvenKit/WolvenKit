using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("enableBeingDetectable")] 
		public CBool EnableBeingDetectable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("visibleObject")] 
		public CHandle<senseVisibleObject> VisibleObject
		{
			get => GetPropertyValue<CHandle<senseVisibleObject>>();
			set => SetPropertyValue<CHandle<senseVisibleObject>>(value);
		}

		[Ordinal(7)] 
		[RED("sensorObject")] 
		public CHandle<senseSensorObject> SensorObject
		{
			get => GetPropertyValue<CHandle<senseSensorObject>>();
			set => SetPropertyValue<CHandle<senseSensorObject>>(value);
		}

		[Ordinal(8)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("highLevelCb")] 
		public CHandle<redCallbackObject> HighLevelCb
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(10)] 
		[RED("reactionCb")] 
		public CHandle<redCallbackObject> ReactionCb
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get => GetPropertyValue<CEnum<gamedataNPCHighLevelState>>();
			set => SetPropertyValue<CEnum<gamedataNPCHighLevelState>>(value);
		}

		[Ordinal(12)] 
		[RED("mainPreset")] 
		public TweakDBID MainPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(13)] 
		[RED("secondaryPreset")] 
		public TweakDBID SecondaryPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(14)] 
		[RED("puppetBlackboard")] 
		public CWeakHandle<gameIBlackboard> PuppetBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(15)] 
		[RED("playerTakedownStateCallbackID")] 
		public CHandle<redCallbackObject> PlayerTakedownStateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(16)] 
		[RED("playerUpperBodyStateCallbackID")] 
		public CHandle<redCallbackObject> PlayerUpperBodyStateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(17)] 
		[RED("playerCarryingStateCallbackID")] 
		public CHandle<redCallbackObject> PlayerCarryingStateCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("playerInPerception")] 
		public CWeakHandle<PlayerPuppet> PlayerInPerception
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		public senseComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			EnableBeingDetectable = true;
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
