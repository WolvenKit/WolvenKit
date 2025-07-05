using System;
using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        foreach (var (key, value) in _settingsManager.LaunchProfiles)
        {
            var newProfile = new LaunchProfileViewModel(key, value);
            LaunchProfiles.Add(newProfile);
        }

        // Order them
        var withOrder = LaunchProfiles.Where(p => p.Profile.Order.HasValue).OrderBy(p => p.Profile.Order).ToArray();
        var withoutOrder = LaunchProfiles.Where(p => !p.Profile.Order.HasValue).OrderBy(p => p.Name).ToArray();

        var allProfiles = withOrder.Concat(withoutOrder).ToArray();

        var order = 0;
        foreach (var profile in allProfiles)
        {
            profile.Profile.Order = order++;
        }

        LaunchProfiles = new ObservableCollection<LaunchProfileViewModel>(allProfiles);

        SortLaunchProfiles();
        
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

    private bool CanPositionDown() => (SelectedLaunchProfile?.Profile.Order ?? -1) < LaunchProfiles.Count();

    [RelayCommand(CanExecute = nameof(CanPositionDown))]
    private void PositionDown()
    {
        if (SelectedLaunchProfile is null ||
            LaunchProfiles.LastOrDefault(p => p.Profile.Order == SelectedLaunchProfile.Profile.Order + 1) is not { } other)
        {
            return;
        }

        IsUpdating?.Invoke(this, true);
        SelectedLaunchProfile.Profile.SwitchPosition(other.Profile);
        SortLaunchProfiles();
        IsUpdating?.Invoke(this, false);
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

        IsUpdating?.Invoke(this, true);
        SelectedLaunchProfile.Profile.SwitchPosition(other.Profile);
        SortLaunchProfiles();
        IsUpdating?.Invoke(this, false);
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

    [ObservableProperty] private ObservableCollection<LaunchProfileViewModel> _launchProfiles = [];

    [ObservableProperty] private LaunchProfileViewModel? _selectedLaunchProfile;

    public event EventHandler<bool>? IsUpdating; 
    
    // Sort launch profiles by order for display, then write them back to the settings manager (is that even necessary?)
    private void SortLaunchProfiles()
    {
        var orderedIndex = SelectedLaunchProfile?.Profile.Order;
        var orderedProfiles = LaunchProfiles.OrderBy(x => x.Profile.Order)
            .ToDictionary(x => x.Name, x => x.Profile);

        _settingsManager.LaunchProfiles = orderedProfiles;
        LaunchProfiles = new ObservableCollection<LaunchProfileViewModel>(orderedProfiles
            .Select(kvp => new LaunchProfileViewModel(kvp.Key, kvp.Value)));

        SelectedLaunchProfile = LaunchProfiles.FirstOrDefault((lp) => lp.Profile.Order == orderedIndex);
    }

    public string Title { get; set; }

    /// <summary>
    /// Updates launch profile index on drag&drop
    /// </summary>
    /// <param name="sourceProfile">source profile to update</param>
    /// <param name="targetPos">Position of target record</param>
    /// <param name="offset">1 or -1, depending on if the record should come before or after it</param>
    public void UpdateLaunchProfileIndex(LaunchProfile sourceProfile, int targetPos, int offset)
    {
        if (GetLaunchProfile(targetPos) is not LaunchProfileViewModel targetProfile)
        {
            return;
        }

        // Prevent out-of-bounds
        var orgPos = Math.Max(Math.Min(sourceProfile.Order ?? 0, 0), LaunchProfiles.Count - 1);
        var newPos = (targetProfile.Profile.Order ?? 0) + offset;
        newPos = Math.Max(Math.Min(newPos, 0), LaunchProfiles.Count - 1);

        if (orgPos == newPos)
        {
            return;
        }

        // Adjust the order of other profiles affected by this change
        foreach (var pr in LaunchProfiles.Where(p =>
                     p.Profile.Order < Math.Min(orgPos, newPos) || p.Profile.Order > Math.Max(orgPos, newPos)))
        {
            if (pr.Profile.Equals(sourceProfile))
            {
                pr.Profile.Order = newPos;
            }
            else if (sourceProfile.Order < newPos)
            {
                // Move profiles between the source and target one position up
                pr.Profile.Order--;
            }
            else if (sourceProfile.Order > newPos)
            {
                // Move profiles between the source and target one position down
                pr.Profile.Order++;
            }
        }
        
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
