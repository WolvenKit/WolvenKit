using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3GameParams : CObject
	{
		[Ordinal(1)] [RED("dm")] 		public CHandle<CDefinitionsManagerAccessor> Dm { get; set;}

		[Ordinal(2)] [RED("main")] 		public SCustomNode Main { get; set;}

		[Ordinal(3)] [RED("BASE_ABILITY_TAG")] 		public CName BASE_ABILITY_TAG { get; set;}

		[Ordinal(4)] [RED("PASSIVE_BONUS_ABILITY_TAG")] 		public CName PASSIVE_BONUS_ABILITY_TAG { get; set;}

		[Ordinal(5)] [RED("forbiddenAttributes", 2,0)] 		public CArray<CName> ForbiddenAttributes { get; set;}

		[Ordinal(6)] [RED("GLOBAL_ENEMY_ABILITY")] 		public CName GLOBAL_ENEMY_ABILITY { get; set;}

		[Ordinal(7)] [RED("ENEMY_BONUS_PER_LEVEL")] 		public CName ENEMY_BONUS_PER_LEVEL { get; set;}

		[Ordinal(8)] [RED("ENEMY_BONUS_FISTFIGHT_LOW")] 		public CName ENEMY_BONUS_FISTFIGHT_LOW { get; set;}

		[Ordinal(9)] [RED("ENEMY_BONUS_FISTFIGHT_HIGH")] 		public CName ENEMY_BONUS_FISTFIGHT_HIGH { get; set;}

		[Ordinal(10)] [RED("ENEMY_BONUS_LOW")] 		public CName ENEMY_BONUS_LOW { get; set;}

		[Ordinal(11)] [RED("ENEMY_BONUS_HIGH")] 		public CName ENEMY_BONUS_HIGH { get; set;}

		[Ordinal(12)] [RED("ENEMY_BONUS_DEADLY")] 		public CName ENEMY_BONUS_DEADLY { get; set;}

		[Ordinal(13)] [RED("MONSTER_BONUS_PER_LEVEL")] 		public CName MONSTER_BONUS_PER_LEVEL { get; set;}

		[Ordinal(14)] [RED("MONSTER_BONUS_PER_LEVEL_GROUP")] 		public CName MONSTER_BONUS_PER_LEVEL_GROUP { get; set;}

		[Ordinal(15)] [RED("MONSTER_BONUS_PER_LEVEL_ARMORED")] 		public CName MONSTER_BONUS_PER_LEVEL_ARMORED { get; set;}

		[Ordinal(16)] [RED("MONSTER_BONUS_PER_LEVEL_GROUP_ARMORED")] 		public CName MONSTER_BONUS_PER_LEVEL_GROUP_ARMORED { get; set;}

		[Ordinal(17)] [RED("MONSTER_BONUS_LOW")] 		public CName MONSTER_BONUS_LOW { get; set;}

		[Ordinal(18)] [RED("MONSTER_BONUS_HIGH")] 		public CName MONSTER_BONUS_HIGH { get; set;}

		[Ordinal(19)] [RED("MONSTER_BONUS_DEADLY")] 		public CName MONSTER_BONUS_DEADLY { get; set;}

		[Ordinal(20)] [RED("BOSS_NGP_BONUS")] 		public CName BOSS_NGP_BONUS { get; set;}

		[Ordinal(21)] [RED("GLOBAL_PLAYER_ABILITY")] 		public CName GLOBAL_PLAYER_ABILITY { get; set;}

		[Ordinal(22)] [RED("NOT_A_SKILL_ABILITY_TAG")] 		public CName NOT_A_SKILL_ABILITY_TAG { get; set;}

		[Ordinal(23)] [RED("ALCHEMY_COOKED_ITEM_TYPE_POTION")] 		public CString ALCHEMY_COOKED_ITEM_TYPE_POTION { get; set;}

		[Ordinal(24)] [RED("ALCHEMY_COOKED_ITEM_TYPE_BOMB")] 		public CString ALCHEMY_COOKED_ITEM_TYPE_BOMB { get; set;}

		[Ordinal(25)] [RED("ALCHEMY_COOKED_ITEM_TYPE_OIL")] 		public CString ALCHEMY_COOKED_ITEM_TYPE_OIL { get; set;}

		[Ordinal(26)] [RED("OIL_ABILITY_TAG")] 		public CName OIL_ABILITY_TAG { get; set;}

		[Ordinal(27)] [RED("QUANTITY_INCREASED_BY_ALCHEMY_TABLE")] 		public CInt32 QUANTITY_INCREASED_BY_ALCHEMY_TABLE { get; set;}

		[Ordinal(28)] [RED("ATTACK_NAME_LIGHT")] 		public CName ATTACK_NAME_LIGHT { get; set;}

		[Ordinal(29)] [RED("ATTACK_NAME_HEAVY")] 		public CName ATTACK_NAME_HEAVY { get; set;}

		[Ordinal(30)] [RED("ATTACK_NAME_SUPERHEAVY")] 		public CName ATTACK_NAME_SUPERHEAVY { get; set;}

		[Ordinal(31)] [RED("ATTACK_NAME_SPEED_BASED")] 		public CName ATTACK_NAME_SPEED_BASED { get; set;}

		[Ordinal(32)] [RED("ATTACK_NO_DAMAGE")] 		public CName ATTACK_NO_DAMAGE { get; set;}

		[Ordinal(33)] [RED("MAX_DYNAMICALLY_SPAWNED_BOATS")] 		public CInt32 MAX_DYNAMICALLY_SPAWNED_BOATS { get; set;}

		[Ordinal(34)] [RED("MAX_THROW_RANGE")] 		public CFloat MAX_THROW_RANGE { get; set;}

		[Ordinal(35)] [RED("UNDERWATER_THROW_RANGE")] 		public CFloat UNDERWATER_THROW_RANGE { get; set;}

		[Ordinal(36)] [RED("PROXIMITY_PETARD_IDLE_DETONATION_TIME")] 		public CFloat PROXIMITY_PETARD_IDLE_DETONATION_TIME { get; set;}

		[Ordinal(37)] [RED("BOMB_THROW_DELAY")] 		public CFloat BOMB_THROW_DELAY { get; set;}

		[Ordinal(38)] [RED("CONTAINER_DYNAMIC_DESTROY_TIMEOUT")] 		public CInt32 CONTAINER_DYNAMIC_DESTROY_TIMEOUT { get; set;}

		[Ordinal(39)] [RED("CRITICAL_HIT_CHANCE")] 		public CName CRITICAL_HIT_CHANCE { get; set;}

		[Ordinal(40)] [RED("CRITICAL_HIT_DAMAGE_BONUS")] 		public CName CRITICAL_HIT_DAMAGE_BONUS { get; set;}

		[Ordinal(41)] [RED("CRITICAL_HIT_REDUCTION")] 		public CName CRITICAL_HIT_REDUCTION { get; set;}

		[Ordinal(42)] [RED("CRITICAL_HIT_FX")] 		public CName CRITICAL_HIT_FX { get; set;}

		[Ordinal(43)] [RED("HEAD_SHOT_CRIT_CHANCE_BONUS")] 		public CFloat HEAD_SHOT_CRIT_CHANCE_BONUS { get; set;}

		[Ordinal(44)] [RED("BACK_ATTACK_CRIT_CHANCE_BONUS")] 		public CFloat BACK_ATTACK_CRIT_CHANCE_BONUS { get; set;}

		[Ordinal(45)] [RED("DAMAGE_NAME_DIRECT")] 		public CName DAMAGE_NAME_DIRECT { get; set;}

		[Ordinal(46)] [RED("DAMAGE_NAME_PHYSICAL")] 		public CName DAMAGE_NAME_PHYSICAL { get; set;}

		[Ordinal(47)] [RED("DAMAGE_NAME_SILVER")] 		public CName DAMAGE_NAME_SILVER { get; set;}

		[Ordinal(48)] [RED("DAMAGE_NAME_SLASHING")] 		public CName DAMAGE_NAME_SLASHING { get; set;}

		[Ordinal(49)] [RED("DAMAGE_NAME_PIERCING")] 		public CName DAMAGE_NAME_PIERCING { get; set;}

		[Ordinal(50)] [RED("DAMAGE_NAME_BLUDGEONING")] 		public CName DAMAGE_NAME_BLUDGEONING { get; set;}

		[Ordinal(51)] [RED("DAMAGE_NAME_RENDING")] 		public CName DAMAGE_NAME_RENDING { get; set;}

		[Ordinal(52)] [RED("DAMAGE_NAME_ELEMENTAL")] 		public CName DAMAGE_NAME_ELEMENTAL { get; set;}

		[Ordinal(53)] [RED("DAMAGE_NAME_FIRE")] 		public CName DAMAGE_NAME_FIRE { get; set;}

		[Ordinal(54)] [RED("DAMAGE_NAME_FORCE")] 		public CName DAMAGE_NAME_FORCE { get; set;}

		[Ordinal(55)] [RED("DAMAGE_NAME_FROST")] 		public CName DAMAGE_NAME_FROST { get; set;}

		[Ordinal(56)] [RED("DAMAGE_NAME_POISON")] 		public CName DAMAGE_NAME_POISON { get; set;}

		[Ordinal(57)] [RED("DAMAGE_NAME_SHOCK")] 		public CName DAMAGE_NAME_SHOCK { get; set;}

		[Ordinal(58)] [RED("DAMAGE_NAME_MORALE")] 		public CName DAMAGE_NAME_MORALE { get; set;}

		[Ordinal(59)] [RED("DAMAGE_NAME_STAMINA")] 		public CName DAMAGE_NAME_STAMINA { get; set;}

		[Ordinal(60)] [RED("FOCUS_DRAIN_PER_HIT")] 		public CFloat FOCUS_DRAIN_PER_HIT { get; set;}

		[Ordinal(61)] [RED("UNINTERRUPTED_HITS_CAMERA_EFFECT_REGULAR_ENEMY")] 		public CName UNINTERRUPTED_HITS_CAMERA_EFFECT_REGULAR_ENEMY { get; set;}

		[Ordinal(62)] [RED("UNINTERRUPTED_HITS_CAMERA_EFFECT_BIG_ENEMY")] 		public CName UNINTERRUPTED_HITS_CAMERA_EFFECT_BIG_ENEMY { get; set;}

		[Ordinal(63)] [RED("MONSTER_RESIST_THRESHOLD_TO_REFLECT_FISTS")] 		public CFloat MONSTER_RESIST_THRESHOLD_TO_REFLECT_FISTS { get; set;}

		[Ordinal(64)] [RED("ARMOR_VALUE_NAME")] 		public CName ARMOR_VALUE_NAME { get; set;}

		[Ordinal(65)] [RED("LOW_HEALTH_EFFECT_SHOW")] 		public CFloat LOW_HEALTH_EFFECT_SHOW { get; set;}

		[Ordinal(66)] [RED("UNDERWATER_CROSSBOW_DAMAGE_BONUS")] 		public CFloat UNDERWATER_CROSSBOW_DAMAGE_BONUS { get; set;}

		[Ordinal(67)] [RED("UNDERWATER_CROSSBOW_DAMAGE_BONUS_NGP")] 		public CFloat UNDERWATER_CROSSBOW_DAMAGE_BONUS_NGP { get; set;}

		[Ordinal(68)] [RED("ARCHER_DAMAGE_BONUS_NGP")] 		public CFloat ARCHER_DAMAGE_BONUS_NGP { get; set;}

		[Ordinal(69)] [RED("IGNI_SPELL_POWER_MILT")] 		public CFloat IGNI_SPELL_POWER_MILT { get; set;}

		[Ordinal(70)] [RED("INSTANT_KILL_INTERNAL_PLAYER_COOLDOWN")] 		public CFloat INSTANT_KILL_INTERNAL_PLAYER_COOLDOWN { get; set;}

		[Ordinal(71)] [RED("DIFFICULTY_TAG_EASY")] 		public CName DIFFICULTY_TAG_EASY { get; set;}

		[Ordinal(72)] [RED("DIFFICULTY_TAG_MEDIUM")] 		public CName DIFFICULTY_TAG_MEDIUM { get; set;}

		[Ordinal(73)] [RED("DIFFICULTY_TAG_HARD")] 		public CName DIFFICULTY_TAG_HARD { get; set;}

		[Ordinal(74)] [RED("DIFFICULTY_TAG_HARDCORE")] 		public CName DIFFICULTY_TAG_HARDCORE { get; set;}

		[Ordinal(75)] [RED("DIFFICULTY_TAG_DIFF_ABILITY")] 		public CName DIFFICULTY_TAG_DIFF_ABILITY { get; set;}

		[Ordinal(76)] [RED("DIFFICULTY_HP_MULTIPLIER")] 		public CName DIFFICULTY_HP_MULTIPLIER { get; set;}

		[Ordinal(77)] [RED("DIFFICULTY_DMG_MULTIPLIER")] 		public CName DIFFICULTY_DMG_MULTIPLIER { get; set;}

		[Ordinal(78)] [RED("DIFFICULTY_TAG_IGNORE")] 		public CName DIFFICULTY_TAG_IGNORE { get; set;}

		[Ordinal(79)] [RED("DISMEMBERMENT_ON_DEATH_CHANCE")] 		public CInt32 DISMEMBERMENT_ON_DEATH_CHANCE { get; set;}

		[Ordinal(80)] [RED("FINISHER_ON_DEATH_CHANCE")] 		public CInt32 FINISHER_ON_DEATH_CHANCE { get; set;}

		[Ordinal(81)] [RED("DURABILITY_ARMOR_LOSE_CHANCE")] 		public CInt32 DURABILITY_ARMOR_LOSE_CHANCE { get; set;}

		[Ordinal(82)] [RED("DURABILITY_WEAPON_LOSE_CHANCE")] 		public CInt32 DURABILITY_WEAPON_LOSE_CHANCE { get; set;}

		[Ordinal(83)] [RED("DURABILITY_ARMOR_LOSE_VALUE")] 		public CFloat DURABILITY_ARMOR_LOSE_VALUE { get; set;}

		[Ordinal(84)] [RED("DURABILITY_WEAPON_LOSE_VALUE")] 		public CFloat DURABILITY_WEAPON_LOSE_VALUE { get; set;}

		[Ordinal(85)] [RED("DURABILITY_WEAPON_LOSE_VALUE_HARDCORE")] 		public CFloat DURABILITY_WEAPON_LOSE_VALUE_HARDCORE { get; set;}

		[Ordinal(86)] [RED("DURABILITY_ARMOR_CHEST_WEIGHT")] 		public CInt32 DURABILITY_ARMOR_CHEST_WEIGHT { get; set;}

		[Ordinal(87)] [RED("DURABILITY_ARMOR_PANTS_WEIGHT")] 		public CInt32 DURABILITY_ARMOR_PANTS_WEIGHT { get; set;}

		[Ordinal(88)] [RED("DURABILITY_ARMOR_BOOTS_WEIGHT")] 		public CInt32 DURABILITY_ARMOR_BOOTS_WEIGHT { get; set;}

		[Ordinal(89)] [RED("DURABILITY_ARMOR_GLOVES_WEIGHT")] 		public CInt32 DURABILITY_ARMOR_GLOVES_WEIGHT { get; set;}

		[Ordinal(90)] [RED("DURABILITY_ARMOR_MISS_WEIGHT")] 		public CInt32 DURABILITY_ARMOR_MISS_WEIGHT { get; set;}

		[Ordinal(91)] [RED("durabilityThresholdsWeapon", 2,0)] 		public CArray<SDurabilityThreshold> DurabilityThresholdsWeapon { get; set;}

		[Ordinal(92)] [RED("durabilityThresholdsArmor", 2,0)] 		public CArray<SDurabilityThreshold> DurabilityThresholdsArmor { get; set;}

		[Ordinal(93)] [RED("TAG_REPAIR_CONSUMABLE_ARMOR")] 		public CName TAG_REPAIR_CONSUMABLE_ARMOR { get; set;}

		[Ordinal(94)] [RED("TAG_REPAIR_CONSUMABLE_STEEL")] 		public CName TAG_REPAIR_CONSUMABLE_STEEL { get; set;}

		[Ordinal(95)] [RED("TAG_REPAIR_CONSUMABLE_SILVER")] 		public CName TAG_REPAIR_CONSUMABLE_SILVER { get; set;}

		[Ordinal(96)] [RED("ITEM_DAMAGED_DURABILITY")] 		public CInt32 ITEM_DAMAGED_DURABILITY { get; set;}

		[Ordinal(97)] [RED("INTERACTIVE_REPAIR_OBJECT_MAX_DURS", 2,0)] 		public CArray<CInt32> INTERACTIVE_REPAIR_OBJECT_MAX_DURS { get; set;}

		[Ordinal(98)] [RED("CFM_SLOWDOWN_RATIO")] 		public CFloat CFM_SLOWDOWN_RATIO { get; set;}

		[Ordinal(99)] [RED("LIGHT_HIT_FX")] 		public CName LIGHT_HIT_FX { get; set;}

		[Ordinal(100)] [RED("LIGHT_HIT_BACK_FX")] 		public CName LIGHT_HIT_BACK_FX { get; set;}

		[Ordinal(101)] [RED("LIGHT_HIT_PARRIED_FX")] 		public CName LIGHT_HIT_PARRIED_FX { get; set;}

		[Ordinal(102)] [RED("LIGHT_HIT_BACK_PARRIED_FX")] 		public CName LIGHT_HIT_BACK_PARRIED_FX { get; set;}

		[Ordinal(103)] [RED("HEAVY_HIT_FX")] 		public CName HEAVY_HIT_FX { get; set;}

		[Ordinal(104)] [RED("HEAVY_HIT_BACK_FX")] 		public CName HEAVY_HIT_BACK_FX { get; set;}

		[Ordinal(105)] [RED("HEAVY_HIT_PARRIED_FX")] 		public CName HEAVY_HIT_PARRIED_FX { get; set;}

		[Ordinal(106)] [RED("HEAVY_HIT_BACK_PARRIED_FX")] 		public CName HEAVY_HIT_BACK_PARRIED_FX { get; set;}

		[Ordinal(107)] [RED("LOW_HP_SHOW_LEVEL")] 		public CFloat LOW_HP_SHOW_LEVEL { get; set;}

		[Ordinal(108)] [RED("TAG_ARMOR")] 		public CName TAG_ARMOR { get; set;}

		[Ordinal(109)] [RED("TAG_ENCUMBRANCE_ITEM_FORCE_YES")] 		public CName TAG_ENCUMBRANCE_ITEM_FORCE_YES { get; set;}

		[Ordinal(110)] [RED("TAG_ENCUMBRANCE_ITEM_FORCE_NO")] 		public CName TAG_ENCUMBRANCE_ITEM_FORCE_NO { get; set;}

		[Ordinal(111)] [RED("TAG_ITEM_UPGRADEABLE")] 		public CName TAG_ITEM_UPGRADEABLE { get; set;}

		[Ordinal(112)] [RED("TAG_DONT_SHOW")] 		public CName TAG_DONT_SHOW { get; set;}

		[Ordinal(113)] [RED("TAG_DONT_SHOW_ONLY_IN_PLAYERS")] 		public CName TAG_DONT_SHOW_ONLY_IN_PLAYERS { get; set;}

		[Ordinal(114)] [RED("TAG_ITEM_SINGLETON")] 		public CName TAG_ITEM_SINGLETON { get; set;}

		[Ordinal(115)] [RED("TAG_INFINITE_AMMO")] 		public CName TAG_INFINITE_AMMO { get; set;}

		[Ordinal(116)] [RED("TAG_UNDERWATER_AMMO")] 		public CName TAG_UNDERWATER_AMMO { get; set;}

		[Ordinal(117)] [RED("TAG_GROUND_AMMO")] 		public CName TAG_GROUND_AMMO { get; set;}

		[Ordinal(118)] [RED("TAG_ILLUSION_MEDALLION")] 		public CName TAG_ILLUSION_MEDALLION { get; set;}

		[Ordinal(119)] [RED("TAG_PLAYER_STEELSWORD")] 		public CName TAG_PLAYER_STEELSWORD { get; set;}

		[Ordinal(120)] [RED("TAG_PLAYER_SILVERSWORD")] 		public CName TAG_PLAYER_SILVERSWORD { get; set;}

		[Ordinal(121)] [RED("TAG_INFINITE_USE")] 		public CName TAG_INFINITE_USE { get; set;}

		[Ordinal(122)] [RED("ARMOR_MASTERWORK_ABILITIES", 2,0)] 		public CArray<CName> ARMOR_MASTERWORK_ABILITIES { get; set;}

		[Ordinal(123)] [RED("ARMOR_MAGICAL_ABILITIES", 2,0)] 		public CArray<CName> ARMOR_MAGICAL_ABILITIES { get; set;}

		[Ordinal(124)] [RED("GLOVES_MASTERWORK_ABILITIES", 2,0)] 		public CArray<CName> GLOVES_MASTERWORK_ABILITIES { get; set;}

		[Ordinal(125)] [RED("GLOVES_MAGICAL_ABILITIES", 2,0)] 		public CArray<CName> GLOVES_MAGICAL_ABILITIES { get; set;}

		[Ordinal(126)] [RED("PANTS_MASTERWORK_ABILITIES", 2,0)] 		public CArray<CName> PANTS_MASTERWORK_ABILITIES { get; set;}

		[Ordinal(127)] [RED("PANTS_MAGICAL_ABILITIES", 2,0)] 		public CArray<CName> PANTS_MAGICAL_ABILITIES { get; set;}

		[Ordinal(128)] [RED("BOOTS_MASTERWORK_ABILITIES", 2,0)] 		public CArray<CName> BOOTS_MASTERWORK_ABILITIES { get; set;}

		[Ordinal(129)] [RED("BOOTS_MAGICAL_ABILITIES", 2,0)] 		public CArray<CName> BOOTS_MAGICAL_ABILITIES { get; set;}

		[Ordinal(130)] [RED("WEAPON_MASTERWORK_ABILITIES", 2,0)] 		public CArray<CName> WEAPON_MASTERWORK_ABILITIES { get; set;}

		[Ordinal(131)] [RED("WEAPON_MAGICAL_ABILITIES", 2,0)] 		public CArray<CName> WEAPON_MAGICAL_ABILITIES { get; set;}

		[Ordinal(132)] [RED("ITEM_SET_TAG_BEAR")] 		public CName ITEM_SET_TAG_BEAR { get; set;}

		[Ordinal(133)] [RED("ITEM_SET_TAG_GRYPHON")] 		public CName ITEM_SET_TAG_GRYPHON { get; set;}

		[Ordinal(134)] [RED("ITEM_SET_TAG_LYNX")] 		public CName ITEM_SET_TAG_LYNX { get; set;}

		[Ordinal(135)] [RED("ITEM_SET_TAG_WOLF")] 		public CName ITEM_SET_TAG_WOLF { get; set;}

		[Ordinal(136)] [RED("ITEM_SET_TAG_RED_WOLF")] 		public CName ITEM_SET_TAG_RED_WOLF { get; set;}

		[Ordinal(137)] [RED("ITEM_SET_TAG_VAMPIRE")] 		public CName ITEM_SET_TAG_VAMPIRE { get; set;}

		[Ordinal(138)] [RED("ITEM_SET_TAG_VIPER")] 		public CName ITEM_SET_TAG_VIPER { get; set;}

		[Ordinal(139)] [RED("BOUNCE_ARROWS_ABILITY")] 		public CName BOUNCE_ARROWS_ABILITY { get; set;}

		[Ordinal(140)] [RED("TAG_ALCHEMY_REFILL_ALCO")] 		public CName TAG_ALCHEMY_REFILL_ALCO { get; set;}

		[Ordinal(141)] [RED("REPAIR_OBJECT_BONUS_ARMOR_ABILITY")] 		public CName REPAIR_OBJECT_BONUS_ARMOR_ABILITY { get; set;}

		[Ordinal(142)] [RED("REPAIR_OBJECT_BONUS_WEAPON_ABILITY")] 		public CName REPAIR_OBJECT_BONUS_WEAPON_ABILITY { get; set;}

		[Ordinal(143)] [RED("REPAIR_OBJECT_BONUS")] 		public CName REPAIR_OBJECT_BONUS { get; set;}

		[Ordinal(144)] [RED("CIRI_SWORD_NAME")] 		public CName CIRI_SWORD_NAME { get; set;}

		[Ordinal(145)] [RED("TAG_OFIR_SET")] 		public CName TAG_OFIR_SET { get; set;}

		[Ordinal(146)] [RED("newGamePlusLevel")] 		public CInt32 NewGamePlusLevel { get; set;}

		[Ordinal(147)] [RED("NEW_GAME_PLUS_LEVEL_ADD")] 		public CInt32 NEW_GAME_PLUS_LEVEL_ADD { get; set;}

		[Ordinal(148)] [RED("NEW_GAME_PLUS_MIN_LEVEL")] 		public CInt32 NEW_GAME_PLUS_MIN_LEVEL { get; set;}

		[Ordinal(149)] [RED("NEW_GAME_PLUS_EP1_MIN_LEVEL")] 		public CInt32 NEW_GAME_PLUS_EP1_MIN_LEVEL { get; set;}

		[Ordinal(150)] [RED("TAG_STEEL_OIL")] 		public CName TAG_STEEL_OIL { get; set;}

		[Ordinal(151)] [RED("TAG_SILVER_OIL")] 		public CName TAG_SILVER_OIL { get; set;}

		[Ordinal(152)] [RED("HEAVY_STRIKE_COST_MULTIPLIER")] 		public CFloat HEAVY_STRIKE_COST_MULTIPLIER { get; set;}

		[Ordinal(153)] [RED("PARRY_HALF_ANGLE")] 		public CInt32 PARRY_HALF_ANGLE { get; set;}

		[Ordinal(154)] [RED("PARRY_STAGGER_REDUCE_DAMAGE_LARGE")] 		public CFloat PARRY_STAGGER_REDUCE_DAMAGE_LARGE { get; set;}

		[Ordinal(155)] [RED("PARRY_STAGGER_REDUCE_DAMAGE_SMALL")] 		public CFloat PARRY_STAGGER_REDUCE_DAMAGE_SMALL { get; set;}

		[Ordinal(156)] [RED("POTION_QUICKSLOTS_COUNT")] 		public CInt32 POTION_QUICKSLOTS_COUNT { get; set;}

		[Ordinal(157)] [RED("ITEMS_REQUIRED_FOR_MINOR_SET_BONUS")] 		public CInt32 ITEMS_REQUIRED_FOR_MINOR_SET_BONUS { get; set;}

		[Ordinal(158)] [RED("ITEMS_REQUIRED_FOR_MAJOR_SET_BONUS")] 		public CInt32 ITEMS_REQUIRED_FOR_MAJOR_SET_BONUS { get; set;}

		[Ordinal(159)] [RED("ITEM_SET_TAG_BONUS")] 		public CName ITEM_SET_TAG_BONUS { get; set;}

		[Ordinal(160)] [RED("TAG_STEEL_SOCKETABLE")] 		public CName TAG_STEEL_SOCKETABLE { get; set;}

		[Ordinal(161)] [RED("TAG_SILVER_SOCKETABLE")] 		public CName TAG_SILVER_SOCKETABLE { get; set;}

		[Ordinal(162)] [RED("TAG_ARMOR_SOCKETABLE")] 		public CName TAG_ARMOR_SOCKETABLE { get; set;}

		[Ordinal(163)] [RED("TAG_ABILITY_SOCKET")] 		public CName TAG_ABILITY_SOCKET { get; set;}

		[Ordinal(164)] [RED("STAMINA_COST_PARRY_ATTRIBUTE")] 		public CName STAMINA_COST_PARRY_ATTRIBUTE { get; set;}

		[Ordinal(165)] [RED("STAMINA_COST_COUNTERATTACK_ATTRIBUTE")] 		public CName STAMINA_COST_COUNTERATTACK_ATTRIBUTE { get; set;}

		[Ordinal(166)] [RED("STAMINA_COST_EVADE_ATTRIBUTE")] 		public CName STAMINA_COST_EVADE_ATTRIBUTE { get; set;}

		[Ordinal(167)] [RED("STAMINA_COST_SWIMMING_PER_SEC_ATTRIBUTE")] 		public CName STAMINA_COST_SWIMMING_PER_SEC_ATTRIBUTE { get; set;}

		[Ordinal(168)] [RED("STAMINA_COST_SUPER_HEAVY_ACTION_ATTRIBUTE")] 		public CName STAMINA_COST_SUPER_HEAVY_ACTION_ATTRIBUTE { get; set;}

		[Ordinal(169)] [RED("STAMINA_COST_HEAVY_ACTION_ATTRIBUTE")] 		public CName STAMINA_COST_HEAVY_ACTION_ATTRIBUTE { get; set;}

		[Ordinal(170)] [RED("STAMINA_COST_LIGHT_ACTION_ATTRIBUTE")] 		public CName STAMINA_COST_LIGHT_ACTION_ATTRIBUTE { get; set;}

		[Ordinal(171)] [RED("STAMINA_COST_DODGE_ATTRIBUTE")] 		public CName STAMINA_COST_DODGE_ATTRIBUTE { get; set;}

		[Ordinal(172)] [RED("STAMINA_COST_SPRINT_ATTRIBUTE")] 		public CName STAMINA_COST_SPRINT_ATTRIBUTE { get; set;}

		[Ordinal(173)] [RED("STAMINA_COST_SPRINT_PER_SEC_ATTRIBUTE")] 		public CName STAMINA_COST_SPRINT_PER_SEC_ATTRIBUTE { get; set;}

		[Ordinal(174)] [RED("STAMINA_COST_JUMP_ATTRIBUTE")] 		public CName STAMINA_COST_JUMP_ATTRIBUTE { get; set;}

		[Ordinal(175)] [RED("STAMINA_COST_USABLE_ITEM_ATTRIBUTE")] 		public CName STAMINA_COST_USABLE_ITEM_ATTRIBUTE { get; set;}

		[Ordinal(176)] [RED("STAMINA_COST_DEFAULT")] 		public CName STAMINA_COST_DEFAULT { get; set;}

		[Ordinal(177)] [RED("STAMINA_COST_PER_SEC_DEFAULT")] 		public CName STAMINA_COST_PER_SEC_DEFAULT { get; set;}

		[Ordinal(178)] [RED("STAMINA_COST_ROLL_ATTRIBUTE")] 		public CName STAMINA_COST_ROLL_ATTRIBUTE { get; set;}

		[Ordinal(179)] [RED("STAMINA_COST_LIGHT_SPECIAL_ATTRIBUTE")] 		public CName STAMINA_COST_LIGHT_SPECIAL_ATTRIBUTE { get; set;}

		[Ordinal(180)] [RED("STAMINA_COST_HEAVY_SPECIAL_ATTRIBUTE")] 		public CName STAMINA_COST_HEAVY_SPECIAL_ATTRIBUTE { get; set;}

		[Ordinal(181)] [RED("STAMINA_DELAY_PARRY_ATTRIBUTE")] 		public CName STAMINA_DELAY_PARRY_ATTRIBUTE { get; set;}

		[Ordinal(182)] [RED("STAMINA_DELAY_COUNTERATTACK_ATTRIBUTE")] 		public CName STAMINA_DELAY_COUNTERATTACK_ATTRIBUTE { get; set;}

		[Ordinal(183)] [RED("STAMINA_DELAY_EVADE_ATTRIBUTE")] 		public CName STAMINA_DELAY_EVADE_ATTRIBUTE { get; set;}

		[Ordinal(184)] [RED("STAMINA_DELAY_SWIMMING_ATTRIBUTE")] 		public CName STAMINA_DELAY_SWIMMING_ATTRIBUTE { get; set;}

		[Ordinal(185)] [RED("STAMINA_DELAY_SUPER_HEAVY_ACTION_ATTRIBUTE")] 		public CName STAMINA_DELAY_SUPER_HEAVY_ACTION_ATTRIBUTE { get; set;}

		[Ordinal(186)] [RED("STAMINA_DELAY_HEAVY_ACTION_ATTRIBUTE")] 		public CName STAMINA_DELAY_HEAVY_ACTION_ATTRIBUTE { get; set;}

		[Ordinal(187)] [RED("STAMINA_DELAY_LIGHT_ACTION_ATTRIBUTE")] 		public CName STAMINA_DELAY_LIGHT_ACTION_ATTRIBUTE { get; set;}

		[Ordinal(188)] [RED("STAMINA_DELAY_DODGE_ATTRIBUTE")] 		public CName STAMINA_DELAY_DODGE_ATTRIBUTE { get; set;}

		[Ordinal(189)] [RED("STAMINA_DELAY_SPRINT_ATTRIBUTE")] 		public CName STAMINA_DELAY_SPRINT_ATTRIBUTE { get; set;}

		[Ordinal(190)] [RED("STAMINA_DELAY_JUMP_ATTRIBUTE")] 		public CName STAMINA_DELAY_JUMP_ATTRIBUTE { get; set;}

		[Ordinal(191)] [RED("STAMINA_DELAY_USABLE_ITEM_ATTRIBUTE")] 		public CName STAMINA_DELAY_USABLE_ITEM_ATTRIBUTE { get; set;}

		[Ordinal(192)] [RED("STAMINA_DELAY_DEFAULT")] 		public CName STAMINA_DELAY_DEFAULT { get; set;}

		[Ordinal(193)] [RED("STAMINA_DELAY_ROLL_ATTRIBUTE")] 		public CName STAMINA_DELAY_ROLL_ATTRIBUTE { get; set;}

		[Ordinal(194)] [RED("STAMINA_DELAY_LIGHT_SPECIAL_ATTRIBUTE")] 		public CName STAMINA_DELAY_LIGHT_SPECIAL_ATTRIBUTE { get; set;}

		[Ordinal(195)] [RED("STAMINA_DELAY_HEAVY_SPECIAL_ATTRIBUTE")] 		public CName STAMINA_DELAY_HEAVY_SPECIAL_ATTRIBUTE { get; set;}

		[Ordinal(196)] [RED("STAMINA_SEGMENT_SIZE")] 		public CInt32 STAMINA_SEGMENT_SIZE { get; set;}

		[Ordinal(197)] [RED("TOXICITY_DAMAGE_THRESHOLD")] 		public CFloat TOXICITY_DAMAGE_THRESHOLD { get; set;}

		[Ordinal(198)] [RED("DEBUG_CHEATS_ENABLED")] 		public CBool DEBUG_CHEATS_ENABLED { get; set;}

		[Ordinal(199)] [RED("SKILL_GLOBAL_PASSIVE_TAG")] 		public CName SKILL_GLOBAL_PASSIVE_TAG { get; set;}

		[Ordinal(200)] [RED("TAG_OPEN_FIRE")] 		public CName TAG_OPEN_FIRE { get; set;}

		[Ordinal(201)] [RED("TAG_MONSTER_SKILL")] 		public CName TAG_MONSTER_SKILL { get; set;}

		[Ordinal(202)] [RED("TAG_EXPLODING_GAS")] 		public CName TAG_EXPLODING_GAS { get; set;}

		[Ordinal(203)] [RED("ON_HIT_HP_REGEN_DELAY")] 		public CFloat ON_HIT_HP_REGEN_DELAY { get; set;}

		[Ordinal(204)] [RED("TAG_NPC_IN_PARTY")] 		public CName TAG_NPC_IN_PARTY { get; set;}

		[Ordinal(205)] [RED("TAG_PLAYERS_MOUNTED_VEHICLE")] 		public CName TAG_PLAYERS_MOUNTED_VEHICLE { get; set;}

		[Ordinal(206)] [RED("TAG_SOFT_LOCK")] 		public CName TAG_SOFT_LOCK { get; set;}

		[Ordinal(207)] [RED("MAX_SPELLPOWER_ASSUMED")] 		public CFloat MAX_SPELLPOWER_ASSUMED { get; set;}

		[Ordinal(208)] [RED("NPC_RESIST_PER_LEVEL")] 		public CFloat NPC_RESIST_PER_LEVEL { get; set;}

		[Ordinal(209)] [RED("XP_PER_LEVEL")] 		public CInt32 XP_PER_LEVEL { get; set;}

		[Ordinal(210)] [RED("XP_MINIBOSS_BONUS")] 		public CFloat XP_MINIBOSS_BONUS { get; set;}

		[Ordinal(211)] [RED("XP_BOSS_BONUS")] 		public CFloat XP_BOSS_BONUS { get; set;}

		[Ordinal(212)] [RED("ADRENALINE_DRAIN_AFTER_COMBAT_DELAY")] 		public CFloat ADRENALINE_DRAIN_AFTER_COMBAT_DELAY { get; set;}

		[Ordinal(213)] [RED("KEYBOARD_KEY_FONT_COLOR")] 		public CString KEYBOARD_KEY_FONT_COLOR { get; set;}

		[Ordinal(214)] [RED("MONSTER_HUNT_ACTOR_TAG")] 		public CName MONSTER_HUNT_ACTOR_TAG { get; set;}

		[Ordinal(215)] [RED("GWINT_CARD_ACHIEVEMENT_TAG")] 		public CName GWINT_CARD_ACHIEVEMENT_TAG { get; set;}

		[Ordinal(216)] [RED("TAG_AXIIABLE")] 		public CName TAG_AXIIABLE { get; set;}

		[Ordinal(217)] [RED("TAG_AXIIABLE_LOWER_CASE")] 		public CName TAG_AXIIABLE_LOWER_CASE { get; set;}

		[Ordinal(218)] [RED("LEVEL_DIFF_DEADLY")] 		public CInt32 LEVEL_DIFF_DEADLY { get; set;}

		[Ordinal(219)] [RED("LEVEL_DIFF_HIGH")] 		public CInt32 LEVEL_DIFF_HIGH { get; set;}

		[Ordinal(220)] [RED("LEVEL_DIFF_XP_MOD")] 		public CFloat LEVEL_DIFF_XP_MOD { get; set;}

		[Ordinal(221)] [RED("MAX_XP_MOD")] 		public CFloat MAX_XP_MOD { get; set;}

		[Ordinal(222)] [RED("DEVIL_HORSE_AURA_MIN_DELAY")] 		public CInt32 DEVIL_HORSE_AURA_MIN_DELAY { get; set;}

		[Ordinal(223)] [RED("DEVIL_HORSE_AURA_MAX_DELAY")] 		public CInt32 DEVIL_HORSE_AURA_MAX_DELAY { get; set;}

		[Ordinal(224)] [RED("TOTAL_AMOUNT_OF_BOOKS")] 		public CInt32 TOTAL_AMOUNT_OF_BOOKS { get; set;}

		[Ordinal(225)] [RED("MAX_PLAYER_LEVEL")] 		public CInt32 MAX_PLAYER_LEVEL { get; set;}

		public W3GameParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3GameParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}