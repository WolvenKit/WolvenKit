namespace WolvenKit.RED4.Save
{
    public class Constants
    {
        public static class Magic
        {
            public const string FIRST_FILE_HEADER_MAGIC = "VASC";
            public const string SECOND_FILE_HEADER_MAGIC = "FZLC";
            public const string LZ4_CHUNK_MAGIC = "4ZLX";
            public const string NODE_INFORMATION_START = "EDON";
            public const string END_OF_FILE = "ENOD";
        }

        public static class Parsing
        {
            public const string TPP_SECTION_NAME = "TPP";
            public const string FPP_SECTION_NAME = "FPP";
            public const string TPP_PROXY_SECTION_NAME = "TPP_proxy";
            public const string FPP_PROXY_SECTION_NAME = "FPP_proxy";
            public const string FPP_HAIRS_SECTION_NAME = "FPP_hairs";
            public const string TPP_PHOTOMODE_SECTION_NAME = "TPP_photomode";
            public const string HAIRS_SECTION_NAME = "hairs";
            public const string CHARACTER_CUSTOMIZATION_SECTION_NAME = "character_customization";
            public const string HOLSTERED_DEFAULT_TPP_SECTION_NAME = "holstered_default_tpp";
            public const string HOLSTERED_DEFAULT_SECTION_NAME = "holstered_default";
            public const string HOLSTERED_STRONG_SECTION_NAME = "holstered_strong";
            public const string HOLSTERED_NANOWIRE_SECTION_NAME = "holstered_nanowire";
            public const string HOLSTERED_LAUNCHER_SECTION_NAME = "holstered_launcher";
            public const string HOLSTERED_MANTIS_SECTION_NAME = "holstered_mantis";
            public const string HOLSTERED_DEFAULT_FPP_SECTION_NAME = "holstered_default_fpp";
            public const string HOLSTERED_STRONG_TPP_SECTION_NAME = "holstered_strong_tpp";
            public const string HOLSTERED_STRONG_FPP_SECTION_NAME = "holstered_strong_fpp";
            public const string UNHOLSTERED_STRONG_SECTION_NAME = "unholstered_strong";
            public const string HOLSTERED_NANOWIRE_TPP_SECTION_NAME = "holstered_nanowire_tpp";
            public const string HOLSTERED_NANOWIRE_FPP_SECTION_NAME = "holstered_nanowire_fpp";
            public const string UNHOLSTERED_NANOWIRE_SECTION_NAME = "unholstered_nanowire";
            public const string PERSONAL_LINK_SIMPLE_SECTION_NAME = "personal_link_simple";
            public const string PERSONAL_LINK_ADVANCED_SECTION_NAME = "personal_link_advanced";
            public const string HOLSTERED_LAUNCHER_TPP_SECTION_NAME = "holstered_launcher_tpp";
            public const string HOLSTERED_LAUNCHER_FPP_SECTION_NAME = "holstered_launcher_fpp";
            public const string UNHOLSTERED_LAUNCHER_SECTION_NAME = "unholstered_launcher";
            public const string HOLSTERED_MANTIS_TPP_SECTION_NAME = "holstered_mantis_tpp";
            public const string HOLSTERED_MANTIS_FPP_SECTION_NAME = "holstered_mantis_fpp";
            public const string UNHOLSTERED_MANTIS_SECTION_NAME = "unholstered_mantis";
            public const string FPP_BODY_SECTION_NAME = "FPP_Body";
            public const string TPP_BODY_SECTION_NAME = "TPP_Body";
            public const string CHARACTER_CREATION_SECTION_NAME = "character_creation";
            public const string GENITALS_SECTION_NAME = "genitals";
            public const string BREAST_SECTION_NAME = "breast";
            public const string LIFTED_FEET_SECTION_NAME = "lifted_feet";
            public const string FLAT_FEET_SECTION_NAME = "flat_feet";
        }
        public static class NodeNames
        {
            public const string ARCADE_SYSTEM = "ArcadeSystem";
            public const string C_ATTITUDE_MANAGER = "CAttitudeManager";
            public const string C_COVER_MANAGER = "CCoverManager";
            public const string CHARACTER_CUSTOMIZATION_APPEARANCES_NODE = "CharacetrCustomization_Appearances";
            public const string CHOICES = "choices";
            public const string COMMUNITY_SYSTEM = "CommunitySystem";
            public const string CONTAINER_MANAGER = "ContainerManager";
            public const string CONTAINER_MANAGER_INJECTED_LOOT = "ContainerManager_InjectedLoot";
            public const string CONTAINER_MANAGER_LOOT_SLOT_AVAILABILITY = "ContainerManager_LootSlotAvailability";
            public const string CONTAINER_MANAGER_NPC_LOOT_BAGS_VER2 = "ContainerManager_NPCLootBags_Ver2";
            public const string CONTAINER_MANAGER_NPC_LOOT_BAGS_VER3_LOOTED_IDS = "ContainerManager_NPCLootBags_Ver3_LootedIDs";
            public const string CUSTOM_ARRAY = "customArray";
            public const string DELAY_SYSTEM = "DelaySystem";
            public const string DEVICE_SYSTEM = "DeviceSystem";
            public const string DIRECTOR_SYSTEM = "DirectorSystem";
            public const string DS_DYNAMIC_CONNECTIONS = "DS_DynamicConnections";
            public const string DYNAMIC_ENTITYID_SYSTEM = "DynamicEntityIDSystem";
            public const string EVENT_MANAGER = "eventManager";
            public const string FACTS_TABLE = "FactsTable";
            public const string FACTSDB = "FactsDB";
            public const string GAME_AUDIO = "GameAudio";
            public const string GAME_SESSION_CONFIG_NODE = "game::SessionConfig";
            public const string GAME_SESSION_DESC = "GameSessionDesc";
            public const string GOD_MODE_SYSTEM = "godModeSystem";
            public const string INVENTORY = "inventory";
            public const string ITEM_DATA = "itemData";
            public const string ITEM_DROP_STORAGE = "ItemDropStorage";
            public const string ITEM_DROP_STORAGE_MANAGER = "ItemDropStorageManager";
            public const string JOURNAL_MANAGER = "JournalManager";
            public const string MOVING_PLATFORM_SYSTEM = "MovingPlatformSystem";
            public const string MUSIC_SYSTEM = "MusicSystem";
            public const string PERSISTENCY_SYSTEM = "PersistencySystem";
            public const string PERSISTENCY_SYSTEM_2 = "PersistencySystem2";
            public const string PLAYER_SYSTEM = "PlayerSystem";
            public const string PS_DATA = "PSData";
            public const string QUEST_DEBUG_LOG_MANAGER = "questDebugLogManager";
            public const string QUEST_MUSIC_HISTORY = "QuestMusicHistory";
            public const string QUEST_SYSTEM = "questSystem";
            public const string RADIO_SYSTEM = "RadioSystem";
            public const string REACTION_SYSTEM = "ReactionSystem";
            public const string REACTION_SYSTEM_V2 = "ReactionSystem_v2";
            public const string RENDER_GAMEPLAY_EFFECTS_MANAGER_SYSTEM = "RenderGameplayEffectsManagerSystem";
            public const string SCANNING_CONTROLLER = "scanningController";
            public const string SCRIPTABLE_SYSTEMS_CONTAINER = "ScriptableSystemsContainer";
            public const string STAT_POOLS_SYSTEM = "StatPoolsSystem";
            public const string STATS_SYSTEM = "StatsSystem";
            public const string TIER_SYSTEM = "tierSystem";
            public const string TIME_CORE = "\"Core\"";
            public const string UNIQUE_ITEM_COUNTER = "UniqueItemCounter";
            public const string WARDROBE_SYSTEM = "WardrobeSystem";
            public const string WARDROBE_SYSTEM_CLOTHING_SETS = "WardrobeSystem_ClothingSets";
            public const string WORKSPOT_INSTANCES_SAVEDATA = "WorkspotInstancesSavedata";
        }
    }
}
