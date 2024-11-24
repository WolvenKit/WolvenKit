using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Types;


namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// Asks user for a component name and a chunk mask
/// </summary>
public partial class SelectAnimationPathViewModel : ObservableObject
{
    [GeneratedRegex(@"(?<=__)([^\\]+)(?=_rigsetup)")]
    private static partial Regex AnimNameRegex();

    [ObservableProperty] private string? _rigPath = "";
    [ObservableProperty] private string? _animationPath = "";

    public SelectAnimationPathViewModel(List<string> facialSetupPaths) =>
        facialSetupPaths.Where(path => !_animGraphOptions.ContainsValue(path)).ToList().ForEach(path =>
        {
            if (AnimNameRegex().Matches(path).FirstOrDefault()?.Value is not string animName)
            {
                return;
            }

            var bodyGender = path.Contains("_wa_") || path.Contains("_pwa_") ? "Woman" : "Man";
            animName = animName.Replace("_", " ").CapitalizeEachWord();
            var animKey = $"{bodyGender} - {animName}";
            var numDuplicates = _animGraphOptions.Keys.Count((item) => item.StartsWith(animKey));
            if (numDuplicates > 0)
            {
                animKey = $"{animKey} {numDuplicates}";
            }

            _animGraphOptions.Add(animKey, path);
            FilteredGraphOptions = _animGraphOptions;
        });

    private Dictionary<string, string> _facialAnimOptions = new()
    {
        // Photo mode
        { "Photo Mode: Player Woman", @"base\animations\facial\_facial_graphs\player_woman_photomode_sermo.animgraph" },
        { "Photo Mode: Player Man", @"base\animations\facial\_facial_graphs\player_man_photomode_sermo.animgraph" },

        // Spawned NPC
        { "NPV: Woman Player", @"base\animations\facial\_facial_graphs\player_woman_paperdoll_sermo.animgraph" },
        { "NPV: Woman Average", @"base\animations\facial\_facial_graphs\woman_average_sermo.animgraph" },
        { "NPV: Woman Average (LC)", @"base\animations\facial\_facial_graphs\woman_average_sermo_lc.animgraph" },
        { "NPV: Man Player", @"base\animations\facial\_facial_graphs\player_man_paperdoll_sermo.animgraph" },
        { "NPV: Man Big", @"base\animations\facial\_facial_graphs\man_big_sermo.animgraph" },
        { "NPV: Man Average", @"base\animations\facial\_facial_graphs\man_average_sermo.animgraph" },
        { "NPV: Fat", @"base\animations\facial\_facial_graphs\man_fat_sermo.animgraph" },
    };

    private readonly Dictionary<string, string> _animGraphOptions = new()
    {
        // more entries will be appended by list of paths from constructor
        { "Player Woman", @"base\characters\head\pma\h0_001_ma_c__player\h0_001_ma_c__player_rigsetup.facialsetup" },
        { "Player Man", @"base\characters\head\pma\h0_001_ma_c__player\h0_001_ma_c__player_rigsetup.facialsetup" },
    };

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        switch (e.PropertyName)
        {
            case nameof(FilterText):
                FilteredGraphOptions = string.IsNullOrEmpty(FilterText)
                    ? _animGraphOptions
                    : _animGraphOptions.Where(o =>
                        o.Key.Contains(FilterText, StringComparison.OrdinalIgnoreCase) ||
                        o.Value.Contains(FilterText, StringComparison.OrdinalIgnoreCase));
                break;
            default:
                break;
        }
    }


    [ObservableProperty] private string? _selectedFacialAnim;
    public string? SelectedAnimPath => SelectedFacialAnim is null ? null : _facialAnimOptions[SelectedFacialAnim];

    public Dictionary<string, string> FacialAnimOptions
    {
        get => _facialAnimOptions;
        set => SetProperty(ref _facialAnimOptions, value);
    }

    [ObservableProperty] private string? _selectedGraph;

    public string? SelectedGraphPath => SelectedGraph is null ? null : _animGraphOptions[SelectedGraph];

    [ObservableProperty] private string? _filterText;

    [ObservableProperty] private IEnumerable<KeyValuePair<string, string>> _filteredGraphOptions = [];
}