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

		[Ordinal(93)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get
			{
				if (_animationController == null)
				{
					_animationController = (CHandle<entAnimationControllerComponent>) CR2WTypeManager.Create("handle:entAnimationControllerComponent", "animationController", cr2w, this);
				}
				return _animationController;
			}
			set
			{
				if (_animationController == value)
				{
					return;
				}
				_animationController = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("triggerComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerComponent
		{
			get
			{
				if (_triggerComponent == null)
				{
					_triggerComponent = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "triggerComponent", cr2w, this);
				}
				return _triggerComponent;
			}
			set
			{
				if (_triggerComponent == value)
				{
					return;
				}
				_triggerComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("triggerSideOne")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerSideOne
		{
			get
			{
				if (_triggerSideOne == null)
				{
					_triggerSideOne = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "triggerSideOne", cr2w, this);
				}
				return _triggerSideOne;
			}
			set
			{
				if (_triggerSideOne == value)
				{
					return;
				}
				_triggerSideOne = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("triggerSideTwo")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerSideTwo
		{
			get
			{
				if (_triggerSideTwo == null)
				{
					_triggerSideTwo = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "triggerSideTwo", cr2w, this);
				}
				return _triggerSideTwo;
			}
			set
			{
				if (_triggerSideTwo == value)
				{
					return;
				}
				_triggerSideTwo = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("offMeshConnectionComponent")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent
		{
			get
			{
				if (_offMeshConnectionComponent == null)
				{
					_offMeshConnectionComponent = (CHandle<AIOffMeshConnectionComponent>) CR2WTypeManager.Create("handle:AIOffMeshConnectionComponent", "offMeshConnectionComponent", cr2w, this);
				}
				return _offMeshConnectionComponent;
			}
			set
			{
				if (_offMeshConnectionComponent == value)
				{
					return;
				}
				_offMeshConnectionComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("strongSoloFrame")] 
		public CHandle<entMeshComponent> StrongSoloFrame
		{
			get
			{
				if (_strongSoloFrame == null)
				{
					_strongSoloFrame = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "strongSoloFrame", cr2w, this);
				}
				return _strongSoloFrame;
			}
			set
			{
				if (_strongSoloFrame == value)
				{
					return;
				}
				_strongSoloFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("terminalNetrunner1")] 
		public CHandle<entMeshComponent> TerminalNetrunner1
		{
			get
			{
				if (_terminalNetrunner1 == null)
				{
					_terminalNetrunner1 = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "terminalNetrunner1", cr2w, this);
				}
				return _terminalNetrunner1;
			}
			set
			{
				if (_terminalNetrunner1 == value)
				{
					return;
				}
				_terminalNetrunner1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("terminalNetrunner2")] 
		public CHandle<entMeshComponent> TerminalNetrunner2
		{
			get
			{
				if (_terminalNetrunner2 == null)
				{
					_terminalNetrunner2 = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "terminalNetrunner2", cr2w, this);
				}
				return _terminalNetrunner2;
			}
			set
			{
				if (_terminalNetrunner2 == value)
				{
					return;
				}
				_terminalNetrunner2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("terminalTechie1")] 
		public CHandle<entMeshComponent> TerminalTechie1
		{
			get
			{
				if (_terminalTechie1 == null)
				{
					_terminalTechie1 = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "terminalTechie1", cr2w, this);
				}
				return _terminalTechie1;
			}
			set
			{
				if (_terminalTechie1 == value)
				{
					return;
				}
				_terminalTechie1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(102)] 
		[RED("terminalTechie2")] 
		public CHandle<entMeshComponent> TerminalTechie2
		{
			get
			{
				if (_terminalTechie2 == null)
				{
					_terminalTechie2 = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "terminalTechie2", cr2w, this);
				}
				return _terminalTechie2;
			}
			set
			{
				if (_terminalTechie2 == value)
				{
					return;
				}
				_terminalTechie2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(103)] 
		[RED("ledTechie1")] 
		public CHandle<gameLightComponent> LedTechie1
		{
			get
			{
				if (_ledTechie1 == null)
				{
					_ledTechie1 = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "ledTechie1", cr2w, this);
				}
				return _ledTechie1;
			}
			set
			{
				if (_ledTechie1 == value)
				{
					return;
				}
				_ledTechie1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("ledTechie2")] 
		public CHandle<gameLightComponent> LedTechie2
		{
			get
			{
				if (_ledTechie2 == null)
				{
					_ledTechie2 = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "ledTechie2", cr2w, this);
				}
				return _ledTechie2;
			}
			set
			{
				if (_ledTechie2 == value)
				{
					return;
				}
				_ledTechie2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("ledNetrunner1")] 
		public CHandle<gameLightComponent> LedNetrunner1
		{
			get
			{
				if (_ledNetrunner1 == null)
				{
					_ledNetrunner1 = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "ledNetrunner1", cr2w, this);
				}
				return _ledNetrunner1;
			}
			set
			{
				if (_ledNetrunner1 == value)
				{
					return;
				}
				_ledNetrunner1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("ledNetrunner2")] 
		public CHandle<gameLightComponent> LedNetrunner2
		{
			get
			{
				if (_ledNetrunner2 == null)
				{
					_ledNetrunner2 = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "ledNetrunner2", cr2w, this);
				}
				return _ledNetrunner2;
			}
			set
			{
				if (_ledNetrunner2 == value)
				{
					return;
				}
				_ledNetrunner2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("led1")] 
		public CHandle<gameLightComponent> Led1
		{
			get
			{
				if (_led1 == null)
				{
					_led1 = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "led1", cr2w, this);
				}
				return _led1;
			}
			set
			{
				if (_led1 == value)
				{
					return;
				}
				_led1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("led2")] 
		public CHandle<gameLightComponent> Led2
		{
			get
			{
				if (_led2 == null)
				{
					_led2 = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "led2", cr2w, this);
				}
				return _led2;
			}
			set
			{
				if (_led2 == value)
				{
					return;
				}
				_led2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("ledHandle1")] 
		public CHandle<gameLightComponent> LedHandle1
		{
			get
			{
				if (_ledHandle1 == null)
				{
					_ledHandle1 = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "ledHandle1", cr2w, this);
				}
				return _ledHandle1;
			}
			set
			{
				if (_ledHandle1 == value)
				{
					return;
				}
				_ledHandle1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("ledHandle2")] 
		public CHandle<gameLightComponent> LedHandle2
		{
			get
			{
				if (_ledHandle2 == null)
				{
					_ledHandle2 = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "ledHandle2", cr2w, this);
				}
				return _ledHandle2;
			}
			set
			{
				if (_ledHandle2 == value)
				{
					return;
				}
				_ledHandle2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(111)] 
		[RED("ledHandle1a")] 
		public CHandle<gameLightComponent> LedHandle1a
		{
			get
			{
				if (_ledHandle1a == null)
				{
					_ledHandle1a = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "ledHandle1a", cr2w, this);
				}
				return _ledHandle1a;
			}
			set
			{
				if (_ledHandle1a == value)
				{
					return;
				}
				_ledHandle1a = value;
				PropertySet(this);
			}
		}

		[Ordinal(112)] 
		[RED("ledHandle2a")] 
		public CHandle<gameLightComponent> LedHandle2a
		{
			get
			{
				if (_ledHandle2a == null)
				{
					_ledHandle2a = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "ledHandle2a", cr2w, this);
				}
				return _ledHandle2a;
			}
			set
			{
				if (_ledHandle2a == value)
				{
					return;
				}
				_ledHandle2a = value;
				PropertySet(this);
			}
		}

		[Ordinal(113)] 
		[RED("occluder")] 
		public CHandle<entIPlacedComponent> Occluder
		{
			get
			{
				if (_occluder == null)
				{
					_occluder = (CHandle<entIPlacedComponent>) CR2WTypeManager.Create("handle:entIPlacedComponent", "occluder", cr2w, this);
				}
				return _occluder;
			}
			set
			{
				if (_occluder == value)
				{
					return;
				}
				_occluder = value;
				PropertySet(this);
			}
		}

		[Ordinal(114)] 
		[RED("portalLight1")] 
		public CHandle<gameLightComponent> PortalLight1
		{
			get
			{
				if (_portalLight1 == null)
				{
					_portalLight1 = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "portalLight1", cr2w, this);
				}
				return _portalLight1;
			}
			set
			{
				if (_portalLight1 == value)
				{
					return;
				}
				_portalLight1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(115)] 
		[RED("portalLight2")] 
		public CHandle<gameLightComponent> PortalLight2
		{
			get
			{
				if (_portalLight2 == null)
				{
					_portalLight2 = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "portalLight2", cr2w, this);
				}
				return _portalLight2;
			}
			set
			{
				if (_portalLight2 == value)
				{
					return;
				}
				_portalLight2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(116)] 
		[RED("portalLight3")] 
		public CHandle<gameLightComponent> PortalLight3
		{
			get
			{
				if (_portalLight3 == null)
				{
					_portalLight3 = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "portalLight3", cr2w, this);
				}
				return _portalLight3;
			}
			set
			{
				if (_portalLight3 == value)
				{
					return;
				}
				_portalLight3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(117)] 
		[RED("portalLight4")] 
		public CHandle<gameLightComponent> PortalLight4
		{
			get
			{
				if (_portalLight4 == null)
				{
					_portalLight4 = (CHandle<gameLightComponent>) CR2WTypeManager.Create("handle:gameLightComponent", "portalLight4", cr2w, this);
				}
				return _portalLight4;
			}
			set
			{
				if (_portalLight4 == value)
				{
					return;
				}
				_portalLight4 = value;
				PropertySet(this);
			}
		}

		[Ordinal(118)] 
		[RED("playerBlocker")] 
		public CHandle<entColliderComponent> PlayerBlocker
		{
			get
			{
				if (_playerBlocker == null)
				{
					_playerBlocker = (CHandle<entColliderComponent>) CR2WTypeManager.Create("handle:entColliderComponent", "playerBlocker", cr2w, this);
				}
				return _playerBlocker;
			}
			set
			{
				if (_playerBlocker == value)
				{
					return;
				}
				_playerBlocker = value;
				PropertySet(this);
			}
		}

		[Ordinal(119)] 
		[RED("animFeatureDoor")] 
		public CHandle<AnimFeatureDoor> AnimFeatureDoor
		{
			get
			{
				if (_animFeatureDoor == null)
				{
					_animFeatureDoor = (CHandle<AnimFeatureDoor>) CR2WTypeManager.Create("handle:AnimFeatureDoor", "animFeatureDoor", cr2w, this);
				}
				return _animFeatureDoor;
			}
			set
			{
				if (_animFeatureDoor == value)
				{
					return;
				}
				_animFeatureDoor = value;
				PropertySet(this);
			}
		}

		[Ordinal(120)] 
		[RED("isVisuallyOpened")] 
		public CBool IsVisuallyOpened
		{
			get
			{
				if (_isVisuallyOpened == null)
				{
					_isVisuallyOpened = (CBool) CR2WTypeManager.Create("Bool", "isVisuallyOpened", cr2w, this);
				}
				return _isVisuallyOpened;
			}
			set
			{
				if (_isVisuallyOpened == value)
				{
					return;
				}
				_isVisuallyOpened = value;
				PropertySet(this);
			}
		}

		[Ordinal(121)] 
		[RED("lastDoorSide")] 
		public CInt32 LastDoorSide
		{
			get
			{
				if (_lastDoorSide == null)
				{
					_lastDoorSide = (CInt32) CR2WTypeManager.Create("Int32", "lastDoorSide", cr2w, this);
				}
				return _lastDoorSide;
			}
			set
			{
				if (_lastDoorSide == value)
				{
					return;
				}
				_lastDoorSide = value;
				PropertySet(this);
			}
		}

		[Ordinal(122)] 
		[RED("bankToLoad_TEMP")] 
		public CString BankToLoad_TEMP
		{
			get
			{
				if (_bankToLoad_TEMP == null)
				{
					_bankToLoad_TEMP = (CString) CR2WTypeManager.Create("String", "bankToLoad_TEMP", cr2w, this);
				}
				return _bankToLoad_TEMP;
			}
			set
			{
				if (_bankToLoad_TEMP == value)
				{
					return;
				}
				_bankToLoad_TEMP = value;
				PropertySet(this);
			}
		}

		[Ordinal(123)] 
		[RED("colors")] 
		public LedColors Colors
		{
			get
			{
				if (_colors == null)
				{
					_colors = (LedColors) CR2WTypeManager.Create("LedColors", "colors", cr2w, this);
				}
				return _colors;
			}
			set
			{
				if (_colors == value)
				{
					return;
				}
				_colors = value;
				PropertySet(this);
			}
		}

		[Ordinal(124)] 
		[RED("activeSkillcheckLights")] 
		public CArray<CHandle<gameLightComponent>> ActiveSkillcheckLights
		{
			get
			{
				if (_activeSkillcheckLights == null)
				{
					_activeSkillcheckLights = (CArray<CHandle<gameLightComponent>>) CR2WTypeManager.Create("array:handle:gameLightComponent", "activeSkillcheckLights", cr2w, this);
				}
				return _activeSkillcheckLights;
			}
			set
			{
				if (_activeSkillcheckLights == value)
				{
					return;
				}
				_activeSkillcheckLights = value;
				PropertySet(this);
			}
		}

		[Ordinal(125)] 
		[RED("allActiveLights")] 
		public CArray<CHandle<gameLightComponent>> AllActiveLights
		{
			get
			{
				if (_allActiveLights == null)
				{
					_allActiveLights = (CArray<CHandle<gameLightComponent>>) CR2WTypeManager.Create("array:handle:gameLightComponent", "allActiveLights", cr2w, this);
				}
				return _allActiveLights;
			}
			set
			{
				if (_allActiveLights == value)
				{
					return;
				}
				_allActiveLights = value;
				PropertySet(this);
			}
		}

		[Ordinal(126)] 
		[RED("closingAnimationLength")] 
		public CFloat ClosingAnimationLength
		{
			get
			{
				if (_closingAnimationLength == null)
				{
					_closingAnimationLength = (CFloat) CR2WTypeManager.Create("Float", "closingAnimationLength", cr2w, this);
				}
				return _closingAnimationLength;
			}
			set
			{
				if (_closingAnimationLength == value)
				{
					return;
				}
				_closingAnimationLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(127)] 
		[RED("automaticCloseDelay")] 
		public CFloat AutomaticCloseDelay
		{
			get
			{
				if (_automaticCloseDelay == null)
				{
					_automaticCloseDelay = (CFloat) CR2WTypeManager.Create("Float", "automaticCloseDelay", cr2w, this);
				}
				return _automaticCloseDelay;
			}
			set
			{
				if (_automaticCloseDelay == value)
				{
					return;
				}
				_automaticCloseDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(128)] 
		[RED("doorOpeningType")] 
		public CEnum<EDoorOpeningType> DoorOpeningType
		{
			get
			{
				if (_doorOpeningType == null)
				{
					_doorOpeningType = (CEnum<EDoorOpeningType>) CR2WTypeManager.Create("EDoorOpeningType", "doorOpeningType", cr2w, this);
				}
				return _doorOpeningType;
			}
			set
			{
				if (_doorOpeningType == value)
				{
					return;
				}
				_doorOpeningType = value;
				PropertySet(this);
			}
		}

		[Ordinal(129)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get
			{
				if (_animationType == null)
				{
					_animationType = (CEnum<EAnimationType>) CR2WTypeManager.Create("EAnimationType", "animationType", cr2w, this);
				}
				return _animationType;
			}
			set
			{
				if (_animationType == value)
				{
					return;
				}
				_animationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(130)] 
		[RED("doorTriggerSide")] 
		public CEnum<EDoorTriggerSide> DoorTriggerSide
		{
			get
			{
				if (_doorTriggerSide == null)
				{
					_doorTriggerSide = (CEnum<EDoorTriggerSide>) CR2WTypeManager.Create("EDoorTriggerSide", "doorTriggerSide", cr2w, this);
				}
				return _doorTriggerSide;
			}
			set
			{
				if (_doorTriggerSide == value)
				{
					return;
				}
				_doorTriggerSide = value;
				PropertySet(this);
			}
		}

		[Ordinal(131)] 
		[RED("whoOpened")] 
		public wCHandle<gameObject> WhoOpened
		{
			get
			{
				if (_whoOpened == null)
				{
					_whoOpened = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "whoOpened", cr2w, this);
				}
				return _whoOpened;
			}
			set
			{
				if (_whoOpened == value)
				{
					return;
				}
				_whoOpened = value;
				PropertySet(this);
			}
		}

		[Ordinal(132)] 
		[RED("openedUsingForce")] 
		public CBool OpenedUsingForce
		{
			get
			{
				if (_openedUsingForce == null)
				{
					_openedUsingForce = (CBool) CR2WTypeManager.Create("Bool", "openedUsingForce", cr2w, this);
				}
				return _openedUsingForce;
			}
			set
			{
				if (_openedUsingForce == value)
				{
					return;
				}
				_openedUsingForce = value;
				PropertySet(this);
			}
		}

		[Ordinal(133)] 
		[RED("illegalOpen")] 
		public CBool IllegalOpen
		{
			get
			{
				if (_illegalOpen == null)
				{
					_illegalOpen = (CBool) CR2WTypeManager.Create("Bool", "illegalOpen", cr2w, this);
				}
				return _illegalOpen;
			}
			set
			{
				if (_illegalOpen == value)
				{
					return;
				}
				_illegalOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(134)] 
		[RED("playerInWorkspot")] 
		public wCHandle<PlayerPuppet> PlayerInWorkspot
		{
			get
			{
				if (_playerInWorkspot == null)
				{
					_playerInWorkspot = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "playerInWorkspot", cr2w, this);
				}
				return _playerInWorkspot;
			}
			set
			{
				if (_playerInWorkspot == value)
				{
					return;
				}
				_playerInWorkspot = value;
				PropertySet(this);
			}
		}

		public Door(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
