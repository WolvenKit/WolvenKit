using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleComponent : ScriptableDC
	{
		[Ordinal(0)]  [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }
		[Ordinal(1)]  [RED("scanningComponent")] public CHandle<gameScanningComponent> ScanningComponent { get; set; }
		[Ordinal(2)]  [RED("damageLevel")] public CInt32 DamageLevel { get; set; }
		[Ordinal(3)]  [RED("coolerDestro")] public CBool CoolerDestro { get; set; }
		[Ordinal(4)]  [RED("submerged")] public CBool Submerged { get; set; }
		[Ordinal(5)]  [RED("bumperFrontState")] public CInt32 BumperFrontState { get; set; }
		[Ordinal(6)]  [RED("bumperBackState")] public CInt32 BumperBackState { get; set; }
		[Ordinal(7)]  [RED("visualDestructionSet")] public CBool VisualDestructionSet { get; set; }
		[Ordinal(8)]  [RED("healthStatPoolListener")] public CHandle<VehicleHealthStatPoolListener> HealthStatPoolListener { get; set; }
		[Ordinal(9)]  [RED("vehicleBlackboard")] public wCHandle<gameIBlackboard> VehicleBlackboard { get; set; }
		[Ordinal(10)]  [RED("radioState")] public CBool RadioState { get; set; }
		[Ordinal(11)]  [RED("mounted")] public CBool Mounted { get; set; }
		[Ordinal(12)]  [RED("enterTime")] public CFloat EnterTime { get; set; }
		[Ordinal(13)]  [RED("mappinID")] public gameNewMappinID MappinID { get; set; }
		[Ordinal(14)]  [RED("ignoreAutoDoorClose")] public CBool IgnoreAutoDoorClose { get; set; }
		[Ordinal(15)]  [RED("timeSystemCallbackID")] public CUInt32 TimeSystemCallbackID { get; set; }
		[Ordinal(16)]  [RED("vehicleTPPCallbackID")] public CUInt32 VehicleTPPCallbackID { get; set; }
		[Ordinal(17)]  [RED("vehicleSpeedCallbackID")] public CUInt32 VehicleSpeedCallbackID { get; set; }
		[Ordinal(18)]  [RED("vehicleRPMCallbackID")] public CUInt32 VehicleRPMCallbackID { get; set; }
		[Ordinal(19)]  [RED("broadcasting")] public CBool Broadcasting { get; set; }
		[Ordinal(20)]  [RED("hasSpoiler")] public CBool HasSpoiler { get; set; }
		[Ordinal(21)]  [RED("spoilerUp")] public CFloat SpoilerUp { get; set; }
		[Ordinal(22)]  [RED("spoilerDown")] public CFloat SpoilerDown { get; set; }
		[Ordinal(23)]  [RED("spoilerDeployed")] public CBool SpoilerDeployed { get; set; }
		[Ordinal(24)]  [RED("hasTurboCharger")] public CBool HasTurboCharger { get; set; }
		[Ordinal(25)]  [RED("overheatEffectBlackboard")] public CHandle<worldEffectBlackboard> OverheatEffectBlackboard { get; set; }
		[Ordinal(26)]  [RED("overheatActive")] public CBool OverheatActive { get; set; }
		[Ordinal(27)]  [RED("hornOn")] public CBool HornOn { get; set; }
		[Ordinal(28)]  [RED("hasSiren")] public CBool HasSiren { get; set; }
		[Ordinal(29)]  [RED("hornPressTime")] public CFloat HornPressTime { get; set; }
		[Ordinal(30)]  [RED("radioPressTime")] public CFloat RadioPressTime { get; set; }
		[Ordinal(31)]  [RED("raceClockTickID")] public gameDelayID RaceClockTickID { get; set; }
		[Ordinal(32)]  [RED("objectActionsCallbackCtrl")] public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl { get; set; }
		[Ordinal(33)]  [RED("mountedPlayer")] public wCHandle<PlayerPuppet> MountedPlayer { get; set; }
		[Ordinal(34)]  [RED("isIgnoredInTargetingSystem")] public CBool IsIgnoredInTargetingSystem { get; set; }
		[Ordinal(35)]  [RED("arePlayerHitShapesEnabled")] public CBool ArePlayerHitShapesEnabled { get; set; }
		[Ordinal(36)]  [RED("vehicleController")] public CHandle<vehicleController> VehicleController { get; set; }

		public VehicleComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
