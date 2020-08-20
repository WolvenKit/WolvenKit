using W3SavegameEditor.Core.Savegame.Attributes;
using W3SavegameEditor.Core.Savegame.Values.Engine;

namespace W3SavegameEditor.Core.Savegame.Values
{
    [CName("gameProp")]
    public class GameProp
    {
        [CName("EngineTime")]
        public double EngineTime { get; set; }

        [CName("nP")]
        public uint Np { get; set; }


        /* CR4Game */

        [CName("zoneName")]
        public W3Enum ZoneName { get; set; }

        [CName("recentDialogOrCutsceneEndGameTime")]
        public GameTime RecentDialogOrCutsceneEndGameTime { get; set; }

        public object Unknown1 { get; set; }

        [CName("gameplayFactsForRemoval")]
        public SGameplayFactRemoval[] GameplayFactsForRemoval { get; set; }
        
        [CName("gameplayFacts")]
        public SGameplayFact[] GameplayFacts { get; set; }

        [CName("tutorialManagerHandle")]
        public EntityHandle TutorialManagerHandle { get; set; }

        [CName("diffChangePostponed")]
        [EnumName("EDifficultyMode")]
        public W3Enum DiffChangePostponed { get; set; }

        [CName("dynamicallySpawnedBoats")]
        public EntityHandle[] DynamicallySpawnedBoats { get; set; }

        [CName("dynamicallySpawnedBoats")]
        public EntityHandle[] DynamicallySpawnedBoatsToDestroy { get; set; }
        
        /* /CR4Game */

        [CName("envMgr")]
        public Handle<W3EnvironmentManager> EnvMgr { get; set; }

        public object Unknown2 { get; set; }
    }
}