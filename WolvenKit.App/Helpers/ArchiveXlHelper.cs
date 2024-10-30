using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Helpers;

/// <summary>
/// This class will resolve ArchiveXL dynamic variant depot paths.
/// They start with an asterisk <see cref="ArchiveXlHelper.ArchiveXLSubstitutionPrefix"/> and contain substitution wildcards (<see cref="s_keysAndValues"/>).  
/// </summary>
public static partial class ArchiveXlHelper
{
    public const string ArchiveXLSubstitutionPrefix = "*";

    private static readonly Dictionary<string, string[]> s_keysAndValues = new()
    {
        { "{camera}", ["fpp", "tpp"] },
        { "{feet}", ["lifted", "flat", "high_heels", "flat_shoes"] },
        { "{gender}", ["m", "w"] },
        { "arms", ["base_arms", "mantis_blades", "monowire", "projectile_launch"] }, //
        { "{body}", ["base_body"] },
    };

    private static ILoggerService? s_loggerService;
    private static ILoggerService? LoggerService => s_loggerService ??= Locator.Current.GetService<ILoggerService>();

    private static IProjectManager? s_projectManager;
    private static IProjectManager? ProjectManager => s_projectManager ??= Locator.Current.GetService<IProjectManager>();

    private static int CountBraces(string depotPath)
    {
        var openBracesCount = depotPath.Count(c => c == '{');
        var closingBracesCount = depotPath.Count(c => c == '}');
        if (openBracesCount != closingBracesCount)
        {
            throw new Exception("Failed to resolve ArchiveXL substitution, no equal amount of { and }");
        }

        return openBracesCount;
    }

    private static IEnumerable<string> Substitute(string depotPath)
    {
        // Base case: if the string does not contain '{', return the string as the only element in a list
        if (!depotPath.Contains('{'))
        {
            return [depotPath];
        }

        // Find the first key in the string
        var start = depotPath.IndexOf('{');
        var end = depotPath.IndexOf('}');
        var key = depotPath.Substring(start, end - start + 1);

        // TODO: We need to parse the yaml for this
        if (key.Contains("variant"))
        {
            return [depotPath];
        }
        
        // If the key is not in the dictionary, throw an exception
        if (!s_keysAndValues.TryGetValue(key, out var substitutionList))
        {
            throw new Exception($"Key {key} not found in dictionary");
        }

        // For each value of this key, replace the key in the string with the value and recursively call the function
        var results = new List<string>();
        foreach (var substitution in substitutionList)
        {
            var newPath = depotPath.Replace(key, substitution);
            results.AddRange(Substitute(newPath));
        }

        // Return the combined results
        return results;
    }

    /// <summary>
    /// Returns any existing depot path, or null. If no substitution is used, it will still check for the file's existence
    /// and return null if it can't be found. 
    /// </summary>
    public static string? GetFirstExistingPath(string? depotPath)
    {
        if (depotPath is null || ProjectManager?.ActiveProject?.ModDirectory is not string pathToArchiveFolder
                              || ProjectManager?.ActiveProject?.FileDirectory is not string pathToGameFiles)
        {
            return null;
        }

        return ResolveDynamicPaths(depotPath).FirstOrDefault((f) =>
            File.Exists(Path.Combine(pathToArchiveFolder, f)) || File.Exists(Path.Combine(pathToGameFiles, f)));
    }

    /// <summary>
    /// Returns a list with all potential substitutions. If the path doesn't enable substitution, the list will have one element.
    /// To get _any_ existing depot path, use <see cref="GetFirstExistingPath(string?)"/> instead.
    /// </summary>
    public static IEnumerable<string> ResolveDynamicPaths(string depotPath)
    {
        if (!depotPath.StartsWith('*'))
        {
            return [depotPath];
        }

        depotPath = depotPath[1..];

        var braceCount = 0;
        try
        {
            braceCount = CountBraces(depotPath);
        }
        catch (Exception err)
        {
            LoggerService?.Error(err.Message);
        }

        if (braceCount == 0)
        {
            return [depotPath];
        }

        return Substitute(depotPath);
    }

    /// <summary>
    /// Equipment slots and their potential sub-slots
    /// </summary>
    public static Dictionary<EquipmentItemSlot, List<EquipmentItemSubSlot>> EquipmentSlotsAndSubtypes = new()
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