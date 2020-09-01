using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4Game : CCommonGame
	{
		[Ordinal(1)] [RED("("horseCamera")] 		public CHandle<CCustomCamera> HorseCamera { get; set;}

		[Ordinal(2)] [RED("("telemetryScriptProxy")] 		public CPtr<CR4TelemetryScriptProxy> TelemetryScriptProxy { get; set;}

		[Ordinal(3)] [RED("("secondScreenScriptProxy")] 		public CPtr<CR4SecondScreenManagerScriptProxy> SecondScreenScriptProxy { get; set;}

		[Ordinal(4)] [RED("("kinectSpeechRecognizerListenerScriptProxy")] 		public CPtr<CR4KinectSpeechRecognizerListenerScriptProxy> KinectSpeechRecognizerListenerScriptProxy { get; set;}

		[Ordinal(5)] [RED("("ticketsDefaultConfiguration")] 		public CPtr<CTicketsDefaultConfiguration> TicketsDefaultConfiguration { get; set;}

		[Ordinal(6)] [RED("("globalEventsScriptsDispatcher")] 		public CPtr<CR4GlobalEventsScriptsDispatcher> GlobalEventsScriptsDispatcher { get; set;}

		[Ordinal(7)] [RED("("worldDLCExtender")] 		public CPtr<CR4WorldDLCExtender> WorldDLCExtender { get; set;}

		[Ordinal(8)] [RED("("globalTicketSource")] 		public CHandle<CGlabalTicketSourceProvider> GlobalTicketSource { get; set;}

		[Ordinal(9)] [RED("("carryableItemsRegistry")] 		public CHandle<CCarryableItemsRegistry> CarryableItemsRegistry { get; set;}

		[Ordinal(10)] [RED("("params")] 		public CHandle<W3GameParams> Params { get; set;}

		[Ordinal(11)] [RED("("zoneName")] 		public CEnum<EZoneName> ZoneName { get; set;}

		[Ordinal(12)] [RED("("gamerProfile")] 		public CHandle<W3GamerProfile> GamerProfile { get; set;}

		[Ordinal(13)] [RED("("isDialogOrCutscenePlaying")] 		public CBool IsDialogOrCutscenePlaying { get; set;}

		[Ordinal(14)] [RED("("recentDialogOrCutsceneEndGameTime")] 		public GameTime RecentDialogOrCutsceneEndGameTime { get; set;}

		[Ordinal(15)] [RED("("isCutscenePlaying")] 		public CBool IsCutscenePlaying { get; set;}

		[Ordinal(16)] [RED("("isDialogDisplayDisabled")] 		public CBool IsDialogDisplayDisabled { get; set;}

		[Ordinal(17)] [RED("("witcherLog")] 		public CHandle<W3GameLog> WitcherLog { get; set;}

		[Ordinal(18)] [RED("("deathSaveLockId")] 		public CInt32 DeathSaveLockId { get; set;}

		[Ordinal(19)] [RED("("currentPresence")] 		public CName CurrentPresence { get; set;}

		[Ordinal(20)] [RED("("restoreUsableItemL")] 		public CBool RestoreUsableItemL { get; set;}

		[Ordinal(21)] [RED("("savedEnchanterFunds")] 		public CInt32 SavedEnchanterFunds { get; set;}

		[Ordinal(22)] [RED("("gameplayFactsForRemoval", 2,0)] 		public CArray<SGameplayFactRemoval> GameplayFactsForRemoval { get; set;}

		[Ordinal(23)] [RED("("gameplayFacts", 2,0)] 		public CArray<SGameplayFact> GameplayFacts { get; set;}

		[Ordinal(24)] [RED("("tutorialManagerHandle")] 		public EntityHandle TutorialManagerHandle { get; set;}

		[Ordinal(25)] [RED("("diffChangePostponed")] 		public CEnum<EDifficultyMode> DiffChangePostponed { get; set;}

		[Ordinal(26)] [RED("("dynamicallySpawnedBoats", 2,0)] 		public CArray<EntityHandle> DynamicallySpawnedBoats { get; set;}

		[Ordinal(27)] [RED("("dynamicallySpawnedBoatsToDestroy", 2,0)] 		public CArray<EntityHandle> DynamicallySpawnedBoatsToDestroy { get; set;}

		[Ordinal(28)] [RED("("uberMovement")] 		public CBool UberMovement { get; set;}

		[Ordinal(29)] [RED("("isRespawningInLastCheckpoint")] 		public CBool IsRespawningInLastCheckpoint { get; set;}

		[Ordinal(30)] [RED("("environmentID")] 		public CInt32 EnvironmentID { get; set;}

		[Ordinal(31)] [RED("("logEnabled")] 		public CBool LogEnabled { get; set;}

		[Ordinal(32)] [RED("("globalEventsScriptsDispatcherInternal")] 		public CHandle<CR4GlobalEventsScriptsDispatcher> GlobalEventsScriptsDispatcherInternal { get; set;}

		[Ordinal(33)] [RED("("minimapSettings")] 		public CHandle<C2dArray> MinimapSettings { get; set;}

		[Ordinal(34)] [RED("("playerStatisticsSettings")] 		public CHandle<C2dArray> PlayerStatisticsSettings { get; set;}

		[Ordinal(35)] [RED("("hudSettings")] 		public CHandle<C2dArray> HudSettings { get; set;}

		[Ordinal(36)] [RED("("damageMgr")] 		public CHandle<W3DamageManager> DamageMgr { get; set;}

		[Ordinal(37)] [RED("("effectMgr")] 		public CHandle<W3GameEffectManager> EffectMgr { get; set;}

		[Ordinal(38)] [RED("("timescaleSources", 2,0)] 		public CArray<STimeScaleSource> TimescaleSources { get; set;}

		[Ordinal(39)] [RED("("envMgr")] 		public CHandle<W3EnvironmentManager> EnvMgr { get; set;}

		[Ordinal(40)] [RED("("runewordMgr")] 		public CHandle<W3RunewordManager> RunewordMgr { get; set;}

		[Ordinal(41)] [RED("("questLevelsFilePaths", 2,0)] 		public CArray<CString> QuestLevelsFilePaths { get; set;}

		[Ordinal(42)] [RED("("questLevelsContainer", 2,0)] 		public CArray<CHandle<C2dArray>> QuestLevelsContainer { get; set;}

		[Ordinal(43)] [RED("("expGlobalModifiers")] 		public CHandle<C2dArray> ExpGlobalModifiers { get; set;}

		[Ordinal(44)] [RED("("expGlobalMod_kills")] 		public CFloat ExpGlobalMod_kills { get; set;}

		[Ordinal(45)] [RED("("expGlobalMod_quests")] 		public CFloat ExpGlobalMod_quests { get; set;}

		[Ordinal(46)] [RED("("syncAnimManager")] 		public CHandle<W3SyncAnimationManager> SyncAnimManager { get; set;}

		[Ordinal(47)] [RED("("isSignedIn")] 		public CBool IsSignedIn { get; set;}

		[Ordinal(48)] [RED("("m_runReactionSceneDialog")] 		public CBool M_runReactionSceneDialog { get; set;}

		[Ordinal(49)] [RED("("_mainMenuType")] 		public CInt32 _mainMenuType { get; set;}

		[Ordinal(50)] [RED("("uiHorizontalFrameScale")] 		public CFloat UiHorizontalFrameScale { get; set;}

		[Ordinal(51)] [RED("("uiVerticalFrameScale")] 		public CFloat UiVerticalFrameScale { get; set;}

		[Ordinal(52)] [RED("("uiScale")] 		public CFloat UiScale { get; set;}

		[Ordinal(53)] [RED("("uiGamepadScaleGain")] 		public CFloat UiGamepadScaleGain { get; set;}

		[Ordinal(54)] [RED("("uiOpacity")] 		public CFloat UiOpacity { get; set;}

		[Ordinal(55)] [RED("("isColorBlindMode")] 		public CBool IsColorBlindMode { get; set;}

		[Ordinal(56)] [RED("("menuToOpen")] 		public CName MenuToOpen { get; set;}

		[Ordinal(57)] [RED("("postponedPreAttackEvents", 2,0)] 		public CArray<SPostponedPreAttackEvent> PostponedPreAttackEvents { get; set;}

		public CR4Game(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4Game(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}