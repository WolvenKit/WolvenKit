using W3SavegameEditor.Core.Savegame.Attributes;

namespace W3SavegameEditor.Core.Savegame.Values
{
    [CName("envManager")]
    public class EnvManager
    {
        [CName("sepiaActive")]
        public uint SepiaActive { get; set; }

        [CName("weatherConditionName")]
        //[CType("CName")]
        public string WeatherConditionName { get; set; }

        [CName("QuestEnvDepotPath")]
        public string QuestEnvDepotPath { get; set; }

        [CName("QuestEnvPriority")]
        public int QuestEnvPriority { get; set; }

        [CName("QuestEnvBlendFactor")]
        public float QuestEnvBlendFactor { get; set; }
    }
}