using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData.Kernel;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class LaunchProfilesViewModel : DialogViewModel
{
    private readonly ISettingsManager _settingsManager;
    private readonly ILoggerService _loggerService;

    public LaunchProfilesViewModel(ISettingsManager settingsManager, ILoggerService loggerService)
    {
        _settingsManager = settingsManager;
        _loggerService = loggerService;

        Title = "Rename";

        // populate profiles
        LaunchProfiles = new();
        
        if (_settingsManager.GetLaunchProfiles() is not Dictionary<string, LaunchProfile> launchProfiles)
        {
            return;
        }

        foreach (var (key, value) in launchProfiles)
        {
            var newProfile = new LaunchProfileViewModel(key, value);
            LaunchProfiles.Add(newProfile);
        }

        if (_settingsManager.LastLaunchProfile is string profileName)
        {
            SelectedLaunchProfile = LaunchProfiles.FirstOrDefault(lp => lp.Name == profileName);
        }
    }

    //private void LogExtended(Exception ex) => _loggerService.Error($"Message: {ex.Message}\nSource: {ex.Source}\nStackTrace: {ex.StackTrace}");

    [RelayCommand]
    private void NewItem() => LaunchProfiles.Add(new LaunchProfileViewModel("New LaunchProfile", new()));

    [RelayCommand]
    private void DuplicateItem()
    {
        if (SelectedLaunchProfile != null)
        {
            LaunchProfiles.Add(new LaunchProfileViewModel($"{SelectedLaunchProfile.Name} Copy", SelectedLaunchProfile.Profile.Copy()));
        }
    }

    private bool CanPositionDown() => SelectedLaunchProfile is { Profile.Order: > 0 };

    [RelayCommand(CanExecute = nameof(CanPositionDown))]
    private void PositionDown()
    {
        if (SelectedLaunchProfile is null ||
            LaunchProfiles.FirstOrDefault(p => p.Profile.Order == SelectedLaunchProfile.Profile.Order + 1) is not { } other)
        {
            return;
        }

        SelectedLaunchProfile.Profile.SwitchPosition(other.Profile);
        SortLaunchProfiles();
    }

    private bool CanPositionUp() => SelectedLaunchProfile != null && SelectedLaunchProfile.Profile.Order < LaunchProfiles.Count - 1;

    [RelayCommand(CanExecute = nameof(CanPositionUp))]
    private void PositionUp()
    {
        if (SelectedLaunchProfile is null ||
            LaunchProfiles.FirstOrDefault(p => p.Profile.Order == SelectedLaunchProfile.Profile.Order - 1) is not { } other)
        {
            return;
        }

        SelectedLaunchProfile.Profile.SwitchPosition(other.Profile);
        SortLaunchProfiles();
    }

    public LaunchProfileViewModel? GetLaunchProfile(string name) => LaunchProfiles.FirstOrDefault(x => x.Name == name);
    public LaunchProfileViewModel? GetLaunchProfile(int pos) => LaunchProfiles.FirstOrDefault(x => x.Profile.Order == pos);

    [RelayCommand]
    private void DeleteItem()
    {
        if (SelectedLaunchProfile == null)
        {
            return;
        }
        LaunchProfiles.Remove(SelectedLaunchProfile);
    }

    [ObservableProperty] private ObservableCollection<LaunchProfileViewModel> _launchProfiles = new();

    [ObservableProperty] private LaunchProfileViewModel? _selectedLaunchProfile;

    // Sort launch profiles by order for display, then write them back to the settings manager (is that even necessary?)
    private void SortLaunchProfiles()
    {
        var orderedProfiles = LaunchProfiles.OrderBy(x => x.Profile.Order)
            .ToDictionary(x => x.Name, x => x.Profile);

        _settingsManager.LaunchProfiles = orderedProfiles;
        LaunchProfiles =
            new ObservableCollection<LaunchProfileViewModel>(orderedProfiles.Select(kvp => new LaunchProfileViewModel(kvp.Key, kvp.Value)));
    }

    public string Title { get; set; }

    public void UpdateLaunchProfileIndex(int targetPos, int offset)
    {
        var targetProfile = GetLaunchProfile(targetPos);
        if (targetProfile is null || offset == 0
                                  || (offset < 0 && targetProfile.Profile.Order - offset < 0)
                                  || (offset > 0 && targetProfile.Profile.Order + offset > LaunchProfiles.Count - 1)
           )
        {
            return;
        }

        var newOffset = targetProfile.Profile.Order + offset;

        foreach (var lp in LaunchProfiles.Where((x) => x.Name != targetProfile.Name))
        {
            switch (offset)
            {
                case > 0 when lp.Profile.Order >= newOffset:
                    lp.Profile.Order -= 1;
                    break;
                case < 0 when lp.Profile.Order <= newOffset:
                    lp.Profile.Order += 1;
                    break;
                default:
                    break;
            }
        }

        targetProfile.Profile.Order = newOffset;
        SortLaunchProfiles();
    }

    public void SetLaunchProfileSaveName(string saveName)
    {
        if (SelectedLaunchProfile is null)
        {
            return;
        }

        SelectedLaunchProfile.Profile.LoadSaveName = saveName;
    }
}
