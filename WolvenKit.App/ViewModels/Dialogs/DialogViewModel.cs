using System;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Services;

namespace WolvenKit.App.ViewModels.Dialogs;

public abstract class DialogViewModel : ObservableObject
{
    public delegate void DialogHandlerDelegate(DialogViewModel? sender);
    public DialogHandlerDelegate? DialogHandler { get; set; }
}

public abstract class DialogWindowViewModel : ObservableObject
{

}

/// <summary>
/// Base class for dialog view models used with <see cref="IDialogService"/>.
/// </summary>
/// <remarks>
/// <para>
/// <see cref="Close"/> needs to be called to close the dialog.
/// </para>
/// </remarks>
// Keep that as extra class for now. Can be renamed when all DialogViewModel/DialogWindowViewModel are migrated.
public abstract class DialogExtViewModel : ObservableObject
{
    /// <summary>
    /// Gets or sets the title of the dialog.
    /// </summary>
    public string Title { get; protected set; } = string.Empty;

    /// <summary>
    /// Occurs when the dialog is closed.
    /// </summary>
    public event EventHandler? Closed;

    /// <summary>
    /// Closes the dialog.
    /// </summary>
    protected void Close() => Closed?.Invoke(this, EventArgs.Empty);
}
