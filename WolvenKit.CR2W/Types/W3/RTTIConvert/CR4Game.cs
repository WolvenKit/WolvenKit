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
		[RED("horseCamera")] 		public CHandle<CCustomCamera> HorseCamera { get; set;}

		[RED("telemetryScriptProxy")] 		public CPtr<CR4TelemetryScriptProxy> TelemetryScriptProxy { get; set;}

		[RED("secondScreenScriptProxy")] 		public CPtr<CR4SecondScreenManagerScriptProxy> SecondScreenScriptProxy { get; set;}

		[RED("kinectSpeechRecognizerListenerScriptProxy")] 		public CPtr<CR4KinectSpeechRecognizerListenerScriptProxy> KinectSpeechRecognizerListenerScriptProxy { get; set;}

		[RED("ticketsDefaultConfiguration")] 		public CPtr<CTicketsDefaultConfiguration> TicketsDefaultConfiguration { get; set;}

		[RED("globalEventsScriptsDispatcher")] 		public CPtr<CR4GlobalEventsScriptsDispatcher> GlobalEventsScriptsDispatcher { get; set;}

		[RED("worldDLCExtender")] 		public CPtr<CR4WorldDLCExtender> WorldDLCExtender { get; set;}

		[RED("globalTicketSource")] 		public CHandle<CGlabalTicketSourceProvider> GlobalTicketSource { get; set;}

		[RED("carryableItemsRegistry")] 		public CHandle<CCarryableItemsRegistry> CarryableItemsRegistry { get; set;}

		[RED("params")] 		public CHandle<W3GameParams> Params { get; set;}

		[RED("zoneName")] 		public CEnum<EZoneName> ZoneName { get; set;}

		[RED("gamerProfile")] 		public CHandle<W3GamerProfile> GamerProfile { get; set;}

		[RED("isDialogOrCutscenePlaying")] 		public CBool IsDialogOrCutscenePlaying { get; set;}

		[RED("recentDialogOrCutsceneEndGameTime")] 		public GameTime RecentDialogOrCutsceneEndGameTime { get; set;}

		[RED("isCutscenePlaying")] 		public CBool IsCutscenePlaying { get; set;}

		[RED("isDialogDisplayDisabled")] 		public CBool IsDialogDisplayDisabled { get; set;}

		[RED("witcherLog")] 		public CHandle<W3GameLog> WitcherLog { get; set;}

		[RED("deathSaveLockId")] 		public CInt32 DeathSaveLockId { get; set;}

		[RED("currentPresence")] 		public CName CurrentPresence { get; set;}

		[RED("restoreUsableItemL")] 		public CBool RestoreUsableItemL { get; set;}

		[RED("savedEnchanterFunds")] 		public CInt32 SavedEnchanterFunds { get; set;}

		[RED("gameplayFactsForRemoval", 2,0)] 		public CArray<SGameplayFactRemoval> GameplayFactsForRemoval { get; set;}

		[RED("gameplayFacts", 2,0)] 		public CArray<SGameplayFact> GameplayFacts { get; set;}

		[RED("tutorialManagerHandle")] 		public EntityHandle TutorialManagerHandle { get; set;}

		[RED("diffChangePostponed")] 		public CEnum<EDifficultyMode> DiffChangePostponed { get; set;}

		[RED("dynamicallySpawnedBoats", 2,0)] 		public CArray<EntityHandle> DynamicallySpawnedBoats { get; set;}

		[RED("dynamicallySpawnedBoatsToDestroy", 2,0)] 		public CArray<EntityHandle> DynamicallySpawnedBoatsToDestroy { get; set;}

		[RED("uberMovement")] 		public CBool UberMovement { get; set;}

		[RED("isRespawningInLastCheckpoint")] 		public CBool IsRespawningInLastCheckpoint { get; set;}

		[RED("environmentID")] 		public CInt32 EnvironmentID { get; set;}

		[RED("logEnabled")] 		public CBool LogEnabled { get; set;}

		[RED("globalEventsScriptsDispatcherInternal")] 		public CHandle<CR4GlobalEventsScriptsDispatcher> GlobalEventsScriptsDispatcherInternal { get; set;}

		[RED("minimapSettings")] 		public CHandle<C2dArray> MinimapSettings { get; set;}

		[RED("playerStatisticsSettings")] 		public CHandle<C2dArray> PlayerStatisticsSettings { get; set;}

		[RED("hudSettings")] 		public CHandle<C2dArray> HudSettings { get; set;}

		[RED("damageMgr")] 		public CHandle<W3DamageManager> DamageMgr { get; set;}

		[RED("effectMgr")] 		public CHandle<W3GameEffectManager> EffectMgr { get; set;}

		[RED("timescaleSources", 2,0)] 		public CArray<STimescaleSource> TimescaleSources { get; set;}

		[RED("envMgr")] 		public CHandle<W3EnvironmentManager> EnvMgr { get; set;}

		[RED("runewordMgr")] 		public CHandle<W3RunewordManager> RunewordMgr { get; set;}

		[RED("questLevelsFilePaths", 2,0)] 		public CArray<CString> QuestLevelsFilePaths { get; set;}

		[RED("questLevelsContainer", 2,0)] 		public CArray<CHandle<C2dArray>> QuestLevelsContainer { get; set;}

		[RED("expGlobalModifiers")] 		public CHandle<C2dArray> ExpGlobalModifiers { get; set;}

		[RED("expGlobalMod_kills")] 		public CFloat ExpGlobalMod_kills { get; set;}

		[RED("expGlobalMod_quests")] 		public CFloat ExpGlobalMod_quests { get; set;}

		[RED("syncAnimManager")] 		public CHandle<W3SyncAnimationManager> SyncAnimManager { get; set;}

		[RED("isSignedIn")] 		public CBool IsSignedIn { get; set;}

		[RED("m_runReactionSceneDialog")] 		public CBool M_runReactionSceneDialog { get; set;}

		[RED("_mainMenuType")] 		public CInt32 _mainMenuType { get; set;}

		[RED("uiHorizontalFrameScale")] 		public CFloat UiHorizontalFrameScale { get; set;}

		[RED("uiVerticalFrameScale")] 		public CFloat UiVerticalFrameScale { get; set;}

		[RED("uiScale")] 		public CFloat UiScale { get; set;}

		[RED("uiGamepadScaleGain")] 		public CFloat UiGamepadScaleGain { get; set;}

		[RED("uiOpacity")] 		public CFloat UiOpacity { get; set;}

		[RED("isColorBlindMode")] 		public CBool IsColorBlindMode { get; set;}

		[RED("menuToOpen")] 		public CName MenuToOpen { get; set;}

		[RED("postponedPreAttackEvents", 2,0)] 		public CArray<SPostponedPreAttackEvent> PostponedPreAttackEvents { get; set;}

		public CR4Game(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4Game(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}