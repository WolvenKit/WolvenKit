using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WolvenKit.App;

/// <summary>
/// Enumeration of serialized Managers
/// </summary>
public enum EManagerType
{
    BundleManager = 0,
    CollisionManager = 1,
    SoundManager = 2,
    W3StringManager = 3,
    TextureManager = 4,
    ArchiveManager = 5,
    Max = 6
}

public enum EProjectType
{
    cpmodproj,
    w3modproj
}

public enum EAppStatus
{
    None,
    Loaded,
    Busy,
    Ready
}

public enum EDockedViews
{
    LogViewModel,
    ProjectExplorerViewModel,
    PropertiesViewModel,
    AssetBrowserViewModel,
    TweakBrowserViewModel,
    LocKeyBrowserViewModel,
    ImportViewModel,
    ExportViewModel,
    HashToolViewModel
}

public enum ScriptSource
{
    System,
    User
}

public enum PhotomodeBodyGender
{
    [Display(Description = "Female")] Female,
    [Display(Description = "Male")] Male,

    [Display(Description = "Big (e.g. Jackie)")]
    Big,

    [Display(Description = "Massive (Smasher)")]
    Massive,

    [Display(Description = "Cat (Nibbles)")]
    Cat
}

public enum ProjectFolder
{
    All,
    Archive,
    Raw,
    Resources
}

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
