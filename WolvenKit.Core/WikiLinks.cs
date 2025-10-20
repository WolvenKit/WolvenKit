// ReSharper disable InconsistentNaming
namespace WolvenKit.Core;

public static class WikiLinks
{
    public const string DiscordInvite = "https://discord.gg/Epkq79kd96";

    public const string WolvenKitSetupGuide = "https://wiki.redmodding.org/wolvenkit/getting-started/setup";
    public const string WolvenkitAbout = "https://wiki.redmodding.org/wolvenkit/about";

    public const string AddingNewItems =
        "https://wiki.redmodding.org/cyberpunk-2077-modding/modding-guides/items-equipment/adding-new-items/archivexl-dynamic-variants";

    public const string AddingNewItems_Weapons =
        "https://wiki.redmodding.org/cyberpunk-2077-modding/modding-guides/items-equipment/adding-new-items/weapons";

    public const string NPVs =
        "https://wiki.redmodding.org/cyberpunk-2077-modding/modding-guides/npcs/npv-v-as-custom-npc";

    public const string Props =
        "https://wiki.redmodding.org/cyberpunk-2077-modding/modding-guides/everything-else/custom-props";

    public const string AMM_NPCs =
        "https://wiki.redmodding.org/cyberpunk-2077-modding/modding-guides/npcs/amm-custom-npcs";

    public const string Tattoos =
        "https://wiki.redmodding.org/cyberpunk-2077-modding/modding-guides/npcs/custom-tattoos-and-scars";

    public const string Hair =
        "https://wiki.redmodding.org/cyberpunk-2077-modding/modding-guides/npcs/guides-all-about-hair";

    public const string CCXL =
        "https://wiki.redmodding.org/cyberpunk-2077-modding/for-mod-creators-theory/core-mods-explained/archivexl/archivexl-character-creator-additions";

    public const string MeshMaterials =
        "https://wiki.redmodding.org/cyberpunk-2077-modding/for-mod-creators-theory/files-and-what-they-do/file-formats/3d-objects-.mesh-files#material-assignment";

    public const string ResourcePatching =
        "https://wiki.redmodding.org/cyberpunk-2077-modding/for-mod-creators-theory/core-mods-explained/archivexl/archivexl-resource-patching";

    public const string CyberpunkBlenderAddon =
        "https://wiki.redmodding.org/cyberpunk-2077-modding/for-mod-creators-theory/modding-tools/wolvenkit-blender-io-suite";


    public const string WolvenKitCreatingAModGuide =
        "https://wiki.redmodding.org/wolvenkit/getting-started/creating-a-mod";

    public const string WorldEditing =
        "https://wiki.redmodding.org/cyberpunk-2077-modding/modding-guides/world-editing";

    public const string CheatSheets =
        "https://wiki.redmodding.org/cyberpunk-2077-modding/for-mod-creators-theory/references-lists-and-overviews";

    public const string JsonFiles =
        "https://wiki.redmodding.org/cyberpunk-2077-modding/for-mod-creators-theory/files-and-what-they-do/file-formats/translation-files-.json";

    public const string SettingsModderName = "https://wiki.redmodding.org/wolvenkit/wolvenkit-app/settings#your-name";
}

// ReSharper disable MemberCanBeMadeStatic.Global
/// <summary>
/// Views just HATE constants. There must be a better way.
/// </summary>
public class WikiLinksInstance
{
    public string DiscordInvite { get; } = WikiLinks.DiscordInvite;
    public string WolvenkitAbout { get; } = WikiLinks.WolvenkitAbout;

    public string WolvenKitSetupGuide { get; } = WikiLinks.WolvenKitSetupGuide;
    public string WolvenKitCreatingAModGuide { get; } = WikiLinks.WolvenKitCreatingAModGuide;

    public string AddingNewItems { get; } = WikiLinks.AddingNewItems;
    public string AddingNewItems_Weapons { get; } = WikiLinks.AddingNewItems_Weapons;

    public string NPVs { get; } = WikiLinks.NPVs;
    public string AMM_NPCs { get; } = WikiLinks.AMM_NPCs;

    public string Tattoos { get; } = WikiLinks.Tattoos;

    public string Hair { get; } = WikiLinks.Hair;
    public string CCXL { get; } = WikiLinks.CCXL;

    public string WorldEditing { get; } = WikiLinks.WorldEditing;

    public string CheatSheets { get; } = WikiLinks.CheatSheets;
    public string MeshMaterials { get; } = WikiLinks.MeshMaterials;
    public string ResourcePatching { get; } = WikiLinks.ResourcePatching;

    public string CyberpunkBlenderAddon { get; } = WikiLinks.CyberpunkBlenderAddon;
}
