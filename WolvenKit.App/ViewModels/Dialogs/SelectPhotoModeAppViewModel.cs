using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Extensions;


namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// Asks user for a component name and a chunk mask
/// </summary>
public partial class SelectPhotoModeAppViewModel : ObservableObject
{
    [ObservableProperty] private string? _selectedApp = "";
    [ObservableProperty] private bool? _renameEntries;

    private static readonly Dictionary<string, string> s_photomodeAppOptions = new()
    {
        { "NPV Feminine 2", @"base\characters\appearances\main_npc\npv_pm_fem2.app" },
        { "NPV Feminine 1", @"base\characters\appearances\main_npc\npv_pm.app" },
        { "NPV Masculine 1", @"base\characters\appearances\main_npc\npv_pm_masc1.app" },
        { "NPV Masculine 2", @"base\characters\appearances\main_npc\npv_pm_masc2.app" },
        { "NPV Big Body Type 1", @"base\characters\appearances\main_npc\npv_pm_big1.app" },
        { "NPV Big Body Type 2", @"base\characters\appearances\main_npc\npv_pm_big2.app" },
        { "Feminine", @"base\characters\appearances\main_npc\photomode_npc_woman_average.app" },
        { "Masculine", @"base\characters\appearances\main_npc\photomode_npc_man_average.app" },
    };

    public SelectPhotoModeAppViewModel() => _photomodeAppOptions.AddRange(s_photomodeAppOptions);

    private Dictionary<string, string> _photomodeAppOptions = [];

    public static List<string> PhotomodeAppPaths => s_photomodeAppOptions.Values.ToList();

    // ReSharper disable once UnusedMember.Global used in xaml
    public Dictionary<string, string> PhotomodeAppOptions
    {
        get => _photomodeAppOptions;
        set => SetProperty(ref _photomodeAppOptions, value);
    }
}