using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleBaseObject : gameObject
	{
		[Ordinal(36)] 
		[RED("archetype")] 
		public CResourceReference<AIArchetype> Archetype
		{
			get => GetPropertyValue<CResourceReference<AIArchetype>>();
			set => SetPropertyValue<CResourceReference<AIArchetype>>(value);
		}

		[Ordinal(37)] 
		[RED("isVehicleOnStateLocked")] 
		public CBool IsVehicleOnStateLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("vehicleComponent")] 
		public CWeakHandle<VehicleComponent> VehicleComponent
		{
			get => GetPropertyValue<CWeakHandle<VehicleComponent>>();
			set => SetPropertyValue<CWeakHandle<VehicleComponent>>(value);
		}

		[Ordinal(39)] 
		[RED("uiComponent")] 
		public CWeakHandle<WorldWidgetComponent> UiComponent
		{
			get => GetPropertyValue<CWeakHandle<WorldWidgetComponent>>();
			set => SetPropertyValue<CWeakHandle<WorldWidgetComponent>>(value);
		}

		[Ordinal(40)] 
		[RED("crowdMemberComponent")] 
		public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent
		{
			get => GetPropertyValue<CHandle<CrowdMemberBaseComponent>>();
			set => SetPropertyValue<CHandle<CrowdMemberBaseComponent>>(value);
		}

		[Ordinal(41)] 
		[RED("attitudeAgent")] 
		public CHandle<gameAttitudeAgent> AttitudeAgent
		{
			get => GetPropertyValue<CHandle<gameAttitudeAgent>>();
			set => SetPropertyValue<CHandle<gameAttitudeAgent>>(value);
		}

		[Ordinal(42)] 
		[RED("hitTimestamp")] 
		public CFloat HitTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(43)] 
		[RED("drivingTrafficPattern")] 
		public CName DrivingTrafficPattern
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(44)] 
		[RED("onPavement")] 
		public CBool OnPavement
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("inTrafficLane")] 
		public CBool InTrafficLane
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(46)] 
		[RED("timesSentReactionEvent")] 
		public CInt32 TimesSentReactionEvent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(47)] 
		[RED("timesToResendHandleReactionEvent")] 
		public CInt32 TimesToResendHandleReactionEvent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(48)] 
		[RED("hasReactedToStimuli")] 
		public CBool HasReactedToStimuli
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("gotStuckIncrement")] 
		public CInt32 GotStuckIncrement
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(50)] 
		[RED("waitForPassengersToSpawnEventDelayID")] 
		public gameDelayID WaitForPassengersToSpawnEventDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(51)] 
		[RED("triggerPanicDrivingEventDelayID")] 
		public gameDelayID TriggerPanicDrivingEventDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(52)] 
		[RED("reactionTriggerEvent")] 
		public CHandle<HandleReactionEvent> ReactionTriggerEvent
		{
			get => GetPropertyValue<CHandle<HandleReactionEvent>>();
			set => SetPropertyValue<CHandle<HandleReactionEvent>>(value);
		}

		[Ordinal(53)] 
		[RED("fearInside")] 
		public CBool FearInside
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(54)] 
		[RED("vehicleUpsideDown")] 
		public CBool VehicleUpsideDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(55)] 
		[RED("isQhackUploadInProgress")] 
		public CBool IsQhackUploadInProgress
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("currentlyUploadingAction")] 
		public CWeakHandle<ScriptableDeviceAction> CurrentlyUploadingAction
		{
			get => GetPropertyValue<CWeakHandle<ScriptableDeviceAction>>();
			set => SetPropertyValue<CWeakHandle<ScriptableDeviceAction>>(value);
		}

		[Ordinal(57)] 
		[RED("bumpedRecently")] 
		public CInt32 BumpedRecently
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(58)] 
		[RED("bumpTimestamp")] 
		public CFloat BumpTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("minUnconsciousImpact")] 
		public CFloat MinUnconsciousImpact
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(60)] 
		[RED("driverUnconscious")] 
		public CBool DriverUnconscious
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("abandoned")] 
		public CBool Abandoned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleBaseObject()
		{
			WaitForPassengersToSpawnEventDelayID = new gameDelayID();
			TriggerPanicDrivingEventDelayID = new gameDelayID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
