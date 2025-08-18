using System.Collections.Generic;

namespace WolvenKit.App;

public static class Constants
{
    public const string ProductName = "WolvenKit";
    public const string AssemblyName = ProductName + ".dll";
    public const string AppProductName = ProductName;
    public const string AppName = ProductName + ".exe";
    public const string ModDirectoryTop = "ModDirectoryTop";
    public const string RawDirectoryTop = "RawDirectoryTop";
    public const string ResourceDirectoryTop = "ResourceDirectoryTop";
}

public static class PhotomodeEntityAnimations
{
    public static readonly List<string> RootComponentFemale =
    [
        @"base\animations\npc\generic_characters\female_average\crowd_reactions\wa_default_crowd_reaction.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_reaction_ranged_impact.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_reaction_defeated.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_reaction_ranged_prone_to_stand.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_reaction_ranged_stagger.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_reaction_ranged_supine_to_stand.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_ranged_twitch.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_reaction_base.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_body_carry.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_body_carry_strong.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_body_carry_friendly.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_reaction_melee_stagger.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_reaction_melee_impact.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_locomotion_stealth.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_exploration_relaxed.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_status_effects.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_reaction_ranged_death.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_reaction_ranged_knockdown.anims",
        @"base\animations\vehicle\generic\ma_generic_driver.anims",
        @"base\animations\vehicle\generic\ma_generic_passenger_r.anims",
        @"base\animations\vehicle\generic\ma_generic_passenger_l.anims",
        @"base\animations\vehicle\generic\ma_generic_passenger_r.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_ragdoll_recovery.anims",
        @"base\animations\npc\generic_characters\female_average\locomotion\crowd\fa_old_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\female_average\locomotion\generic_average_female_locomotion.anims",
        @"base\animations\synced\lore\wa_lore.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_locomotion_combat.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_action_combat.anims",
        @"base\animations\npc\gameplay\woman_average\gang\rifle\wa_gang_rifle_locomotion_combat.anims",
        @"base\animations\npc\gameplay\woman_average\gang\handgunboth\wa_gang_handgunboth_action_combat.anims",
        @"base\animations\npc\gameplay\woman_average\gang\revolver\wa_gang_revolver_action_combat.anims",
        @"base\animations\npc\gameplay\woman_average\gang\handgunboth\wa_gang_handgunboth_action_combat.anims",
        @"base\animations\npc\gameplay\woman_average\civilian\unarmed\wa_civilian_unarmed_action_combat.anims",
        @"base\animations\npc\gameplay\woman_average\gang\rifle\wa_gang_rifle_locomotion_combat.anims",
        @"base\animations\npc\gameplay\woman_average\gang\unarmed\wa_gang_unarmed_reaction_death.anims",
        @"base\animations\vehicle\generic\generic_bike.anims",
        @"base\animations\vehicle\generic\generic_bike.anims",
        @"base\animations\vehicle\generic\generic_bike.anims",
        @"base\animations\ui\photomode\photomode__female__idle.anims",
        @"base\animations\ui\photomode\photomode__female__action.anims",
        @"base\animations\ui\photomode\photomode__v_female__natural.anims",
    ];

    public static readonly List<string> RootComponentMale =
    [
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_ranged_impact.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_ranged_knockdown.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_defeated.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_ranged_prone_to_stand.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_ranged_stagger.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_ranged_supine_to_stand.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_ranged_twitch.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_ranged_death.anims",
        @"base\animations\npc\generic_characters\male_average\crowd_reactions\default_crowd_reaction.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_body_carry.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_body_carry_strong.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_body_carry_friendly.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_melee_impact.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_ranged_prone_to_stand.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_ranged_supine_to_stand.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_melee_stagger.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_base.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_exploration_relaxed.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_status_effects.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_locomotion_stealth.anims",
        @"base\animations\vehicle\generic\ma_generic_driver.anims",
        @"base\animations\vehicle\generic\ma_generic_passenger_r.anims",
        @"base\animations\vehicle\generic\ma_generic_passenger_l.anims",
        @"base\animations\vehicle\generic\ma_generic_passenger_r.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_ragdoll_recovery.anims",
        @"base\animations\npc\generic_characters\male_average\locomotion\crowd\ma_old_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\male_average\locomotion\man_average_civilian_locomotion.anims",
        @"base\animations\synced\lore\ma_lore.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_locomotion_combat.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_action_combat.anims",
        @"base\animations\npc\gameplay\man_average\gang\rifle\ma_gang_rifle_locomotion_combat.anims",
        @"base\animations\npc\gameplay\man_average\gang\handgunboth\ma_gang_handgunboth_action_combat.anims",
        @"base\animations\npc\gameplay\man_average\gang\revolver\ma_gang_revolver_action_combat.anims",
        @"base\animations\npc\gameplay\man_average\gang\handgunboth\ma_gang_handgunboth_action_combat.anims",
        @"base\animations\npc\gameplay\man_average\civilian\unarmed\ma_civilian_unarmed_action_combat.anims",
        @"base\animations\npc\gameplay\man_average\gang\rifle\ma_gang_rifle_locomotion_combat.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_death.anims",
        @"base\animations\vehicle\generic\generic_bike.anims",
        @"base\animations\vehicle\generic\generic_bike.anims",
        @"base\animations\vehicle\generic\generic_bike.anims",
        @"base\animations\ui\photomode\photomode__male__action.anims",
        @"base\animations\ui\photomode\photomode__male__idle.anims",
        @"base\animations\ui\photomode\photomode__v__natural.anims",
    ];

    public static readonly List<string> RootComponentBig =
    [
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_reaction_ranged_knockdown.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_reaction_defeated.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_reaction_ranged_prone_to_stand.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_reaction_ranged_supine_to_stand.anims",
        @"base\animations\npc\gameplay\man_average\gang\unarmed\ma_gang_unarmed_reaction_ranged_twitch.anims",
        @"base\animations\npc\generic_characters\male_big\crowd_reactions\mb_default_crowd_reaction.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_body_carry.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_reaction_base.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_reaction_melee_impact.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_reaction_melee_stagger.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_reaction_ranged_impact.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_reaction_ranged_stagger.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_reaction_ranged_death.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_locomotion_stealth.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_status_effects.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_exploration_relaxed.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_body_carry_strong.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_body_carry_friendly.anims",
        @"base\animations\vehicle\generic\ma_generic_driver.anims",
        @"base\animations\vehicle\generic\ma_generic_passenger_r.anims",
        @"base\animations\vehicle\generic\ma_generic_passenger_l.anims",
        @"base\animations\vehicle\generic\ma_generic_passenger_r.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_ragdoll_recovery.anims",
        @"base\animations\synced\lore\mb_lore.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_locomotion_combat.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_action_combat.anims",
        @"base\animations\npc\gameplay\man_big\gang\rifle\mb_gang_rifle_locomotion_combat.anims",
        @"base\animations\npc\gameplay\man_big\gang\handgunboth\mb_gang_handgunboth_action_combat.anims",
        @"base\animations\npc\gameplay\man_big\gang\revolver\mb_gang_revolver_action_combat.anims",
        @"base\animations\npc\gameplay\man_big\gang\handgunboth\mb_gang_handgunboth_action_combat.anims",
        @"base\animations\npc\gameplay\man_big\civilian\unarmed\mb_unarmed_civilian_action_combat.anims",
        @"base\animations\npc\gameplay\man_big\gang\rifle\mb_gang_rifle_locomotion_combat.anims",
        @"base\animations\npc\gameplay\man_big\gang\unarmed\mb_gang_unarmed_reaction_death.anims",
        @"base\animations\vehicle\generic\generic_bike.anims",
        @"base\animations\vehicle\generic\generic_bike.anims",
        @"base\animations\vehicle\generic\generic_bike.anims",
        @"base\animations\ui\photomode\photomode__male_big__action.anims",
        @"base\animations\ui\photomode\photomode__male_big__idle.anims",
        @"base\animations\ui\photomode\photomode__v__natural.anims",
    ];

    public static readonly List<string> RootComponentMassive =
    [
        @"base\animations\ui\photomode\photomode_male_massive_idle.anims",
    ];

    public static readonly List<string> RootComponentCat =
    [
        @"base\animations\ui\photomode\photomode__iguana__idle.anims",
    ];

    public static readonly List<string> CharacterEntityAnimationSetupFemale =
    [
        @"base\animations\npc\main_characters\rogue\locomotion\wa_rogue_unarmed_locomotion_relaxed.anims",
        @"base\animations\npc\generic_characters\male_average\crowd_reactions\flee.anims",
        @"base\animations\npc\generic_characters\female_average\locomotion\crowd\fa_swimming_locomotion.anims",
        @"base\animations\npc\generic_characters\female_average\locomotion\generic_average_female_locomotion.anims",
        @"base\animations\npc\main_characters\rogue\locomotion\wa_rogue_rifle_locomotion_patrolling.anims",
        @"base\animations\npc\main_characters\panam\locomotion\wa_panam_handgun_locomotion_patrolling.anims",
    ];

    // yes, this is empty as of 2.0
    public static readonly List<string> CharacterEntityAnimationSetupMale = [];

    // yes, this is empty as of 2.0
    public static readonly List<string> CharacterEntityAnimationSetupBig = [];

    public static readonly List<string> CharacterEntityAnimationSetupMassive =
    [
        @"base\animations\npc\gameplay\man_massive\gang\unarmed\mm_gang_unarmed_locomotion_relaxed.anims",
        @"base\animations\npc\gameplay\man_massive\adam_smasher\minigun\mm_adam_smasher_minigun_action_combat.anims",
        @"base\animations\npc\gameplay\man_massive\adam_smasher\broken\mm_adam_smasher_broken_locomotion_combat.anims",
        @"base\animations\npc\gameplay\man_massive\adam_smasher\broken\mm_adam_smasher_broken_action_combat.anims",
        @"base\animations\npc\gameplay\man_massive\adam_smasher\shotgun\mm_adam_smasher_shotgun_action_combat.anims",
        @"base\animations\npc\gameplay\man_massive\adam_smasher\unarmed\mm_adam_smasher_unarmed_locomotion_combat.anims",
        @"base\animations\npc\gameplay\man_massive\adam_smasher\sync\mm_adam_smasher_phase_sync.anims",
        @"base\animations\npc\gameplay\man_massive\adam_smasher\sync\turret\mm_adam_smasher_turret_sync.anims",
        @"base\animations\npc\gameplay\man_massive\adam_smasher\shotgun\mm_adam_smasher_shotgun_locomotion_combat.anims",
        @"base\animations\npc\gameplay\man_massive\adam_smasher\shotgun\mm_adam_smasher_shotgun_locomotion_combat.anims",
        @"base\animations\npc\gameplay\man_massive\adam_smasher\unarmed\mm_adam_smasher_unarmed_exploration_relaxed.anims",
        @"base\animations\npc\gameplay\man_massive\adam_smasher\broken\mm_adam_smasher_broken_reaction_defeated.anims",
        @"base\animations\npc\gameplay\man_massive\adam_smasher\unarmed\mm_adam_smasher_unarmed_reaction_base.anims",
        @"base\animations\npc\gameplay\man_massive\gang\unarmed\mm_gang_unarmed_status_effects.anims",
        @"base\animations\npc\gameplay\man_massive\adam_smasher\shotgun\mm_adam_smasher_shotgun_locomotion_combat_sandevistan.anims",
        @"base\animations\npc\gameplay\man_massive\adam_smasher\barrage\mm_adam_smasher_barrage_ph1_action_combat.anims",
        @"base\animations\npc\gameplay\man_massive\adam_smasher\barrage\mm_adam_smasher_barrage_ph2_action_combat.anims",
        @"base\animations\npc\gameplay\man_massive\adam_smasher\minigun\mm_adam_smasher_minigun_action_combat.anims",
    ];

    public static readonly List<string> SpecialLocomotionSetupFemale =
    [
        @"base\animations\npc\generic_characters\female_average\locomotion\crowd\fa_purse_crowd_locomotion.anims",
        @"base\animations\npc\archetype_characters\waitress\locomotion\waitress_locomotion.anims",
        @"base\animations\npc\generic_characters\female_average\locomotion\crowd\fa_tablet_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\female_average\locomotion\crowd\fa_coffee_cup_locomotion.anims",
        @"base\animations\npc\generic_characters\female_average\locomotion\crowd\fa_talking_phone_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\female_average\locomotion\crowd\fa_swimming_locomotion.anims",
        @"base\animations\npc\generic_characters\female_average\locomotion\crowd\fa_umbrella_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\female_average\locomotion\generic_average_female_locomotion.anims",
    ];

    public static readonly List<string> SpecialLocomotionSetupMale =
    [
        @"base\animations\npc\generic_characters\male_average\locomotion\crowd\ma_smoking_cigarette_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\male_average\locomotion\crowd\ma_drinking_coffee_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\male_average\locomotion\crowd\ma_phone_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\male_average\locomotion\crowd\ma_laptop_bag_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\male_average\locomotion\crowd\ma_duffel_bag_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\male_average\locomotion\crowd\ma_crate_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\male_average\locomotion\crowd\ma_tablet_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\male_average\locomotion\crowd\ma_umbrella_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\male_average\locomotion\crowd\ma_talking_phone_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\male_average\locomotion\man_average_civilian_locomotion.anims",
    ];

    public static readonly List<string> SpecialLocomotionSetupBig =
    [
        @"base\animations\npc\generic_characters\male_big\locomotion\crowd\mb_can_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\male_big\locomotion\crowd\mb_umbrella_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\male_big\locomotion\man_big_civilian_locomotion.anims",
    ];

    public static readonly List<string> SpecialLocomotionSetupMassive =
    [
        @"base\animations\npc\generic_characters\male_big\locomotion\crowd\mb_can_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\male_big\locomotion\crowd\mb_umbrella_crowd_locomotion.anims",
        @"base\animations\npc\generic_characters\male_big\locomotion\man_big_civilian_locomotion.anims",
    ];
}

public static class PhotomodeFacialAnimations
{
    public const string Female = @"base\animations\facial\_facial_graphs\player_woman_photomode_sermo.animgraph";
    public const string Male = @"base\animations\facial\_facial_graphs\player_man_photomode_sermo.animgraph";
    public const string Big = @"base\animations\facial\_facial_graphs\man_big_sermo.animgraph";
    public const string Massive = @"base\animations\facial\_facial_graphs\man_big_sermo.animgraph";
    public const string Cat = @"base\animations\facial\_facial_graphs\player_woman_photomode_sermo.animgraph";
}
