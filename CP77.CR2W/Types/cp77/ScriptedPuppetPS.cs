using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScriptedPuppetPS : gamePuppetPS
	{
		[Ordinal(4)] [RED("deviceLink")] public wCHandle<PuppetDeviceLinkPS> DeviceLink { get; set; }
		[Ordinal(5)] [RED("cooldownStorage")] public CHandle<CooldownStorage> CooldownStorage { get; set; }
		[Ordinal(6)] [RED("isInitialized")] public CEnum<EBOOL> IsInitialized { get; set; }
		[Ordinal(7)] [RED("wasAttached")] public CBool WasAttached { get; set; }
		[Ordinal(8)] [RED("wasRevealedInNetworkPing")] public CBool WasRevealedInNetworkPing { get; set; }
		[Ordinal(9)] [RED("numberActions")] public CInt32 NumberActions { get; set; }
		[Ordinal(10)] [RED("wasQuickHackAttempt")] public CBool WasQuickHackAttempt { get; set; }
		[Ordinal(11)] [RED("hasDirectInteractionChoicesActive")] public CBool HasDirectInteractionChoicesActive { get; set; }
		[Ordinal(12)] [RED("wasIncapacitated")] public CBool WasIncapacitated { get; set; }
		[Ordinal(13)] [RED("isBreached")] public CBool IsBreached { get; set; }
		[Ordinal(14)] [RED("isDead")] public CBool IsDead { get; set; }
		[Ordinal(15)] [RED("isIncapacitated")] public CBool IsIncapacitated { get; set; }
		[Ordinal(16)] [RED("isAndroidTurnedOff")] public CBool IsAndroidTurnedOff { get; set; }
		[Ordinal(17)] [RED("securitySystemData")] public SecuritySystemData SecuritySystemData { get; set; }
		[Ordinal(18)] [RED("activeContexts")] public CArray<CEnum<gamedeviceRequestType>> ActiveContexts { get; set; }
		[Ordinal(19)] [RED("lastInteractionLayerTag")] public CName LastInteractionLayerTag { get; set; }
		[Ordinal(20)] [RED("quickHacksExposed")] public CBool QuickHacksExposed { get; set; }
		[Ordinal(21)] [RED("currentCooldownID")] public CUInt32 CurrentCooldownID { get; set; }
		[Ordinal(22)] [RED("reactionPresetID")] public TweakDBID ReactionPresetID { get; set; }
		[Ordinal(23)] [RED("isDefeatMechanicActive")] public CBool IsDefeatMechanicActive { get; set; }
		[Ordinal(24)] [RED("leftHandLoadout")] public gameItemID LeftHandLoadout { get; set; }
		[Ordinal(25)] [RED("rightHandLoadout")] public gameItemID RightHandLoadout { get; set; }

		public ScriptedPuppetPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
