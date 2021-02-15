using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Door : InteractiveDevice
	{
		[Ordinal(93)] [RED("animationController")] public CHandle<entAnimationControllerComponent> AnimationController { get; set; }
		[Ordinal(94)] [RED("triggerComponent")] public CHandle<gameStaticTriggerAreaComponent> TriggerComponent { get; set; }
		[Ordinal(95)] [RED("triggerSideOne")] public CHandle<gameStaticTriggerAreaComponent> TriggerSideOne { get; set; }
		[Ordinal(96)] [RED("triggerSideTwo")] public CHandle<gameStaticTriggerAreaComponent> TriggerSideTwo { get; set; }
		[Ordinal(97)] [RED("offMeshConnectionComponent")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent { get; set; }
		[Ordinal(98)] [RED("strongSoloFrame")] public CHandle<entMeshComponent> StrongSoloFrame { get; set; }
		[Ordinal(99)] [RED("terminalNetrunner1")] public CHandle<entMeshComponent> TerminalNetrunner1 { get; set; }
		[Ordinal(100)] [RED("terminalNetrunner2")] public CHandle<entMeshComponent> TerminalNetrunner2 { get; set; }
		[Ordinal(101)] [RED("terminalTechie1")] public CHandle<entMeshComponent> TerminalTechie1 { get; set; }
		[Ordinal(102)] [RED("terminalTechie2")] public CHandle<entMeshComponent> TerminalTechie2 { get; set; }
		[Ordinal(103)] [RED("ledTechie1")] public CHandle<gameLightComponent> LedTechie1 { get; set; }
		[Ordinal(104)] [RED("ledTechie2")] public CHandle<gameLightComponent> LedTechie2 { get; set; }
		[Ordinal(105)] [RED("ledNetrunner1")] public CHandle<gameLightComponent> LedNetrunner1 { get; set; }
		[Ordinal(106)] [RED("ledNetrunner2")] public CHandle<gameLightComponent> LedNetrunner2 { get; set; }
		[Ordinal(107)] [RED("led1")] public CHandle<gameLightComponent> Led1 { get; set; }
		[Ordinal(108)] [RED("led2")] public CHandle<gameLightComponent> Led2 { get; set; }
		[Ordinal(109)] [RED("ledHandle1")] public CHandle<gameLightComponent> LedHandle1 { get; set; }
		[Ordinal(110)] [RED("ledHandle2")] public CHandle<gameLightComponent> LedHandle2 { get; set; }
		[Ordinal(111)] [RED("ledHandle1a")] public CHandle<gameLightComponent> LedHandle1a { get; set; }
		[Ordinal(112)] [RED("ledHandle2a")] public CHandle<gameLightComponent> LedHandle2a { get; set; }
		[Ordinal(113)] [RED("occluder")] public CHandle<entIPlacedComponent> Occluder { get; set; }
		[Ordinal(114)] [RED("portalLight1")] public CHandle<gameLightComponent> PortalLight1 { get; set; }
		[Ordinal(115)] [RED("portalLight2")] public CHandle<gameLightComponent> PortalLight2 { get; set; }
		[Ordinal(116)] [RED("portalLight3")] public CHandle<gameLightComponent> PortalLight3 { get; set; }
		[Ordinal(117)] [RED("portalLight4")] public CHandle<gameLightComponent> PortalLight4 { get; set; }
		[Ordinal(118)] [RED("playerBlocker")] public CHandle<entColliderComponent> PlayerBlocker { get; set; }
		[Ordinal(119)] [RED("animFeatureDoor")] public CHandle<AnimFeatureDoor> AnimFeatureDoor { get; set; }
		[Ordinal(120)] [RED("isVisuallyOpened")] public CBool IsVisuallyOpened { get; set; }
		[Ordinal(121)] [RED("lastDoorSide")] public CInt32 LastDoorSide { get; set; }
		[Ordinal(122)] [RED("bankToLoad_TEMP")] public CString BankToLoad_TEMP { get; set; }
		[Ordinal(123)] [RED("colors")] public LedColors Colors { get; set; }
		[Ordinal(124)] [RED("activeSkillcheckLights")] public CArray<CHandle<gameLightComponent>> ActiveSkillcheckLights { get; set; }
		[Ordinal(125)] [RED("allActiveLights")] public CArray<CHandle<gameLightComponent>> AllActiveLights { get; set; }
		[Ordinal(126)] [RED("closingAnimationLength")] public CFloat ClosingAnimationLength { get; set; }
		[Ordinal(127)] [RED("automaticCloseDelay")] public CFloat AutomaticCloseDelay { get; set; }
		[Ordinal(128)] [RED("doorOpeningType")] public CEnum<EDoorOpeningType> DoorOpeningType { get; set; }
		[Ordinal(129)] [RED("animationType")] public CEnum<EAnimationType> AnimationType { get; set; }
		[Ordinal(130)] [RED("doorTriggerSide")] public CEnum<EDoorTriggerSide> DoorTriggerSide { get; set; }
		[Ordinal(131)] [RED("whoOpened")] public wCHandle<gameObject> WhoOpened { get; set; }
		[Ordinal(132)] [RED("openedUsingForce")] public CBool OpenedUsingForce { get; set; }
		[Ordinal(133)] [RED("illegalOpen")] public CBool IllegalOpen { get; set; }
		[Ordinal(134)] [RED("playerInWorkspot")] public wCHandle<PlayerPuppet> PlayerInWorkspot { get; set; }

		public Door(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
