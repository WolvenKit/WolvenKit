using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetworkSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("networkLinks")] public CArray<SNetworkLinkData> NetworkLinks { get; set; }
		[Ordinal(1)] [RED("networkRevealTargets")] public CArray<entEntityID> NetworkRevealTargets { get; set; }
		[Ordinal(2)] [RED("sessionStarted")] public CBool SessionStarted { get; set; }
		[Ordinal(3)] [RED("visionModeChangedCallback")] public CUInt32 VisionModeChangedCallback { get; set; }
		[Ordinal(4)] [RED("focusModeToggleCallback")] public CUInt32 FocusModeToggleCallback { get; set; }
		[Ordinal(5)] [RED("playerSpawnCallback")] public CUInt32 PlayerSpawnCallback { get; set; }
		[Ordinal(6)] [RED("currentPlayerTargetCallbackID")] public CUInt32 CurrentPlayerTargetCallbackID { get; set; }
		[Ordinal(7)] [RED("lastTargetSlaveID")] public entEntityID LastTargetSlaveID { get; set; }
		[Ordinal(8)] [RED("lastTargetMasterID")] public entEntityID LastTargetMasterID { get; set; }
		[Ordinal(9)] [RED("unregisterLinksRequestDelay")] public gameDelayID UnregisterLinksRequestDelay { get; set; }
		[Ordinal(10)] [RED("focusModeActive")] public CBool FocusModeActive { get; set; }
		[Ordinal(11)] [RED("lastBeamResource")] public gameFxResource LastBeamResource { get; set; }
		[Ordinal(12)] [RED("pingNetworkEffect")] public CHandle<gameEffectInstance> PingNetworkEffect { get; set; }
		[Ordinal(13)] [RED("pingCachedData")] public CHandle<PingCachedData> PingCachedData { get; set; }
		[Ordinal(14)] [RED("lastPingSourceID")] public entEntityID LastPingSourceID { get; set; }
		[Ordinal(15)] [RED("activePings")] public CArray<CHandle<PingCachedData>> ActivePings { get; set; }
		[Ordinal(16)] [RED("pingLinksCounter")] public CInt32 PingLinksCounter { get; set; }
		[Ordinal(17)] [RED("networkPresetTBDID")] public TweakDBID NetworkPresetTBDID { get; set; }
		[Ordinal(18)] [RED("networkPresetRecord")] public wCHandle<gamedataNetworkPingingParameteres_Record> NetworkPresetRecord { get; set; }
		[Ordinal(19)] [RED("backdoors")] public CArray<gamePersistentID> Backdoors { get; set; }
		[Ordinal(20)] [RED("revealedBackdoorsCount")] public CInt32 RevealedBackdoorsCount { get; set; }
		[Ordinal(21)] [RED("debugCashedPingFxResource")] public gameFxResource DebugCashedPingFxResource { get; set; }
		[Ordinal(22)] [RED("debugQueryNumber")] public CInt32 DebugQueryNumber { get; set; }

		public NetworkSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
