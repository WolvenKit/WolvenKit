using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Door : InteractiveDevice
	{
		private CHandle<entAnimationControllerComponent> _animationController;
		private CHandle<gameStaticTriggerAreaComponent> _triggerComponent;
		private CHandle<gameStaticTriggerAreaComponent> _triggerSideOne;
		private CHandle<gameStaticTriggerAreaComponent> _triggerSideTwo;
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnectionComponent;
		private CHandle<entMeshComponent> _strongSoloFrame;
		private CHandle<entMeshComponent> _terminalNetrunner1;
		private CHandle<entMeshComponent> _terminalNetrunner2;
		private CHandle<entMeshComponent> _terminalTechie1;
		private CHandle<entMeshComponent> _terminalTechie2;
		private CHandle<gameLightComponent> _ledTechie1;
		private CHandle<gameLightComponent> _ledTechie2;
		private CHandle<gameLightComponent> _ledNetrunner1;
		private CHandle<gameLightComponent> _ledNetrunner2;
		private CHandle<gameLightComponent> _led1;
		private CHandle<gameLightComponent> _led2;
		private CHandle<gameLightComponent> _ledHandle1;
		private CHandle<gameLightComponent> _ledHandle2;
		private CHandle<gameLightComponent> _ledHandle1a;
		private CHandle<gameLightComponent> _ledHandle2a;
		private CHandle<entIPlacedComponent> _occluder;
		private CHandle<gameLightComponent> _portalLight1;
		private CHandle<gameLightComponent> _portalLight2;
		private CHandle<gameLightComponent> _portalLight3;
		private CHandle<gameLightComponent> _portalLight4;
		private CHandle<entColliderComponent> _playerBlocker;
		private CHandle<AnimFeatureDoor> _animFeatureDoor;
		private CBool _isVisuallyOpened;
		private CInt32 _lastDoorSide;
		private CString _bankToLoad_TEMP;
		private LedColors _colors;
		private CArray<CHandle<gameLightComponent>> _activeSkillcheckLights;
		private CArray<CHandle<gameLightComponent>> _allActiveLights;
		private CFloat _closingAnimationLength;
		private CFloat _automaticCloseDelay;
		private CEnum<EDoorOpeningType> _doorOpeningType;
		private CEnum<EAnimationType> _animationType;
		private CEnum<EDoorTriggerSide> _doorTriggerSide;
		private wCHandle<gameObject> _whoOpened;
		private CBool _openedUsingForce;
		private CBool _illegalOpen;
		private wCHandle<PlayerPuppet> _playerInWorkspot;

		[Ordinal(96)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetProperty(ref _animationController);
			set => SetProperty(ref _animationController, value);
		}

		[Ordinal(97)] 
		[RED("triggerComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerComponent
		{
			get => GetProperty(ref _triggerComponent);
			set => SetProperty(ref _triggerComponent, value);
		}

		[Ordinal(98)] 
		[RED("triggerSideOne")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerSideOne
		{
			get => GetProperty(ref _triggerSideOne);
			set => SetProperty(ref _triggerSideOne, value);
		}

		[Ordinal(99)] 
		[RED("triggerSideTwo")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerSideTwo
		{
			get => GetProperty(ref _triggerSideTwo);
			set => SetProperty(ref _triggerSideTwo, value);
		}

		[Ordinal(100)] 
		[RED("offMeshConnectionComponent")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent
		{
			get => GetProperty(ref _offMeshConnectionComponent);
			set => SetProperty(ref _offMeshConnectionComponent, value);
		}

		[Ordinal(101)] 
		[RED("strongSoloFrame")] 
		public CHandle<entMeshComponent> StrongSoloFrame
		{
			get => GetProperty(ref _strongSoloFrame);
			set => SetProperty(ref _strongSoloFrame, value);
		}

		[Ordinal(102)] 
		[RED("terminalNetrunner1")] 
		public CHandle<entMeshComponent> TerminalNetrunner1
		{
			get => GetProperty(ref _terminalNetrunner1);
			set => SetProperty(ref _terminalNetrunner1, value);
		}

		[Ordinal(103)] 
		[RED("terminalNetrunner2")] 
		public CHandle<entMeshComponent> TerminalNetrunner2
		{
			get => GetProperty(ref _terminalNetrunner2);
			set => SetProperty(ref _terminalNetrunner2, value);
		}

		[Ordinal(104)] 
		[RED("terminalTechie1")] 
		public CHandle<entMeshComponent> TerminalTechie1
		{
			get => GetProperty(ref _terminalTechie1);
			set => SetProperty(ref _terminalTechie1, value);
		}

		[Ordinal(105)] 
		[RED("terminalTechie2")] 
		public CHandle<entMeshComponent> TerminalTechie2
		{
			get => GetProperty(ref _terminalTechie2);
			set => SetProperty(ref _terminalTechie2, value);
		}

		[Ordinal(106)] 
		[RED("ledTechie1")] 
		public CHandle<gameLightComponent> LedTechie1
		{
			get => GetProperty(ref _ledTechie1);
			set => SetProperty(ref _ledTechie1, value);
		}

		[Ordinal(107)] 
		[RED("ledTechie2")] 
		public CHandle<gameLightComponent> LedTechie2
		{
			get => GetProperty(ref _ledTechie2);
			set => SetProperty(ref _ledTechie2, value);
		}

		[Ordinal(108)] 
		[RED("ledNetrunner1")] 
		public CHandle<gameLightComponent> LedNetrunner1
		{
			get => GetProperty(ref _ledNetrunner1);
			set => SetProperty(ref _ledNetrunner1, value);
		}

		[Ordinal(109)] 
		[RED("ledNetrunner2")] 
		public CHandle<gameLightComponent> LedNetrunner2
		{
			get => GetProperty(ref _ledNetrunner2);
			set => SetProperty(ref _ledNetrunner2, value);
		}

		[Ordinal(110)] 
		[RED("led1")] 
		public CHandle<gameLightComponent> Led1
		{
			get => GetProperty(ref _led1);
			set => SetProperty(ref _led1, value);
		}

		[Ordinal(111)] 
		[RED("led2")] 
		public CHandle<gameLightComponent> Led2
		{
			get => GetProperty(ref _led2);
			set => SetProperty(ref _led2, value);
		}

		[Ordinal(112)] 
		[RED("ledHandle1")] 
		public CHandle<gameLightComponent> LedHandle1
		{
			get => GetProperty(ref _ledHandle1);
			set => SetProperty(ref _ledHandle1, value);
		}

		[Ordinal(113)] 
		[RED("ledHandle2")] 
		public CHandle<gameLightComponent> LedHandle2
		{
			get => GetProperty(ref _ledHandle2);
			set => SetProperty(ref _ledHandle2, value);
		}

		[Ordinal(114)] 
		[RED("ledHandle1a")] 
		public CHandle<gameLightComponent> LedHandle1a
		{
			get => GetProperty(ref _ledHandle1a);
			set => SetProperty(ref _ledHandle1a, value);
		}

		[Ordinal(115)] 
		[RED("ledHandle2a")] 
		public CHandle<gameLightComponent> LedHandle2a
		{
			get => GetProperty(ref _ledHandle2a);
			set => SetProperty(ref _ledHandle2a, value);
		}

		[Ordinal(116)] 
		[RED("occluder")] 
		public CHandle<entIPlacedComponent> Occluder
		{
			get => GetProperty(ref _occluder);
			set => SetProperty(ref _occluder, value);
		}

		[Ordinal(117)] 
		[RED("portalLight1")] 
		public CHandle<gameLightComponent> PortalLight1
		{
			get => GetProperty(ref _portalLight1);
			set => SetProperty(ref _portalLight1, value);
		}

		[Ordinal(118)] 
		[RED("portalLight2")] 
		public CHandle<gameLightComponent> PortalLight2
		{
			get => GetProperty(ref _portalLight2);
			set => SetProperty(ref _portalLight2, value);
		}

		[Ordinal(119)] 
		[RED("portalLight3")] 
		public CHandle<gameLightComponent> PortalLight3
		{
			get => GetProperty(ref _portalLight3);
			set => SetProperty(ref _portalLight3, value);
		}

		[Ordinal(120)] 
		[RED("portalLight4")] 
		public CHandle<gameLightComponent> PortalLight4
		{
			get => GetProperty(ref _portalLight4);
			set => SetProperty(ref _portalLight4, value);
		}

		[Ordinal(121)] 
		[RED("playerBlocker")] 
		public CHandle<entColliderComponent> PlayerBlocker
		{
			get => GetProperty(ref _playerBlocker);
			set => SetProperty(ref _playerBlocker, value);
		}

		[Ordinal(122)] 
		[RED("animFeatureDoor")] 
		public CHandle<AnimFeatureDoor> AnimFeatureDoor
		{
			get => GetProperty(ref _animFeatureDoor);
			set => SetProperty(ref _animFeatureDoor, value);
		}

		[Ordinal(123)] 
		[RED("isVisuallyOpened")] 
		public CBool IsVisuallyOpened
		{
			get => GetProperty(ref _isVisuallyOpened);
			set => SetProperty(ref _isVisuallyOpened, value);
		}

		[Ordinal(124)] 
		[RED("lastDoorSide")] 
		public CInt32 LastDoorSide
		{
			get => GetProperty(ref _lastDoorSide);
			set => SetProperty(ref _lastDoorSide, value);
		}

		[Ordinal(125)] 
		[RED("bankToLoad_TEMP")] 
		public CString BankToLoad_TEMP
		{
			get => GetProperty(ref _bankToLoad_TEMP);
			set => SetProperty(ref _bankToLoad_TEMP, value);
		}

		[Ordinal(126)] 
		[RED("colors")] 
		public LedColors Colors
		{
			get => GetProperty(ref _colors);
			set => SetProperty(ref _colors, value);
		}

		[Ordinal(127)] 
		[RED("activeSkillcheckLights")] 
		public CArray<CHandle<gameLightComponent>> ActiveSkillcheckLights
		{
			get => GetProperty(ref _activeSkillcheckLights);
			set => SetProperty(ref _activeSkillcheckLights, value);
		}

		[Ordinal(128)] 
		[RED("allActiveLights")] 
		public CArray<CHandle<gameLightComponent>> AllActiveLights
		{
			get => GetProperty(ref _allActiveLights);
			set => SetProperty(ref _allActiveLights, value);
		}

		[Ordinal(129)] 
		[RED("closingAnimationLength")] 
		public CFloat ClosingAnimationLength
		{
			get => GetProperty(ref _closingAnimationLength);
			set => SetProperty(ref _closingAnimationLength, value);
		}

		[Ordinal(130)] 
		[RED("automaticCloseDelay")] 
		public CFloat AutomaticCloseDelay
		{
			get => GetProperty(ref _automaticCloseDelay);
			set => SetProperty(ref _automaticCloseDelay, value);
		}

		[Ordinal(131)] 
		[RED("doorOpeningType")] 
		public CEnum<EDoorOpeningType> DoorOpeningType
		{
			get => GetProperty(ref _doorOpeningType);
			set => SetProperty(ref _doorOpeningType, value);
		}

		[Ordinal(132)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetProperty(ref _animationType);
			set => SetProperty(ref _animationType, value);
		}

		[Ordinal(133)] 
		[RED("doorTriggerSide")] 
		public CEnum<EDoorTriggerSide> DoorTriggerSide
		{
			get => GetProperty(ref _doorTriggerSide);
			set => SetProperty(ref _doorTriggerSide, value);
		}

		[Ordinal(134)] 
		[RED("whoOpened")] 
		public wCHandle<gameObject> WhoOpened
		{
			get => GetProperty(ref _whoOpened);
			set => SetProperty(ref _whoOpened, value);
		}

		[Ordinal(135)] 
		[RED("openedUsingForce")] 
		public CBool OpenedUsingForce
		{
			get => GetProperty(ref _openedUsingForce);
			set => SetProperty(ref _openedUsingForce, value);
		}

		[Ordinal(136)] 
		[RED("illegalOpen")] 
		public CBool IllegalOpen
		{
			get => GetProperty(ref _illegalOpen);
			set => SetProperty(ref _illegalOpen, value);
		}

		[Ordinal(137)] 
		[RED("playerInWorkspot")] 
		public wCHandle<PlayerPuppet> PlayerInWorkspot
		{
			get => GetProperty(ref _playerInWorkspot);
			set => SetProperty(ref _playerInWorkspot, value);
		}

		public Door(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
