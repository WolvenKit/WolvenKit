using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HudPhoneGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(9)] [RED("AvatarControllerRef")] public inkWidgetReference AvatarControllerRef { get; set; }
		[Ordinal(10)] [RED("AvatarController")] public wCHandle<HudPhoneAvatarController> AvatarController { get; set; }
		[Ordinal(11)] [RED("RootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(12)] [RED("SoundNameActionOnOpen")] public CName SoundNameActionOnOpen { get; set; }
		[Ordinal(13)] [RED("SoundNameActionOnClose")] public CName SoundNameActionOnClose { get; set; }
		[Ordinal(14)] [RED("AudioInitiateCallPositiveEvent")] public CName AudioInitiateCallPositiveEvent { get; set; }
		[Ordinal(15)] [RED("AudioInitiateCallNegativeEvent")] public CName AudioInitiateCallNegativeEvent { get; set; }
		[Ordinal(16)] [RED("AudioInitiateCallEvent")] public CName AudioInitiateCallEvent { get; set; }
		[Ordinal(17)] [RED("AudioPhoneOnEvent")] public CName AudioPhoneOnEvent { get; set; }
		[Ordinal(18)] [RED("AudioPhoneOffEvent")] public CName AudioPhoneOffEvent { get; set; }
		[Ordinal(19)] [RED("Holder")] public inkWidgetReference Holder { get; set; }
		[Ordinal(20)] [RED("Owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(21)] [RED("UnreadMessages")] public CArray<wCHandle<gameJournalPhoneMessage>> UnreadMessages { get; set; }
		[Ordinal(22)] [RED("CurrentFunction")] public CEnum<EHudPhoneFunction> CurrentFunction { get; set; }
		[Ordinal(23)] [RED("CurrentCallInformation")] public questPhoneCallInformation CurrentCallInformation { get; set; }
		[Ordinal(24)] [RED("CurrentPhoneCallContact")] public wCHandle<gameJournalContact> CurrentPhoneCallContact { get; set; }
		[Ordinal(25)] [RED("DelaySystem")] public wCHandle<gameDelaySystem> DelaySystem { get; set; }
		[Ordinal(26)] [RED("PhoneSystem")] public wCHandle<PhoneSystem> PhoneSystem { get; set; }
		[Ordinal(27)] [RED("JournalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }
		[Ordinal(28)] [RED("gameplayRestrictions")] public CArray<CName> GameplayRestrictions { get; set; }
		[Ordinal(29)] [RED("Blackboard")] public wCHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(30)] [RED("BlackboardDef")] public CHandle<UI_ComDeviceDef> BlackboardDef { get; set; }
		[Ordinal(31)] [RED("CallInformationBBID")] public CUInt32 CallInformationBBID { get; set; }
		[Ordinal(32)] [RED("StatusNameBBID")] public CUInt32 StatusNameBBID { get; set; }
		[Ordinal(33)] [RED("MinimizedListener")] public CUInt32 MinimizedListener { get; set; }
		[Ordinal(34)] [RED("DelayedCallbackId")] public gameDelayID DelayedCallbackId { get; set; }
		[Ordinal(35)] [RED("DelayedTimeoutCallbackId")] public gameDelayID DelayedTimeoutCallbackId { get; set; }
		[Ordinal(36)] [RED("TimeoutPeroid")] public CFloat TimeoutPeroid { get; set; }
		[Ordinal(37)] [RED("portraitIntroAnim")] public CHandle<inkanimProxy> PortraitIntroAnim { get; set; }
		[Ordinal(38)] [RED("portraitOutroAnim")] public CHandle<inkanimProxy> PortraitOutroAnim { get; set; }
		[Ordinal(39)] [RED("portraitLoopAnim")] public CHandle<inkanimProxy> PortraitLoopAnim { get; set; }
		[Ordinal(40)] [RED("options")] public inkanimPlaybackOptions Options { get; set; }
		[Ordinal(41)] [RED("updatesProjection")] public CHandle<inkScreenProjection> UpdatesProjection { get; set; }
		[Ordinal(42)] [RED("buttonPressed")] public CBool ButtonPressed { get; set; }

		public HudPhoneGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
