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
		[Ordinal(0)] [RED("("horseCamera")] 		public CHandle<CCustomCamera> HorseCamera { get; set;}

		[Ordinal(0)] [RED("("telemetryScriptProxy")] 		public CPtr<CR4TelemetryScriptProxy> TelemetryScriptProxy { get; set;}

		[Ordinal(0)] [RED("("secondScreenScriptProxy")] 		public CPtr<CR4SecondScreenManagerScriptProxy> SecondScreenScriptProxy { get; set;}

		[Ordinal(0)] [RED("("kinectSpeechRecognizerListenerScriptProxy")] 		public CPtr<CR4KinectSpeechRecognizerListenerScriptProxy> KinectSpeechRecognizerListenerScriptProxy { get; set;}

		[Ordinal(0)] [RED("("ticketsDefaultConfiguration")] 		public CPtr<CTicketsDefaultConfiguration> TicketsDefaultConfiguration { get; set;}

		[Ordinal(0)] [RED("("globalEventsScriptsDispatcher")] 		public CPtr<CR4GlobalEventsScriptsDispatcher> GlobalEventsScriptsDispatcher { get; set;}

		[Ordinal(0)] [RED("("worldDLCExtender")] 		public CPtr<CR4WorldDLCExtender> WorldDLCExtender { get; set;}

		[Ordinal(0)] [RED("("globalTicketSource")] 		public CHandle<CGlabalTicketSourceProvider> GlobalTicketSource { get; set;}

		[Ordinal(0)] [RED("("carryableItemsRegistry")] 		public CHandle<CCarryableItemsRegistry> CarryableItemsRegistry { get; set;}

		[Ordinal(0)] [RED("("params")] 		public CHandle<W3GameParams> Params { get; set;}

		[Ordinal(0)] [RED("("zoneName")] 		public CEnum<EZoneName> ZoneName { get; set;}

		[Ordinal(0)] [RED("("gamerProfile")] 		public CHandle<W3GamerProfile> GamerProfile { get; set;}

		[Ordinal(0)] [RED("("isDialogOrCutscenePlaying")] 		public CBool IsDialogOrCutscenePlaying { get; set;}

		[Ordinal(0)] [RED("("recentDialogOrCutsceneEndGameTime")] 		public GameTime RecentDialogOrCutsceneEndGameTime { get; set;}

		[Ordinal(0)] [RED("("isCutscenePlaying")] 		public CBool IsCutscenePlaying { get; set;}

		[Ordinal(0)] [RED("("isDialogDisplayDisabled")] 		public CBool IsDialogDisplayDisabled { get; set;}

		[Ordinal(0)] [RED("("witcherLog")] 		public CHandle<W3GameLog> WitcherLog { get; set;}

		[Ordinal(0)] [RED("("deathSaveLockId")] 		public CInt32 DeathSaveLockId { get; set;}

		[Ordinal(0)] [RED("("currentPresence")] 		public CName CurrentPresence { get; set;}

		[Ordinal(0)] [RED("("restoreUsableItemL")] 		public CBool RestoreUsableItemL { get; set;}

		[Ordinal(0)] [RED("("savedEnchanterFunds")] 		public CInt32 SavedEnchanterFunds { get; set;}

		[Ordinal(0)] [RED("("gameplayFactsForRemoval", 2,0)] 		public CArray<SGameplayFactRemoval> GameplayFactsForRemoval { get; set;}

		[Ordinal(0)] [RED("("gameplayFacts", 2,0)] 		public CArray<SGameplayFact> GameplayFacts { get; set;}

		[Ordinal(0)] [RED("("tutorialManagerHandle")] 		public EntityHandle TutorialManagerHandle { get; set;}

		[Ordinal(0)] [RED("("diffChangePostponed")] 		public CEnum<EDifficultyMode> DiffChangePostponed { get; set;}

		[Ordinal(0)] [RED("("dynamicallySpawnedBoats", 2,0)] 		public CArray<EntityHandle> DynamicallySpawnedBoats { get; set;}

		[Ordinal(0)] [RED("("dynamicallySpawnedBoatsToDestroy", 2,0)] 		public CArray<EntityHandle> DynamicallySpawnedBoatsToDestroy { get; set;}

		[Ordinal(0)] [RED("("uberMovement")] 		public CBool UberMovement { get; set;}

		[Ordinal(0)] [RED("("isRespawningInLastCheckpoint")] 		public CBool IsRespawningInLastCheckpoint { get; set;}

		[Ordinal(0)] [RED("("environmentID")] 		public CInt32 EnvironmentID { get; set;}

		[Ordinal(0)] [RED("("logEnabled")] 		public CBool LogEnabled { get; set;}

		[Ordinal(0)] [RED("("globalEventsScriptsDispatcherInternal")] 		public CHandle<CR4GlobalEventsScriptsDispatcher> GlobalEventsScriptsDispatcherInternal { get; set;}

		[Ordinal(0)] [RED("("minimapSettings")] 		public CHandle<C2dArray> MinimapSettings { get; set;}

		[Ordinal(0)] [RED("("playerStatisticsSettings")] 		public CHandle<C2dArray> PlayerStatisticsSettings { get; set;}

		[Ordinal(0)] [RED("("hudSettings")] 		public CHandle<C2dArray> HudSettings { get; set;}

		[Ordinal(0)] [RED("("damageMgr")] 		public CHandle<W3DamageManager> DamageMgr { get; set;}

		[Ordinal(0)] [RED("("effectMgr")] 		public CHandle<W3GameEffectManager> EffectMgr { get; set;}

		[Ordinal(0)] [RED("("timescaleSources", 2,0)] 		public CArray<STimeScaleSource> TimescaleSources { get; set;}

		[Ordinal(0)] [RED("("envMgr")] 		public CHandle<W3EnvironmentManager> EnvMgr { get; set;}

		[Ordinal(0)] [RED("("runewordMgr")] 		public CHandle<W3RunewordManager> RunewordMgr { get; set;}

		[Ordinal(0)] [RED("("questLevelsFilePaths", 2,0)] 		public CArray<CString> QuestLevelsFilePaths { get; set;}

		[Ordinal(0)] [RED("("questLevelsContainer", 2,0)] 		public CArray<CHandle<C2dArray>> QuestLevelsContainer { get; set;}

		[Ordinal(0)] [RED("("expGlobalModifiers")] 		public CHandle<C2dArray> ExpGlobalModifiers { get; set;}

		[Ordinal(0)] [RED("("expGlobalMod_kills")] 		public CFloat ExpGlobalMod_kills { get; set;}

		[Ordinal(0)] [RED("("expGlobalMod_quests")] 		public CFloat ExpGlobalMod_quests { get; set;}

		[Ordinal(0)] [RED("("syncAnimManager")] 		public CHandle<W3SyncAnimationManager> SyncAnimManager { get; set;}

		[Ordinal(0)] [RED("("isSignedIn")] 		public CBool IsSignedIn { get; set;}

		[Ordinal(0)] [RED("("m_runReactionSceneDialog")] 		public CBool M_runReactionSceneDialog { get; set;}

		[Ordinal(0)] [RED("("_mainMenuType")] 		public CInt32 _mainMenuType { get; set;}

		[Ordinal(0)] [RED("("uiHorizontalFrameScale")] 		public CFloat UiHorizontalFrameScale { get; set;}

		[Ordinal(0)] [RED("("uiVerticalFrameScale")] 		public CFloat UiVerticalFrameScale { get; set;}

		[Ordinal(0)] [RED("("uiScale")] 		public CFloat UiScale { get; set;}

		[Ordinal(0)] [RED("("uiGamepadScaleGain")] 		public CFloat UiGamepadScaleGain { get; set;}

		[Ordinal(0)] [RED("("uiOpacity")] 		public CFloat UiOpacity { get; set;}

		[Ordinal(0)] [RED("("isColorBlindMode")] 		public CBool IsColorBlindMode { get; set;}

		[Ordinal(0)] [RED("("menuToOpen")] 		public CName MenuToOpen { get; set;}

		[Ordinal(0)] [RED("("postponedPreAttackEvents", 2,0)] 		public CArray<SPostponedPreAttackEvent> PostponedPreAttackEvents { get; set;}

		public CR4Game(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4Game(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}