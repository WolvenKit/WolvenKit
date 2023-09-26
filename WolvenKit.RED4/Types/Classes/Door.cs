using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Door : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetPropertyValue<CHandle<entAnimationControllerComponent>>();
			set => SetPropertyValue<CHandle<entAnimationControllerComponent>>(value);
		}

		[Ordinal(99)] 
		[RED("triggerComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerComponent
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(100)] 
		[RED("triggerSideOne")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerSideOne
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(101)] 
		[RED("triggerSideTwo")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerSideTwo
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(102)] 
		[RED("offMeshConnectionComponent")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent
		{
			get => GetPropertyValue<CHandle<AIOffMeshConnectionComponent>>();
			set => SetPropertyValue<CHandle<AIOffMeshConnectionComponent>>(value);
		}

		[Ordinal(103)] 
		[RED("strongSoloFrame")] 
		public CHandle<entMeshComponent> StrongSoloFrame
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(104)] 
		[RED("terminalNetrunner1")] 
		public CHandle<entMeshComponent> TerminalNetrunner1
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(105)] 
		[RED("terminalNetrunner2")] 
		public CHandle<entMeshComponent> TerminalNetrunner2
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(106)] 
		[RED("terminalTechie1")] 
		public CHandle<entMeshComponent> TerminalTechie1
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(107)] 
		[RED("terminalTechie2")] 
		public CHandle<entMeshComponent> TerminalTechie2
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(108)] 
		[RED("ledTechie1")] 
		public CHandle<gameLightComponent> LedTechie1
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(109)] 
		[RED("ledTechie2")] 
		public CHandle<gameLightComponent> LedTechie2
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(110)] 
		[RED("ledNetrunner1")] 
		public CHandle<gameLightComponent> LedNetrunner1
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(111)] 
		[RED("ledNetrunner2")] 
		public CHandle<gameLightComponent> LedNetrunner2
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(112)] 
		[RED("led1")] 
		public CHandle<gameLightComponent> Led1
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(113)] 
		[RED("led2")] 
		public CHandle<gameLightComponent> Led2
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(114)] 
		[RED("ledHandle1")] 
		public CHandle<gameLightComponent> LedHandle1
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(115)] 
		[RED("ledHandle2")] 
		public CHandle<gameLightComponent> LedHandle2
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(116)] 
		[RED("ledHandle1a")] 
		public CHandle<gameLightComponent> LedHandle1a
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(117)] 
		[RED("ledHandle2a")] 
		public CHandle<gameLightComponent> LedHandle2a
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(118)] 
		[RED("occluder")] 
		public CHandle<entIPlacedComponent> Occluder
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(119)] 
		[RED("portalLight1")] 
		public CHandle<gameLightComponent> PortalLight1
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(120)] 
		[RED("portalLight2")] 
		public CHandle<gameLightComponent> PortalLight2
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(121)] 
		[RED("portalLight3")] 
		public CHandle<gameLightComponent> PortalLight3
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(122)] 
		[RED("portalLight4")] 
		public CHandle<gameLightComponent> PortalLight4
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(123)] 
		[RED("playerBlocker")] 
		public CHandle<entColliderComponent> PlayerBlocker
		{
			get => GetPropertyValue<CHandle<entColliderComponent>>();
			set => SetPropertyValue<CHandle<entColliderComponent>>(value);
		}

		[Ordinal(124)] 
		[RED("animFeatureDoor")] 
		public CHandle<AnimFeatureDoor> AnimFeatureDoor
		{
			get => GetPropertyValue<CHandle<AnimFeatureDoor>>();
			set => SetPropertyValue<CHandle<AnimFeatureDoor>>(value);
		}

		[Ordinal(125)] 
		[RED("isVisuallyOpened")] 
		public CBool IsVisuallyOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(126)] 
		[RED("lastDoorSide")] 
		public CInt32 LastDoorSide
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(127)] 
		[RED("colors")] 
		public LedColors Colors
		{
			get => GetPropertyValue<LedColors>();
			set => SetPropertyValue<LedColors>(value);
		}

		[Ordinal(128)] 
		[RED("activeSkillcheckLights")] 
		public CArray<CHandle<gameLightComponent>> ActiveSkillcheckLights
		{
			get => GetPropertyValue<CArray<CHandle<gameLightComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameLightComponent>>>(value);
		}

		[Ordinal(129)] 
		[RED("allActiveLights")] 
		public CArray<CHandle<gameLightComponent>> AllActiveLights
		{
			get => GetPropertyValue<CArray<CHandle<gameLightComponent>>>();
			set => SetPropertyValue<CArray<CHandle<gameLightComponent>>>(value);
		}

		[Ordinal(130)] 
		[RED("closingAnimationLength")] 
		public CFloat ClosingAnimationLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(131)] 
		[RED("automaticCloseDelay")] 
		public CFloat AutomaticCloseDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(132)] 
		[RED("doorOpeningType")] 
		public CEnum<EDoorOpeningType> DoorOpeningType
		{
			get => GetPropertyValue<CEnum<EDoorOpeningType>>();
			set => SetPropertyValue<CEnum<EDoorOpeningType>>(value);
		}

		[Ordinal(133)] 
		[RED("forceOpeningAudioStimRange")] 
		public CFloat ForceOpeningAudioStimRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(134)] 
		[RED("openingAudioStimRange")] 
		public CFloat OpeningAudioStimRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(135)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetPropertyValue<CEnum<EAnimationType>>();
			set => SetPropertyValue<CEnum<EAnimationType>>(value);
		}

		[Ordinal(136)] 
		[RED("doorTriggerSide")] 
		public CEnum<EDoorTriggerSide> DoorTriggerSide
		{
			get => GetPropertyValue<CEnum<EDoorTriggerSide>>();
			set => SetPropertyValue<CEnum<EDoorTriggerSide>>(value);
		}

		[Ordinal(137)] 
		[RED("whoOpened")] 
		public CWeakHandle<gameObject> WhoOpened
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(138)] 
		[RED("openedUsingForce")] 
		public CBool OpenedUsingForce
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(139)] 
		[RED("illegalOpen")] 
		public CBool IllegalOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(140)] 
		[RED("audioForceOpen")] 
		public CBool AudioForceOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(141)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(142)] 
		[RED("playerInWorkspot")] 
		public CWeakHandle<PlayerPuppet> PlayerInWorkspot
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		public Door()
		{
			ControllerTypeName = "DoorController";
			Colors = new LedColors { Off = new ScriptLightSettings { Color = new CColor() }, Red = new ScriptLightSettings { Color = new CColor() }, Green = new ScriptLightSettings { Color = new CColor() } };
			ActiveSkillcheckLights = new();
			AllActiveLights = new();
			ClosingAnimationLength = 1.100000F;
			AutomaticCloseDelay = 3.000000F;
			ForceOpeningAudioStimRange = 6.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
