using CommunityToolkit.Mvvm.ComponentModel;


namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// A simple "search and replace" dialog. Needs to register in GenericHost via AddTransient.
/// </summary>
public partial class CreateMaterialsDialogViewModel() : ObservableObject
{
    /// <summary>
    /// The base material ("{material}" will perform substitutions)
    /// </summary>
    [ObservableProperty] private string? _baseMaterial = "";

    /// <summary>
    /// Local or external material?
    /// </summary>
    [ObservableProperty] private bool _isLocalMaterial = true;

    /// <summary>
    /// Substitute in material path (for dynamic materials)
    /// </summary>
    [ObservableProperty] private bool _resolveSubstitutions = false;

    /// <summary>
    /// Remember selection?
    /// </summary>
    [ObservableProperty] private bool _rememberValues = false;
}