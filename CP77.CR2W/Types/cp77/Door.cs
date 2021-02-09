using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Door : InteractiveDevice
	{
		[Ordinal(3)]  [RED("bankToLoad_TEMP")] public CString BankToLoad_TEMP { get; set; }
		[Ordinal(85)]  [RED("animationController")] public CHandle<entAnimationControllerComponent> AnimationController { get; set; }
		[Ordinal(86)]  [RED("triggerComponent")] public CHandle<gameStaticTriggerAreaComponent> TriggerComponent { get; set; }
		[Ordinal(87)]  [RED("triggerSideOne")] public CHandle<gameStaticTriggerAreaComponent> TriggerSideOne { get; set; }
		[Ordinal(88)]  [RED("triggerSideTwo")] public CHandle<gameStaticTriggerAreaComponent> TriggerSideTwo { get; set; }
		[Ordinal(89)]  [RED("offMeshConnectionComponent")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent { get; set; }
		[Ordinal(90)]  [RED("strongSoloFrame")] public CHandle<entMeshComponent> StrongSoloFrame { get; set; }
		[Ordinal(91)]  [RED("terminalNetrunner1")] public CHandle<entMeshComponent> TerminalNetrunner1 { get; set; }
		[Ordinal(92)]  [RED("terminalNetrunner2")] public CHandle<entMeshComponent> TerminalNetrunner2 { get; set; }
		[Ordinal(93)]  [RED("terminalTechie1")] public CHandle<entMeshComponent> TerminalTechie1 { get; set; }
		[Ordinal(94)]  [RED("terminalTechie2")] public CHandle<entMeshComponent> TerminalTechie2 { get; set; }
		[Ordinal(95)]  [RED("ledTechie1")] public CHandle<gameLightComponent> LedTechie1 { get; set; }
		[Ordinal(96)]  [RED("ledTechie2")] public CHandle<gameLightComponent> LedTechie2 { get; set; }
		[Ordinal(97)]  [RED("ledNetrunner1")] public CHandle<gameLightComponent> LedNetrunner1 { get; set; }
		[Ordinal(98)]  [RED("ledNetrunner2")] public CHandle<gameLightComponent> LedNetrunner2 { get; set; }
		[Ordinal(99)]  [RED("led1")] public CHandle<gameLightComponent> Led1 { get; set; }
		[Ordinal(100)]  [RED("led2")] public CHandle<gameLightComponent> Led2 { get; set; }
		[Ordinal(101)]  [RED("ledHandle1")] public CHandle<gameLightComponent> LedHandle1 { get; set; }
		[Ordinal(102)]  [RED("ledHandle2")] public CHandle<gameLightComponent> LedHandle2 { get; set; }
		[Ordinal(103)]  [RED("ledHandle1a")] public CHandle<gameLightComponent> LedHandle1a { get; set; }
		[Ordinal(104)]  [RED("ledHandle2a")] public CHandle<gameLightComponent> LedHandle2a { get; set; }
		[Ordinal(105)]  [RED("occluder")] public CHandle<entIPlacedComponent> Occluder { get; set; }
		[Ordinal(106)]  [RED("portalLight1")] public CHandle<gameLightComponent> PortalLight1 { get; set; }
		[Ordinal(107)]  [RED("portalLight2")] public CHandle<gameLightComponent> PortalLight2 { get; set; }
		[Ordinal(108)]  [RED("portalLight3")] public CHandle<gameLightComponent> PortalLight3 { get; set; }
		[Ordinal(109)]  [RED("portalLight4")] public CHandle<gameLightComponent> PortalLight4 { get; set; }
		[Ordinal(110)]  [RED("playerBlocker")] public CHandle<entColliderComponent> PlayerBlocker { get; set; }
		[Ordinal(111)]  [RED("animFeatureDoor")] public CHandle<AnimFeatureDoor> AnimFeatureDoor { get; set; }
		[Ordinal(112)]  [RED("isVisuallyOpened")] public CBool IsVisuallyOpened { get; set; }
		[Ordinal(113)]  [RED("lastDoorSide")] public CInt32 LastDoorSide { get; set; }
		[Ordinal(114)]  [RED("colors")] public LedColors Colors { get; set; }
		[Ordinal(115)]  [RED("activeSkillcheckLights")] public CArray<CHandle<gameLightComponent>> ActiveSkillcheckLights { get; set; }
		[Ordinal(116)]  [RED("allActiveLights")] public CArray<CHandle<gameLightComponent>> AllActiveLights { get; set; }
		[Ordinal(117)]  [RED("closingAnimationLength")] public CFloat ClosingAnimationLength { get; set; }
		[Ordinal(118)]  [RED("automaticCloseDelay")] public CFloat AutomaticCloseDelay { get; set; }
		[Ordinal(119)]  [RED("doorOpeningType")] public CEnum<EDoorOpeningType> DoorOpeningType { get; set; }
		[Ordinal(120)]  [RED("animationType")] public CEnum<EAnimationType> AnimationType { get; set; }
		[Ordinal(121)]  [RED("doorTriggerSide")] public CEnum<EDoorTriggerSide> DoorTriggerSide { get; set; }
		[Ordinal(122)]  [RED("whoOpened")] public wCHandle<gameObject> WhoOpened { get; set; }
		[Ordinal(123)]  [RED("openedUsingForce")] public CBool OpenedUsingForce { get; set; }
		[Ordinal(124)]  [RED("illegalOpen")] public CBool IllegalOpen { get; set; }
		[Ordinal(125)]  [RED("playerInWorkspot")] public wCHandle<PlayerPuppet> PlayerInWorkspot { get; set; }

		public Door(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
