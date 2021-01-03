using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HudPhoneGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(0)]  [RED("AudioInitiateCallEvent")] public CName AudioInitiateCallEvent { get; set; }
		[Ordinal(1)]  [RED("AudioInitiateCallNegativeEvent")] public CName AudioInitiateCallNegativeEvent { get; set; }
		[Ordinal(2)]  [RED("AudioInitiateCallPositiveEvent")] public CName AudioInitiateCallPositiveEvent { get; set; }
		[Ordinal(3)]  [RED("AudioPhoneOffEvent")] public CName AudioPhoneOffEvent { get; set; }
		[Ordinal(4)]  [RED("AudioPhoneOnEvent")] public CName AudioPhoneOnEvent { get; set; }
		[Ordinal(5)]  [RED("AvatarController")] public wCHandle<HudPhoneAvatarController> AvatarController { get; set; }
		[Ordinal(6)]  [RED("AvatarControllerRef")] public inkWidgetReference AvatarControllerRef { get; set; }
		[Ordinal(7)]  [RED("Blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(8)]  [RED("BlackboardDef")] public CHandle<UI_ComDeviceDef> BlackboardDef { get; set; }
		[Ordinal(9)]  [RED("CallInformationBBID")] public CUInt32 CallInformationBBID { get; set; }
		[Ordinal(10)]  [RED("CurrentCallInformation")] public questPhoneCallInformation CurrentCallInformation { get; set; }
		[Ordinal(11)]  [RED("CurrentFunction")] public CEnum<EHudPhoneFunction> CurrentFunction { get; set; }
		[Ordinal(12)]  [RED("CurrentPhoneCallContact")] public wCHandle<gameJournalContact> CurrentPhoneCallContact { get; set; }
		[Ordinal(13)]  [RED("DelaySystem")] public wCHandle<gameDelaySystem> DelaySystem { get; set; }
		[Ordinal(14)]  [RED("DelayedCallbackId")] public gameDelayID DelayedCallbackId { get; set; }
		[Ordinal(15)]  [RED("DelayedTimeoutCallbackId")] public gameDelayID DelayedTimeoutCallbackId { get; set; }
		[Ordinal(16)]  [RED("Holder")] public inkWidgetReference Holder { get; set; }
		[Ordinal(17)]  [RED("JournalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }
		[Ordinal(18)]  [RED("MinimizedListener")] public CUInt32 MinimizedListener { get; set; }
		[Ordinal(19)]  [RED("Owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(20)]  [RED("PhoneSystem")] public wCHandle<PhoneSystem> PhoneSystem { get; set; }
		[Ordinal(21)]  [RED("RootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(22)]  [RED("SoundNameActionOnClose")] public CName SoundNameActionOnClose { get; set; }
		[Ordinal(23)]  [RED("SoundNameActionOnOpen")] public CName SoundNameActionOnOpen { get; set; }
		[Ordinal(24)]  [RED("StatusNameBBID")] public CUInt32 StatusNameBBID { get; set; }
		[Ordinal(25)]  [RED("TimeoutPeroid")] public CFloat TimeoutPeroid { get; set; }
		[Ordinal(26)]  [RED("UnreadMessages")] public CArray<wCHandle<gameJournalPhoneMessage>> UnreadMessages { get; set; }
		[Ordinal(27)]  [RED("buttonPressed")] public CBool ButtonPressed { get; set; }
		[Ordinal(28)]  [RED("gameplayRestrictions")] public CArray<CName> GameplayRestrictions { get; set; }
		[Ordinal(29)]  [RED("options")] public inkanimPlaybackOptions Options { get; set; }
		[Ordinal(30)]  [RED("portraitIntroAnim")] public CHandle<inkanimProxy> PortraitIntroAnim { get; set; }
		[Ordinal(31)]  [RED("portraitLoopAnim")] public CHandle<inkanimProxy> PortraitLoopAnim { get; set; }
		[Ordinal(32)]  [RED("portraitOutroAnim")] public CHandle<inkanimProxy> PortraitOutroAnim { get; set; }
		[Ordinal(33)]  [RED("updatesProjection")] public CHandle<inkScreenProjection> UpdatesProjection { get; set; }

		public HudPhoneGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
