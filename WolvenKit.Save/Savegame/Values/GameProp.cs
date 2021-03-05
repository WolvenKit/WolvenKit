using WolvenKit.W3SavegameEditor.Core.Savegame.Attributes;
using WolvenKit.W3SavegameEditor.Core.Savegame.Values.Engine;

namespace WolvenKit.W3SavegameEditor.Core.Savegame.Values
{
    [CName("gameProp")]
    public class GameProp
    {
        #region Properties

        [CName("diffChangePostponed")]
        [EnumName("EDifficultyMode")]
        public W3Enum DiffChangePostponed { get; set; }

        [CName("dynamicallySpawnedBoats")]
        public EntityHandle[] DynamicallySpawnedBoats { get; set; }

        [CName("dynamicallySpawnedBoats")]
        public EntityHandle[] DynamicallySpawnedBoatsToDestroy { get; set; }

        [CName("EngineTime")]
        public double EngineTime { get; set; }

        [CName("envMgr")]
        public Handle<W3EnvironmentManager> EnvMgr { get; set; }

        [CName("gameplayFacts")]
        public SGameplayFact[] GameplayFacts { get; set; }

        [CName("gameplayFactsForRemoval")]
        public SGameplayFactRemoval[] GameplayFactsForRemoval { get; set; }

        [CName("nP")]
        public uint Np { get; set; }

        /* CR4Game */

        [CName("recentDialogOrCutsceneEndGameTime")]
        public GameTime RecentDialogOrCutsceneEndGameTime { get; set; }

        [CName("tutorialManagerHandle")]
        public EntityHandle TutorialManagerHandle { get; set; }

        public object Unknown1 { get; set; }

        public object Unknown2 { get; set; }

        [CName("zoneName")]
        public W3Enum ZoneName { get; set; }

        #endregion Properties

        /* /CR4Game */
    }
}
