using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace WolvenKit.App;

public enum EquipmentItemSlot
{
    None,
    Head,
    Face,
    Torso_Inner,
    Torso_Outer,
    Legs,
    Feet,
    Outfit
}

// ReSharper disable InconsistentNaming
public enum ArchiveXlHidingTags
{
    hide_F1,
    hide_T1,
    hide_T2,
    hide_L1,
    hide_S1,
    hide_T1part,
    hide_Hair,
    hide_Genitals,
    hide_Head,
    hide_Torso,
    hide_LowerAbdomen,
    hide_UpperAbdomen,
    hide_CollarBone,
    hide_Arms,
    hide_Thighs,
    hide_Calves,
    hide_Ankles,
    hide_Feet,
    hide_Legs,
}

// ReSharper disable InconsistentNaming
public enum GarmentSupportTags
{
    None,
    PlayerBodyPart,
    Tight,
    Normal,
    Large,
    XLarge,
}

public enum EquipmentWeaponSlot
{
    Fists,
    Handgun,
    ShortBlade,
    LongBlade,
    OneHandedClub,
    TwoHandedClub,
    SubmachineGun,
    Shotgun,
    AssaultRifle,
    SniperRifle,
    PrecisionRifle,
    ShotgunDual,
    LightMachineGun,
    HeavyMachineGun,
    Revolver,
    Grenade,
}

public enum EquipmentWeaponSubSlot
{
    // Fists
    Knuckles,

    // Handgun
    Arasaka_Kappa,
    Arasaka_Kenshin,
    Arasaka_Yukimura,
    Budget_Slaughtomatic,
    Constitutional_Unity,
    Kang_Tao_Chao,
    Krausser_Grit,
    Malorian_Silverhand,
    Militech_Lexington,
    Militech_Omaha,
    Militech_Ticon,
    Tsunami_Kappa,
    Tsunami_Nue,

    // ShortBlade
    Knife,
    Butchers_Knife,
    Tanto,
    Kukri,
    Machete,
    Wakizashi,
    Chainsword,
    Axe,
    Tomahawk,
    Crowbar,
    Tire_Iron,
    Iron_Pipe,

    // LongBlade
    Katana,
    Sword,

    // OneHandedClub
    Shovel,
    Kanabo,
    Baton,
    Dildo,
    Cane,
    Cattle_Prod,

    // TwoHandedClub
    Sledge_Hammer,
    Baseball_Bat,

    // SubmachineGun
    Arasaka_Shingen,
    Budget_Guillotine,
    Darra_Pulsar,
    Kang_Tao_Dian,
    Militech_Saratoga,
    Senkoh_LX,

    // AssaultRifle
    Arasaka_Masamune,
    Darra_Umbra,
    Militech_Ajax,
    Nokota_Copperhead,
    Nokota_Sidewinder,
    Tsunami_Kyuibi,

    // SniperRifle
    Techtronika_Grad,
    Tsunami_Ashura,
    Tsunami_Nekomata,

    // PrecisionRifle
    Midnight_SOR22,
    Militech_Achilles,
    Rostovic_Kolac,
    Techtronika_Pozhar,

    // Shotgun
    Constitutional_Tactician,
    Kang_Tao_Zhuo,

    // ShotgunDual
    Rostovic_Igla,
    Rostovic_Palica,
    Rostovic_Satara,
    Rostovic_Testera,

    // LightMachineGun
    Constitutional_Defender,
    Midnight_MA70,

    // HeavyMachineGun
    Militech_HMG,

    // Revolver
    Darra_Nova,
    Darra_Quasar,
    Malorian_Overture,
    Militech_Crusher,
    Techtronika_Burya,

    // grenades
    Frag_Grenade,
    Flash_Grenade,
    Incendiary_Grenade,
    Biohazard_Grenade,
    EMP_Grenade,
    Recon_Grenade,
    Cutting_Grenade,
    Homing_Grenade,
    Sticky_Grenade,
}

public enum EquipmentItemSubSlot
{
    None,

    // Head items
    HelmetHair,
    Hat,
    Cap,
    Scarf,
    ScarfHair,
    Balaclava,

    // Face items
    Glasses,
    Mask,
    Visor,
    Tech,

    // T2
    Coat,
    Dress,
    FormalJacket,
    Jacket,
    Jumpsuit,
    LooseShirt,
    Vest,

    // T1
    FormalShirt,
    Shirt,
    TankTop,
    TightJumpsuit,
    TShirt,
    Undershirt,

    // Legs
    FormalPants,
    Pants,
    Shorts,
    Skirt,

    // Feet
    Boots,
    CasualShoes,
    FormalShoes
}

public enum EquipmentExSlot
{
    None,
    Head,
    Balaclava,
    Mask,
    Glasses,
    Eyes,
    EyeLeft,
    EyeRight,
    Wreath,
    EarLeft,
    EarRight,
    Neckwear,
    NecklaceTight,
    NecklaceShort,
    NecklaceLong,
    TorsoUnder,
    TorsoInner,
    TorsoMiddle,
    TorsoOuter,
    TorsoAux,
    Back,
    ShoulderLeft,
    ShoulderRight,
    ElbowLeft,
    ElbowRight,
    WristLeft,
    WristRight,
    Hands,
    HandLeft,
    HandRight,
    FingersLeft,
    FingersRight,
    FingernailsLeft,
    FingernailsRight,
    Waist,
    LegsInner,
    LegsMiddle,
    LegsOuter,
    ThighLeft,
    ThighRight,
    KneeLeft,
    KneeRight,
    AnkleLeft,
    AnkleRight,
    Feet,
    ToesLeft,
    ToesRight,
    ToenailsLeft,
    ToenailsRight,
    BodyUnder,
    BodyInner,
    BodyMiddle,
    BodyOuter,
    HandPropLeft,
    HandPropRight,
}

/// <summary>
/// Contains lookup lists for anything related to the enums above (e.g. mappings from EquipmentItemSlot to subslots).
/// </summary>
public static class EquipmentItemData
{
    public static readonly Dictionary<EquipmentItemSlot, string> EquipmentItemSlotNames = new()
    {
        { EquipmentItemSlot.None, "Items.GenericHeadClothing" },
        { EquipmentItemSlot.Head, "Items.GenericHeadClothing" },
        { EquipmentItemSlot.Face, "Items.GenericFaceClothing" },
        { EquipmentItemSlot.Torso_Inner, "Items.GenericInnerChestClothing" },
        { EquipmentItemSlot.Torso_Outer, "Items.GenericOuterChestClothing" },
        { EquipmentItemSlot.Legs, "Items.GenericLegClothing" },
        { EquipmentItemSlot.Feet, "Items.GenericFootClothing" },
        { EquipmentItemSlot.Outfit, "Items.Outfit" },
    };

    public static readonly string DefaultAppFilePath =
        @"base\gameplay\items\equipment\underwear\appearances\player_underwear_item_appearances.app";

    public static readonly string DefaultRootEntityPath =
        @"base\gameplay\items\equipment\underwear\player_underwear_item.ent";

    public static readonly Dictionary<EquipmentItemSlot, string> FilesByType = new()
    {
        { EquipmentItemSlot.Face, @"base\characters\garment\player_equipment\head\h1_015_pwa_specs__visor_holo.ent" },
        { EquipmentItemSlot.Head, @"base\characters\garment\player_equipment\head\h2_011_pwa_helmet__riot.ent" },
        { EquipmentItemSlot.Legs, @"base\characters\garment\player_equipment\legs\l1_070_pwa_pants__loose.ent" },
        {
            EquipmentItemSlot.Torso_Inner,
            @"base\characters\garment\player_equipment\torso\t1_079_pwa_tshirt__casual.ent"
        },
        { EquipmentItemSlot.Torso_Outer, @"base\characters\garment\player_equipment\torso\t2_002_pwa_vest__puffy.ent" },
        { EquipmentItemSlot.Outfit, @"base\characters\garment\player_equipment\torso\t0_005_pwa_body__t_bug.ent" },
    };

    public static readonly Dictionary<EquipmentItemSubSlot, string> FilesBySubType = new()
    {
        // head
        { EquipmentItemSubSlot.Cap, @"base\characters\garment\player_equipment\head\h1_011_pwa_hat__baseball.ent" },
        {
            EquipmentItemSubSlot.ScarfHair,
            @"base\characters\garment\player_equipment\head\h1_011_pwa_hat__baseball.ent"
        },
        {
            EquipmentItemSubSlot.HelmetHair,
            @"base\characters\garment\player_equipment\head\h1_011_pwa_hat__baseball.ent"
        },
        { EquipmentItemSubSlot.Hat, @"base\characters\garment\player_equipment\head\h1_032_pwa_hat__asian.ent" },
        { EquipmentItemSubSlot.Mask, @"base\characters\garment\player_equipment\head\h1_056_pwa_mask__samurai.ent" },
        {
            EquipmentItemSubSlot.Glasses, @"base\characters\garment\player_equipment\head\h1_038_pwa_specs__classic.ent"
        },
        {
            EquipmentItemSubSlot.Tech,
            @"base\characters\garment\player_equipment\head\h1_052_pwa_specs__tactical_01.ent"
        },
        {
            EquipmentItemSubSlot.Visor,
            @"base\characters\garment\player_equipment\head\h1_015_pwa_specs__visor_holo.ent"
        },

        // torso
        { EquipmentItemSubSlot.Dress, @"base\characters\garment\player_equipment\torso\t2_014_pwa_dress__chic.ent" },
        {
            EquipmentItemSubSlot.Undershirt,
            @"base\characters\garment\player_equipment\torso\t0_005_pwa_body__t_bug_tight.ent"
        },
        { EquipmentItemSubSlot.TankTop, @"base\characters\garment\player_equipment\torso\t1_071_pwa_tank__basic.ent" },
        {
            EquipmentItemSubSlot.Jumpsuit,
            @"base\characters\garment\player_equipment\torso\t1_091_pwa_full__jumpsuit.ent"
        },
        {
            EquipmentItemSubSlot.Coat,
            @"base\characters\garment\player_equipment\torso\t2_097_pwa_jacket__holmes_coat.ent"
        },
        {
            EquipmentItemSubSlot.TightJumpsuit,
            @"base\characters\garment\player_equipment\torso\t0_005_pwa_body__t_bug.ent"
        },
        // legs
        { EquipmentItemSubSlot.Skirt, @"base\characters\garment\player_equipment\legs\l1_011_pwa_skirt__tight.ent" },
        { EquipmentItemSubSlot.Shorts, @"base\characters\garment\player_equipment\legs\l1_054_pwa_shorts__latino.ent" },
        {
            EquipmentItemSubSlot.FormalPants,
            @"base\characters\garment\player_equipment\legs\l1_045_pwa_pants__suit.ent"
        },
        // feet
        { EquipmentItemSubSlot.Boots, @"base\characters\garment\player_equipment\feet\s1_056_pwa_boot__biker.ent" },
        {
            EquipmentItemSubSlot.CasualShoes,
            @"base\characters\garment\player_equipment\feet\s1_068_pwa_shoe__sneakers.ent"
        },
        {
            EquipmentItemSubSlot.FormalShoes,
            @"base\characters\garment\player_equipment\feet\s1_077_pwa_boot__blackwater.ent"
        },
    };

    /// <summary>
    /// Equipment slots and their potential sub-slots
    /// </summary>
    public static readonly Dictionary<EquipmentItemSlot, List<EquipmentItemSubSlot>> EquipmentSlotsAndSubtypes = new()
    {
        {
            EquipmentItemSlot.Head, [
                EquipmentItemSubSlot.None,
                EquipmentItemSubSlot.HelmetHair,
                EquipmentItemSubSlot.Hat,
                EquipmentItemSubSlot.Cap,
                EquipmentItemSubSlot.Scarf,
                EquipmentItemSubSlot.ScarfHair,
                EquipmentItemSubSlot.Balaclava,
            ]
        },
        {
            EquipmentItemSlot.Face, [
                EquipmentItemSubSlot.Glasses,
                EquipmentItemSubSlot.Mask,
                EquipmentItemSubSlot.Visor,
                EquipmentItemSubSlot.Tech,
            ]
        },
        {
            EquipmentItemSlot.Torso_Inner, [
                EquipmentItemSubSlot.FormalShirt,
                EquipmentItemSubSlot.Shirt,
                EquipmentItemSubSlot.TankTop,
                EquipmentItemSubSlot.TightJumpsuit,
                EquipmentItemSubSlot.TShirt,
                EquipmentItemSubSlot.Undershirt,
            ]
        },
        {
            EquipmentItemSlot.Torso_Outer, [
                EquipmentItemSubSlot.Coat,
                EquipmentItemSubSlot.Dress,
                EquipmentItemSubSlot.FormalJacket,
                EquipmentItemSubSlot.Jacket,
                EquipmentItemSubSlot.Jumpsuit,
                EquipmentItemSubSlot.LooseShirt,
                EquipmentItemSubSlot.Vest,
            ]
        },
        {
            EquipmentItemSlot.Legs, [
                EquipmentItemSubSlot.FormalPants,
                EquipmentItemSubSlot.Pants,
                EquipmentItemSubSlot.Shorts,
                EquipmentItemSubSlot.Skirt,
            ]
        },
        {
            EquipmentItemSlot.Feet, [
                EquipmentItemSubSlot.Boots,
                EquipmentItemSubSlot.CasualShoes,
                EquipmentItemSubSlot.FormalShoes
            ]
        },
        { EquipmentItemSlot.Outfit, [] },
    };


    public static Dictionary<EquipmentWeaponSlot, List<EquipmentWeaponSubSlot>> EquipmentWeaponSlotToSubSlots = new()
    {
        {
            EquipmentWeaponSlot.Fists, [
                EquipmentWeaponSubSlot.Knuckles
            ]
        },
        {
            EquipmentWeaponSlot.Handgun, [
                EquipmentWeaponSubSlot.Arasaka_Kappa,
                EquipmentWeaponSubSlot.Arasaka_Kenshin,
                EquipmentWeaponSubSlot.Arasaka_Yukimura,
                EquipmentWeaponSubSlot.Budget_Slaughtomatic,
                EquipmentWeaponSubSlot.Constitutional_Unity,
                EquipmentWeaponSubSlot.Kang_Tao_Chao,
                EquipmentWeaponSubSlot.Krausser_Grit,
                EquipmentWeaponSubSlot.Malorian_Silverhand,
                EquipmentWeaponSubSlot.Militech_Lexington,
                EquipmentWeaponSubSlot.Militech_Omaha,
                EquipmentWeaponSubSlot.Militech_Ticon,
                EquipmentWeaponSubSlot.Tsunami_Kappa,
            ]
        },
        {
            EquipmentWeaponSlot.ShortBlade, [
                EquipmentWeaponSubSlot.Knife,
                EquipmentWeaponSubSlot.Butchers_Knife,
                EquipmentWeaponSubSlot.Tanto,
                EquipmentWeaponSubSlot.Kukri,
                EquipmentWeaponSubSlot.Machete,
                EquipmentWeaponSubSlot.Wakizashi,
                EquipmentWeaponSubSlot.Chainsword,
                EquipmentWeaponSubSlot.Axe,
                EquipmentWeaponSubSlot.Tomahawk,
                EquipmentWeaponSubSlot.Crowbar,
                EquipmentWeaponSubSlot.Tire_Iron,
                EquipmentWeaponSubSlot.Iron_Pipe,
            ]
        },
        {
            EquipmentWeaponSlot.LongBlade, [
                EquipmentWeaponSubSlot.Katana,
                EquipmentWeaponSubSlot.Sword,
            ]
        },
        {
            EquipmentWeaponSlot.OneHandedClub, [
                EquipmentWeaponSubSlot.Shovel,
                EquipmentWeaponSubSlot.Kanabo,
                EquipmentWeaponSubSlot.Baton,
                EquipmentWeaponSubSlot.Dildo,
                EquipmentWeaponSubSlot.Cane,
                EquipmentWeaponSubSlot.Cattle_Prod,
            ]
        },
        {
            EquipmentWeaponSlot.TwoHandedClub, [
                EquipmentWeaponSubSlot.Sledge_Hammer,
                EquipmentWeaponSubSlot.Baseball_Bat,
            ]
        },
        {
            EquipmentWeaponSlot.SubmachineGun, [
                EquipmentWeaponSubSlot.Arasaka_Shingen,
                EquipmentWeaponSubSlot.Budget_Guillotine,
                EquipmentWeaponSubSlot.Darra_Pulsar,
                EquipmentWeaponSubSlot.Kang_Tao_Dian,
                EquipmentWeaponSubSlot.Militech_Saratoga,
                EquipmentWeaponSubSlot.Senkoh_LX,
            ]
        },
        {
            EquipmentWeaponSlot.Shotgun, [
                EquipmentWeaponSubSlot.Constitutional_Tactician,
                EquipmentWeaponSubSlot.Kang_Tao_Zhuo,
            ]
        },
        {
            EquipmentWeaponSlot.AssaultRifle, [
                EquipmentWeaponSubSlot.Arasaka_Masamune,
                EquipmentWeaponSubSlot.Darra_Umbra,
                EquipmentWeaponSubSlot.Militech_Ajax,
                EquipmentWeaponSubSlot.Nokota_Copperhead,
                EquipmentWeaponSubSlot.Nokota_Sidewinder,
                EquipmentWeaponSubSlot.Tsunami_Kyuibi,
            ]
        },
        {
            EquipmentWeaponSlot.SniperRifle, [
                EquipmentWeaponSubSlot.Techtronika_Grad,
                EquipmentWeaponSubSlot.Tsunami_Ashura,
                EquipmentWeaponSubSlot.Tsunami_Nekomata,
            ]
        },
        {
            EquipmentWeaponSlot.PrecisionRifle, [
                EquipmentWeaponSubSlot.Midnight_SOR22,
                EquipmentWeaponSubSlot.Militech_Achilles,
                EquipmentWeaponSubSlot.Rostovic_Kolac,
                EquipmentWeaponSubSlot.Techtronika_Pozhar,
            ]
        },
        {
            EquipmentWeaponSlot.ShotgunDual, [
                EquipmentWeaponSubSlot.Rostovic_Igla,
                EquipmentWeaponSubSlot.Rostovic_Palica,
                EquipmentWeaponSubSlot.Rostovic_Satara,
                EquipmentWeaponSubSlot.Rostovic_Testera,
            ]
        },
        {
            EquipmentWeaponSlot.LightMachineGun, [
                EquipmentWeaponSubSlot.Constitutional_Defender,
                EquipmentWeaponSubSlot.Midnight_MA70,
            ]
        },
        {
            EquipmentWeaponSlot.HeavyMachineGun, [
                EquipmentWeaponSubSlot.Militech_HMG,
            ]
        },
        {
            EquipmentWeaponSlot.Revolver, [
                EquipmentWeaponSubSlot.Darra_Nova,
                EquipmentWeaponSubSlot.Darra_Quasar,
                EquipmentWeaponSubSlot.Malorian_Overture,
                EquipmentWeaponSubSlot.Militech_Crusher,
                EquipmentWeaponSubSlot.Techtronika_Burya,
            ]
        },
        {
            EquipmentWeaponSlot.Grenade, [
                EquipmentWeaponSubSlot.Frag_Grenade,
                EquipmentWeaponSubSlot.Flash_Grenade,
                EquipmentWeaponSubSlot.Incendiary_Grenade,
                EquipmentWeaponSubSlot.Biohazard_Grenade,
                EquipmentWeaponSubSlot.EMP_Grenade,
                EquipmentWeaponSubSlot.Recon_Grenade,
                EquipmentWeaponSubSlot.Cutting_Grenade,
                EquipmentWeaponSubSlot.Homing_Grenade,
                EquipmentWeaponSubSlot.Sticky_Grenade,
            ]
        },
    };
}
