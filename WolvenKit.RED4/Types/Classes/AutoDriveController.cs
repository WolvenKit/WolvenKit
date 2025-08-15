using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AutoDriveController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("inputHintContainer")] 
		public inkWidgetReference InputHintContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("autoDriveContentContainer")] 
		public inkWidgetReference AutoDriveContentContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("countersContainer")] 
		public inkWidgetReference CountersContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("freeRoamHeaderContainer")] 
		public inkWidgetReference FreeRoamHeaderContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("remainingDistanceCounterContainer")] 
		public inkWidgetReference RemainingDistanceCounterContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("remainingDistanceCounterText")] 
		public inkTextWidgetReference RemainingDistanceCounterText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("remainingTimeCounterContainer")] 
		public inkWidgetReference RemainingTimeCounterContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("remainingTimeCounterText")] 
		public inkTextWidgetReference RemainingTimeCounterText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(18)] 
		[RED("autoDriveSystem")] 
		public CWeakHandle<AutoDriveSystem> AutoDriveSystem
		{
			get => GetPropertyValue<CWeakHandle<AutoDriveSystem>>();
			set => SetPropertyValue<CWeakHandle<AutoDriveSystem>>(value);
		}

		[Ordinal(19)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(20)] 
		[RED("autodriveBB")] 
		public CWeakHandle<gameIBlackboard> AutodriveBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(21)] 
		[RED("autodriveBBDef")] 
		public CHandle<UI_AutodriveDataDef> AutodriveBBDef
		{
			get => GetPropertyValue<CHandle<UI_AutodriveDataDef>>();
			set => SetPropertyValue<CHandle<UI_AutodriveDataDef>>(value);
		}

		[Ordinal(22)] 
		[RED("quickslotBB")] 
		public CWeakHandle<gameIBlackboard> QuickslotBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(23)] 
		[RED("quickslotBBDef")] 
		public CHandle<UI_QuickSlotsDataDef> QuickslotBBDef
		{
			get => GetPropertyValue<CHandle<UI_QuickSlotsDataDef>>();
			set => SetPropertyValue<CHandle<UI_QuickSlotsDataDef>>(value);
		}

		[Ordinal(24)] 
		[RED("fakeUpdateProxy")] 
		public CHandle<inkanimProxy> FakeUpdateProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(25)] 
		[RED("autoDriveEnabledCallbackHandle")] 
		public CHandle<redCallbackObject> AutoDriveEnabledCallbackHandle
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(26)] 
		[RED("cinematicCameraCallbackHandle")] 
		public CHandle<redCallbackObject> CinematicCameraCallbackHandle
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(27)] 
		[RED("autoDriveAvailableCallbackHandle")] 
		public CHandle<redCallbackObject> AutoDriveAvailableCallbackHandle
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(28)] 
		[RED("freeRoamEnabledCallbackHandle")] 
		public CHandle<redCallbackObject> FreeRoamEnabledCallbackHandle
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(29)] 
		[RED("radialWheelCallbackHandle")] 
		public CHandle<redCallbackObject> RadialWheelCallbackHandle
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(30)] 
		[RED("playerVehicleStateCallbackHandle")] 
		public CHandle<redCallbackObject> PlayerVehicleStateCallbackHandle
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("q000StartedListenerId")] 
		public CUInt32 Q000StartedListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(32)] 
		[RED("dpadHintsVisibilityEnabledListenerId")] 
		public CUInt32 DpadHintsVisibilityEnabledListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(33)] 
		[RED("remainingDistanceCounterTextParams")] 
		public CHandle<textTextParameterSet> RemainingDistanceCounterTextParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		[Ordinal(34)] 
		[RED("remainingTimeCounterTextParams")] 
		public CHandle<textTextParameterSet> RemainingTimeCounterTextParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		[Ordinal(35)] 
		[RED("inputHintVisibilityAnimProxy")] 
		public CHandle<inkanimProxy> InputHintVisibilityAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(36)] 
		[RED("inputHintVisible")] 
		public CBool InputHintVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("wheelIconAnimProxy")] 
		public CHandle<inkanimProxy> WheelIconAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(38)] 
		[RED("wheelAnimationEnabled")] 
		public CBool WheelAnimationEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("isHoldingDirectionInput")] 
		public CBool IsHoldingDirectionInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("slowCloseAnimProxy")] 
		public CHandle<inkanimProxy> SlowCloseAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(41)] 
		[RED("slowCloseAnimIsReversed")] 
		public CBool SlowCloseAnimIsReversed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("containerAnimProxy")] 
		public CHandle<inkanimProxy> ContainerAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(43)] 
		[RED("containerVisible")] 
		public CBool ContainerVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("containerAnimationPlaying")] 
		public CBool ContainerAnimationPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("rootAnimProxy")] 
		public CHandle<inkanimProxy> RootAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(46)] 
		[RED("rootVisible")] 
		public CBool RootVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("activeDriveType")] 
		public CEnum<AutoDriveDriveType> ActiveDriveType
		{
			get => GetPropertyValue<CEnum<AutoDriveDriveType>>();
			set => SetPropertyValue<CEnum<AutoDriveDriveType>>(value);
		}

		[Ordinal(48)] 
		[RED("headerAnimProxy")] 
		public CHandle<inkanimProxy> HeaderAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(49)] 
		[RED("inputHintDriveTypeAnimProxy")] 
		public CHandle<inkanimProxy> InputHintDriveTypeAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public AutoDriveController()
		{
			InputHintContainer = new inkWidgetReference();
			AutoDriveContentContainer = new inkWidgetReference();
			CountersContainer = new inkWidgetReference();
			FreeRoamHeaderContainer = new inkWidgetReference();
			RemainingDistanceCounterContainer = new inkWidgetReference();
			RemainingDistanceCounterText = new inkTextWidgetReference();
			RemainingTimeCounterContainer = new inkWidgetReference();
			RemainingTimeCounterText = new inkTextWidgetReference();
			GameInstance = new ScriptGameInstance();
			RootVisible = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
