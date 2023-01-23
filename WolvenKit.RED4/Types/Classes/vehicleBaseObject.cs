using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleBaseObject : gameObject
	{
		[Ordinal(35)] 
		[RED("archetype")] 
		public CResourceReference<AIArchetype> Archetype
		{
			get => GetPropertyValue<CResourceReference<AIArchetype>>();
			set => SetPropertyValue<CResourceReference<AIArchetype>>(value);
		}

		[Ordinal(36)] 
		[RED("vehicleComponent")] 
		public CWeakHandle<VehicleComponent> VehicleComponent
		{
			get => GetPropertyValue<CWeakHandle<VehicleComponent>>();
			set => SetPropertyValue<CWeakHandle<VehicleComponent>>(value);
		}

		[Ordinal(37)] 
		[RED("uiComponent")] 
		public CWeakHandle<WorldWidgetComponent> UiComponent
		{
			get => GetPropertyValue<CWeakHandle<WorldWidgetComponent>>();
			set => SetPropertyValue<CWeakHandle<WorldWidgetComponent>>(value);
		}

		[Ordinal(38)] 
		[RED("crowdMemberComponent")] 
		public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent
		{
			get => GetPropertyValue<CHandle<CrowdMemberBaseComponent>>();
			set => SetPropertyValue<CHandle<CrowdMemberBaseComponent>>(value);
		}

		[Ordinal(39)] 
		[RED("hitTimestamp")] 
		public CFloat HitTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(40)] 
		[RED("drivingTrafficPattern")] 
		public CName DrivingTrafficPattern
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(41)] 
		[RED("onPavement")] 
		public CBool OnPavement
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("inTrafficLane")] 
		public CBool InTrafficLane
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("timesSentReactionEvent")] 
		public CInt32 TimesSentReactionEvent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(44)] 
		[RED("timesToResendHandleReactionEvent")] 
		public CInt32 TimesToResendHandleReactionEvent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(45)] 
		[RED("hasReactedToStimuli")] 
		public CBool HasReactedToStimuli
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(46)] 
		[RED("isPrevention")] 
		public CBool IsPrevention
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("gotStuckIncrement")] 
		public CInt32 GotStuckIncrement
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(48)] 
		[RED("waitForPassengersToSpawnEventDelayID")] 
		public gameDelayID WaitForPassengersToSpawnEventDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(49)] 
		[RED("triggerPanicDrivingEventDelayID")] 
		public gameDelayID TriggerPanicDrivingEventDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(50)] 
		[RED("reactionTriggerEvent")] 
		public CHandle<HandleReactionEvent> ReactionTriggerEvent
		{
			get => GetPropertyValue<CHandle<HandleReactionEvent>>();
			set => SetPropertyValue<CHandle<HandleReactionEvent>>(value);
		}

		[Ordinal(51)] 
		[RED("fearInside")] 
		public CBool FearInside
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(52)] 
		[RED("vehicleUpsideDown")] 
		public CBool VehicleUpsideDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("bumpedRecently")] 
		public CInt32 BumpedRecently
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(54)] 
		[RED("bumpTimestamp")] 
		public CFloat BumpTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("minUnconsciousImpact")] 
		public CFloat MinUnconsciousImpact
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(56)] 
		[RED("driverUnconscious")] 
		public CBool DriverUnconscious
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(57)] 
		[RED("abandoned")] 
		public CBool Abandoned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleBaseObject()
		{
			WaitForPassengersToSpawnEventDelayID = new();
			TriggerPanicDrivingEventDelayID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
