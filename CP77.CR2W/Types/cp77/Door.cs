using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Door : InteractiveDevice
	{
		[Ordinal(0)]  [RED("activeSkillcheckLights")] public CArray<CHandle<gameLightComponent>> ActiveSkillcheckLights { get; set; }
		[Ordinal(1)]  [RED("allActiveLights")] public CArray<CHandle<gameLightComponent>> AllActiveLights { get; set; }
		[Ordinal(2)]  [RED("animFeatureDoor")] public CHandle<AnimFeatureDoor> AnimFeatureDoor { get; set; }
		[Ordinal(3)]  [RED("animationController")] public CHandle<entAnimationControllerComponent> AnimationController { get; set; }
		[Ordinal(4)]  [RED("animationType")] public CEnum<EAnimationType> AnimationType { get; set; }
		[Ordinal(5)]  [RED("automaticCloseDelay")] public CFloat AutomaticCloseDelay { get; set; }
		[Ordinal(6)]  [RED("bankToLoad_TEMP")] public CString BankToLoad_TEMP { get; set; }
		[Ordinal(7)]  [RED("closingAnimationLength")] public CFloat ClosingAnimationLength { get; set; }
		[Ordinal(8)]  [RED("colors")] public LedColors Colors { get; set; }
		[Ordinal(9)]  [RED("doorOpeningType")] public CEnum<EDoorOpeningType> DoorOpeningType { get; set; }
		[Ordinal(10)]  [RED("doorTriggerSide")] public CEnum<EDoorTriggerSide> DoorTriggerSide { get; set; }
		[Ordinal(11)]  [RED("illegalOpen")] public CBool IllegalOpen { get; set; }
		[Ordinal(12)]  [RED("isVisuallyOpened")] public CBool IsVisuallyOpened { get; set; }
		[Ordinal(13)]  [RED("lastDoorSide")] public CInt32 LastDoorSide { get; set; }
		[Ordinal(14)]  [RED("led1")] public CHandle<gameLightComponent> Led1 { get; set; }
		[Ordinal(15)]  [RED("led2")] public CHandle<gameLightComponent> Led2 { get; set; }
		[Ordinal(16)]  [RED("ledHandle1")] public CHandle<gameLightComponent> LedHandle1 { get; set; }
		[Ordinal(17)]  [RED("ledHandle1a")] public CHandle<gameLightComponent> LedHandle1a { get; set; }
		[Ordinal(18)]  [RED("ledHandle2")] public CHandle<gameLightComponent> LedHandle2 { get; set; }
		[Ordinal(19)]  [RED("ledHandle2a")] public CHandle<gameLightComponent> LedHandle2a { get; set; }
		[Ordinal(20)]  [RED("ledNetrunner1")] public CHandle<gameLightComponent> LedNetrunner1 { get; set; }
		[Ordinal(21)]  [RED("ledNetrunner2")] public CHandle<gameLightComponent> LedNetrunner2 { get; set; }
		[Ordinal(22)]  [RED("ledTechie1")] public CHandle<gameLightComponent> LedTechie1 { get; set; }
		[Ordinal(23)]  [RED("ledTechie2")] public CHandle<gameLightComponent> LedTechie2 { get; set; }
		[Ordinal(24)]  [RED("occluder")] public CHandle<entIPlacedComponent> Occluder { get; set; }
		[Ordinal(25)]  [RED("offMeshConnectionComponent")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent { get; set; }
		[Ordinal(26)]  [RED("openedUsingForce")] public CBool OpenedUsingForce { get; set; }
		[Ordinal(27)]  [RED("playerBlocker")] public CHandle<entColliderComponent> PlayerBlocker { get; set; }
		[Ordinal(28)]  [RED("playerInWorkspot")] public wCHandle<PlayerPuppet> PlayerInWorkspot { get; set; }
		[Ordinal(29)]  [RED("portalLight1")] public CHandle<gameLightComponent> PortalLight1 { get; set; }
		[Ordinal(30)]  [RED("portalLight2")] public CHandle<gameLightComponent> PortalLight2 { get; set; }
		[Ordinal(31)]  [RED("portalLight3")] public CHandle<gameLightComponent> PortalLight3 { get; set; }
		[Ordinal(32)]  [RED("portalLight4")] public CHandle<gameLightComponent> PortalLight4 { get; set; }
		[Ordinal(33)]  [RED("strongSoloFrame")] public CHandle<entMeshComponent> StrongSoloFrame { get; set; }
		[Ordinal(34)]  [RED("terminalNetrunner1")] public CHandle<entMeshComponent> TerminalNetrunner1 { get; set; }
		[Ordinal(35)]  [RED("terminalNetrunner2")] public CHandle<entMeshComponent> TerminalNetrunner2 { get; set; }
		[Ordinal(36)]  [RED("terminalTechie1")] public CHandle<entMeshComponent> TerminalTechie1 { get; set; }
		[Ordinal(37)]  [RED("terminalTechie2")] public CHandle<entMeshComponent> TerminalTechie2 { get; set; }
		[Ordinal(38)]  [RED("triggerComponent")] public CHandle<gameStaticTriggerAreaComponent> TriggerComponent { get; set; }
		[Ordinal(39)]  [RED("triggerSideOne")] public CHandle<gameStaticTriggerAreaComponent> TriggerSideOne { get; set; }
		[Ordinal(40)]  [RED("triggerSideTwo")] public CHandle<gameStaticTriggerAreaComponent> TriggerSideTwo { get; set; }
		[Ordinal(41)]  [RED("whoOpened")] public wCHandle<gameObject> WhoOpened { get; set; }

		public Door(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
