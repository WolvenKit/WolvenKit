using System;
using System.Collections.ObjectModel;
using System.Reactive;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        if (_settingsManager.LaunchProfiles is not null)
        {
            foreach ((var key, var value) in _settingsManager.LaunchProfiles)
            {
                LaunchProfiles.Add(new LaunchProfileViewModel(key, value));
            }
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

    [RelayCommand]
    private void DeleteItem()
    {
        if (SelectedLaunchProfile != null)
        {
            LaunchProfiles.Remove(SelectedLaunchProfile);
        }
    }

    [ObservableProperty] private ObservableCollection<LaunchProfileViewModel> _launchProfiles = new();

    [ObservableProperty] private LaunchProfileViewModel? _selectedLaunchProfile;


    public string Title { get; set; }
}
